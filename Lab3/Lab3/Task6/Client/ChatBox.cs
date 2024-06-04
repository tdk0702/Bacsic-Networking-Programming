using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Task6.Communicator;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using Application = System.Windows.Forms.Application;

namespace Lab3.Task6.Client
{
    public partial class ChatBox : Form
    {
        private TcpClient server;
        private String name;
        private bool threadActive = true;
        private StreamReader streamReader;
        private StreamWriter streamWriter;

        public ChatBox(TcpClient server, String name)
        {
            this.server = server;
            this.name = name;
            InitializeComponent();
        }

        private void ChatBox_Load(object sender, EventArgs e)
        {
            streamReader = new StreamReader(server.GetStream());
            streamWriter = new StreamWriter(server.GetStream());

            this.Text = "Chat app - " + name;
            lblWelcome.Text = "Welcome, " + name;

            var mainThread = new Thread(() => receiveTheard());
            mainThread.Start();
            mainThread.IsBackground = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text == "")
            {
                MessageBox.Show("Empty Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtReceiver.Text == this.name)
            {
                MessageBox.Show("Could not send message to yourself", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Messages message = new Messages(this.name, txtReceiver.Text, txtMessage.Text);
            String messageJson = JsonSerializer.Serialize(message);
            Json json = new Json("MESSAGE", messageJson);
            sendJson(json);
            txtMessage.Clear();
        }

        private void tblUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtReceiver.Text = tblUser.Rows[e.RowIndex].Cells["Online"].Value.ToString();
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n')
            {
                btnSend_Click(this.btnSend, e);
            }
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (txtReceiver.Text == "")
            {
                MessageBox.Show("Receiver field is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Thread dialogThread = new Thread(() =>
            {
                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    //ofd.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        String fName = ofd.FileName;
                        String path = "";
                        fName = fName.Replace("\\", "/");
                        while (fName.IndexOf("/") > -1)
                        {
                            path += fName.Substring(0, fName.IndexOf("/") + 1);
                            fName = fName.Substring(fName.IndexOf("/") + 1);
                        }

                        FileMessage message = new FileMessage(this.name, txtReceiver.Text, File.ReadAllBytes(path + fName).Length.ToString(), Path.GetExtension(ofd.FileName));

                        Json json = new Json("FILE", JsonSerializer.Serialize(message));
                        sendJson(json);

                        server.Client.SendFile(path + fName);

                        AppendRichTextBox(this.name, message.receiver, "The file was sent.", "");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
            dialogThread.SetApartmentState(ApartmentState.STA);
            dialogThread.Start();
            dialogThread.IsBackground = true;
        }

        private void receiveTheard()
        {
            while (server != null && threadActive)
            {
                try
                {
                    String jsonString = streamReader.ReadLine();
                    Json? infoJson = JsonSerializer.Deserialize<Json?>(jsonString);

                    switch (infoJson.type)
                    {
                        case "STARTUP_FEEDBACK":
                            cleanDataGridView(tblUser);

                            Startup startup = JsonSerializer.Deserialize<Startup>(infoJson.content);

                            List<string> users = JsonSerializer.Deserialize<List<String>>(startup.onlUser);
                            foreach (String user in users)
                            {
                                addDataInDataGridView(tblUser, new string[] { user });
                            }
                            break;
                        case "MESSAGE":
                            if (infoJson.content != null)
                            {
                                Messages message = JsonSerializer.Deserialize<Messages?>(infoJson.content);
                                if (message != null)
                                {
                                    AppendRichTextBox(message.sender, message.receiver, message.message, "");
                                }
                            }
                            break;
                        case "FILE":
                            if (infoJson.content != null)
                            {
                                BufferFile bufferFile = JsonSerializer.Deserialize<BufferFile>(infoJson.content);
                                List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".JPE", ".BMP", ".GIF", ".PNG" };

                                if (ImageExtensions.Contains(bufferFile.extension.ToUpper()))
                                {
                                    new Thread(() => Application.Run(new ImageView(bufferFile))).Start();

                                    AppendRichTextBox(bufferFile.sender, bufferFile.receiver, "Shared the " + bufferFile.extension + " file in ", @Environment.CurrentDirectory);
                                }
                                else
                                {
                                    string fileName = @Environment.CurrentDirectory + "/" + String.Format("{0:yyyy-MM-dd HH-mm-ss}__{1}", DateTime.Now, bufferFile.sender) + bufferFile.extension;
                                    FileInfo fi = new FileInfo(fileName);

                                    try
                                    {
                                        // Check if file already exists. If yes, delete it.     
                                        if (fi.Exists)
                                        {
                                            fi.Delete();
                                        }

                                        using (FileStream fStream = File.Create(fileName))
                                        {
                                            fStream.Write(bufferFile.buffer, 0, bufferFile.buffer.Length);
                                            fStream.Flush();
                                            fStream.Close();
                                        }
                                    }
                                    catch (Exception Ex)
                                    {
                                        Console.WriteLine(Ex.ToString());
                                    }

                                    AppendRichTextBox(bufferFile.sender, bufferFile.receiver, "Shared the " + bufferFile.extension + " file in ", @Environment.CurrentDirectory);
                                }
                            }
                            break;
                    }

                }
                catch
                {
                    threadActive = false;
                }
            }
        }

        private void AppendRichTextBox(string sender, string receiver, string message, string link)
        {
            string text = "";
            // Sender
            text += (sender == this.name ? "You" : (sender));
            text += " to " + (receiver == this.name? "you" : receiver == ""? "ALL" : receiver) + ": ";
            text += message + " ";
            text += link;
            
            rtbDialog.Text += text;

            rtbDialog.AppendText(Environment.NewLine);
        }

        private void cleanDataGridView(DataGridView dataGridView)
        {
            dataGridView.BeginInvoke(new MethodInvoker(() =>
            {
                dataGridView.Rows.Clear();
            }));

        }

        private void addDataInDataGridView(DataGridView dataGridView, String[] array)
        {
            dataGridView.Invoke(new Action(() => { dataGridView.Rows.Add(array); }));
        }

        private void sendJson(Json json)
        {
            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(json);
            string S = Encoding.ASCII.GetString(jsonUtf8Bytes, 0, jsonUtf8Bytes.Length);

            streamWriter.WriteLine(S);
            streamWriter.Flush();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            string receiver = txtReceiver.Text;

            if (receiver == "")
            {
                MessageBox.Show("Empty Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (receiver == this.Name)
            {
                MessageBox.Show("Could not send message to yourself", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Messages messages = new Messages(this.name, receiver, "👍");
            String messageJson = JsonSerializer.Serialize(messages);
            Json json = new Json("MESSAGE", messageJson);
            sendJson(json);

            txtMessage.Clear();
        }


        private void ChatBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            Json json = new Json("LOGOUT", this.name);
            sendJson(json);
            threadActive = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Json json = new Json("LOGOUT", this.name);
            sendJson(json);
            threadActive = false;
            this.Close();
        }
    }
}
