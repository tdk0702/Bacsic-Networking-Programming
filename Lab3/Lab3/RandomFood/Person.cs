using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Lab3.RandomFood
{

    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
            DeleteTables();
            CreateTables();
            LoadDataset();
            lb_helo.Text = $"Hôm nay {RandomFood.Menu.person} ăn gì?";
        }

        private void CreateTables()
        {
            using (SQLiteConnection connection = 
            new SQLiteConnection("Data Source=food_database.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand Command = new SQLiteCommand(connection))
                {
                    //Tạo bảng món ăn
                    Command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS MonAn (
                        IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                        TenMonAn TEXT,
                        HinhAnh TEXT,
                        IDNCC INTEGER
                    );";
                    Command.ExecuteNonQuery();
                    //Tạo bảng người dùng
                    Command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS NguoiDung (
                        IDNCC INTEGER PRIMARY KEY,
                        HoVaTen TEXT,
                        QuyenHan TEXT
                    );";
                    Command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private void DeleteTables()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=food_database.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand Command = new SQLiteCommand(connection))
                {
                    // Xóa bảng MonAn
                    Command.CommandText = "DROP TABLE IF EXISTS MonAn;";
                    Command.ExecuteNonQuery();

                    // Xóa bảng NguoiDung
                    Command.CommandText = "DROP TABLE IF EXISTS NguoiDung;";
                    Command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private void ShowListView()
        {
            list_item.Items.Clear();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=food_database.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand Command = new SQLiteCommand("SELECT * FROM MonAn", connection))
                {
                    using (SQLiteDataReader reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["TenMonAn"].ToString());
                            item.SubItems.Add(reader["HinhAnh"].ToString());
                            item.SubItems.Add(reader["IDNCC"].ToString());
                            list_item.Items.Add(item);
                        }
                    }
                }
                connection.Close();
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            result_text.Clear();
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=food_database.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand Command = new SQLiteCommand("SELECT MonAn.TenMonAn, MonAn.HinhAnh, NguoiDung.HoVaTen FROM MonAn INNER JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC ORDER BY RANDOM() LIMIT 1", connection))
                {
                    using (SQLiteDataReader reader = Command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string foodName = reader["TenMonAn"].ToString();
                            string foodImage = reader["HinhAnh"].ToString();
                            string HoVaTen = reader["HoVaTen"].ToString();
                            picture_food.Image = Image.FromFile(foodImage);
                            result_text.Text = $"{foodName} \r\nNgười thêm: {HoVaTen}";
                        }
                        else
                        {
                            result_text.Text = "Không tìm thấy món ăn ngẫu nhiên";
                        }
                    }
                }
                connection.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (list_item.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in list_item.SelectedItems)
                {
                    string foodName = selectedItem.Text;
                    using (SQLiteConnection connection = new SQLiteConnection("Data Source=food_database.db;Version=3;"))
                    {
                        connection.Open();
                        using (SQLiteCommand deleteCommand = new SQLiteCommand("DELETE FROM MonAn WHERE TenMonAn = @name", connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@name", foodName);
                            deleteCommand.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
                ShowListView();
            }
        }

        string imageLocation = "";

        private void btn_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.jpeg)|*.jpg;*.png;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = openFileDialog.FileName;
                cb_image.Checked = true;
            }
            else
            {
                MessageBox.Show("Chọn ảnh không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                imageLocation = "";
                cb_image.Checked = false;
            }
        }

        int idncc = 0;

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_food.Text == "" || cb_image.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            idncc += 1;
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=food_database.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand Command = new SQLiteCommand("INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@name, @image, @contributorId)", connection))
                {
                    Command.Parameters.AddWithValue("@name", tb_food.Text);
                    Command.Parameters.AddWithValue("@image", imageLocation);
                    Command.Parameters.AddWithValue("@contributorId", idncc);
                    Command.ExecuteNonQuery();
                }
                using (SQLiteCommand Command = new SQLiteCommand("INSERT INTO NguoiDung (IDNCC, HoVaTen, QuyenHan) VALUES (@id, @name, @role)", connection))
                {
                    Command.Parameters.AddWithValue("@id", idncc);
                    Command.Parameters.AddWithValue("@name", RandomFood.Menu.person);
                    Command.Parameters.AddWithValue("@role", idncc);
                    Command.ExecuteNonQuery();
                }
                connection.Close();
            }
            ShowListView();
            imageLocation = "";
            cb_image.Checked = false;
            tb_food.Clear();
        }

        private void LoadDataset()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=food_database.db;Version=3;"))
                {
                    connection.Open();

                    using (StreamReader sr = new StreamReader($"{RandomFood.Menu.person}.txt"))
                    {
                        string line;
                        bool isMonAnSection = false;
                        bool isNguoiDungSection = false;

                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.StartsWith("# MonAn"))
                            {
                                isMonAnSection = true;
                                isNguoiDungSection = false;
                                continue;
                            }
                            else if (line.StartsWith("# NguoiDung"))
                            {
                                isMonAnSection = false;
                                isNguoiDungSection = true;
                                continue;
                            }
                            else if (line.Trim() != "")
                            {
                                string[] fields = line.Split(',');

                                if (isMonAnSection && fields.Length == 4)
                                {
                                    using (SQLiteCommand Command = new SQLiteCommand("INSERT INTO MonAn (IDMA, TenMonAn, HinhAnh, IDNCC) VALUES (@id, @name, @image, @contributorId)", connection))
                                    {
                                        Command.Parameters.AddWithValue("@id", Convert.ToInt32(fields[0]));
                                        Command.Parameters.AddWithValue("@name", fields[1]);
                                        Command.Parameters.AddWithValue("@image", fields[2]);
                                        Command.Parameters.AddWithValue("@contributorId", Convert.ToInt32(fields[3]));
                                        Command.ExecuteNonQuery();
                                    }
                                }
                                else if (isNguoiDungSection && fields.Length == 3)
                                {
                                    using (SQLiteCommand Command = new SQLiteCommand("INSERT INTO NguoiDung (IDNCC, HoVaTen, QuyenHan) VALUES (@id, @name, @role)", connection))
                                    {
                                        Command.Parameters.AddWithValue("@id", Convert.ToInt32(fields[0]));
                                        Command.Parameters.AddWithValue("@name", fields[1]);
                                        Command.Parameters.AddWithValue("@role", fields[2]);
                                        Command.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Nội dung của tệp sai cấu trúc của bảng MonAn và NguoiDung.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Người dùng mới, chưa có sẵn dữ liệu\nVui lòng thêm món ăn để tìm kiếm.", "Người dùng mới", MessageBoxButtons.OK);
            }
            ShowListView();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Thread serverThread;

        private void Person_Load(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        private void Person_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteTables();
            listenerSocket.Close();
            if (serverThread.IsAlive)
            {
                serverThread.Abort();
            }
        }

        Socket listenerSocket;
        void StartUnsafeThread()
        {
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IP = new IPEndPoint(IPAddress.Any, 8080);
            listenerSocket.Bind(IP);
            listenerSocket.Listen(100);
            while (true)
            {
                Socket clientSocket = listenerSocket.Accept();
                Thread thread = new Thread(() => Receive(clientSocket));
                thread.Start();
            }
        }

        public void Receive(Socket clientSocket)
        {
            while (clientSocket.Connected)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 5000];
                    int bytesRead = clientSocket.Receive(buffer);
                    string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    if (!string.IsNullOrEmpty(data))
                    {
                        if (data.StartsWith("@@@"))
                        {
                            add_data_client(data);
                        }
                        else
                        {
                            // Receive image data
                            using (MemoryStream ms = new MemoryStream())
                            {
                                ms.Write(buffer, 0, bytesRead);
                                while (clientSocket.Available > 0)
                                {
                                    bytesRead = clientSocket.Receive(buffer);
                                    ms.Write(buffer, 0, bytesRead);
                                }
                                byte[] imageData = ms.ToArray();
                                // Process the image data here
                                using (FileStream fs = new FileStream($"{idncc}.jpg", FileMode.Create, FileAccess.Write))
                                {
                                    fs.Write(imageData, 0, imageData.Length);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                    MessageBox.Show("Error receiving message: " + ex.Message);
                    break;
                }
            }
        }

        public void add_data_client(string data)
        {
            string[] data_split = data.Split('\n');
            idncc += 1;
            imageLocation = $"{idncc}.jpg";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=food_database.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand Command = new 
                    SQLiteCommand("INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@name, @image, @contributorId)", connection))
                {
                    Command.Parameters.AddWithValue("@name", data_split[2]);
                    Command.Parameters.AddWithValue("@image", imageLocation);
                    Command.Parameters.AddWithValue("@contributorId", idncc);
                    Command.ExecuteNonQuery();
                }
                using (SQLiteCommand Command = new 
                    SQLiteCommand("INSERT INTO NguoiDung (IDNCC, HoVaTen, QuyenHan) VALUES (@id, @name, @role)", connection))
                {
                    Command.Parameters.AddWithValue("@id", idncc);
                    Command.Parameters.AddWithValue("@name", data_split[1]);
                    Command.Parameters.AddWithValue("@role", idncc);
                    Command.ExecuteNonQuery();
                }
                connection.Close();
            }
            ShowListView();
        }
    }
}
