using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Microsoft.Web.WebView2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Task12356
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        string url;

        private string getHTML(string szURL)
        {
            url = textBox1.Text;
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            // Load the URL
            url = textBox1.Text;
            getHTML(url);
            webView.Source = new Uri(url);
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            url = textBox1.Text;
            getHTML(url);
            webView.Source = new Uri(url);
        }

        private void btn_downS_Click(object sender, EventArgs e)
        {
            url = textBox1.Text;
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(url);
            string url_file;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "HTML File|*.html";
            save.Title = "Save an HTML File";
            if (save.ShowDialog() == DialogResult.OK)
            {
                url_file = save.FileName;
            }
            else
            {
                MessageBox.Show("File not saved");
                return;
            }
            myClient.DownloadFile(url, url_file);
            response.Close();
        }

        private void btn_downR_Click(object sender, EventArgs e)
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(textBox1.Text);

            var imgs = htmlDoc.DocumentNode.SelectNodes("//img");
            List<string> imageUrls = new List<string>();

            foreach (var img in imgs)
            {
                var imgURL = img.GetAttributeValue("src", "");
                imageUrls.Add(imgURL);
            }
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                DownloadImages(imageUrls, folderBrowserDialog.SelectedPath);
            }
        }

        private void DownloadImages(List<string> imageUrls, string destinationDirectory)
        {
            foreach (var imageUrl in imageUrls)
            {
                using (WebClient client = new WebClient())
                {
                    try
                    {
                        string fileName = imageUrl.Substring(imageUrl.LastIndexOf("/") + 1);
                        string path = Path.Combine(destinationDirectory, fileName);
                        client.DownloadFile(imageUrl, path);
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void btn_viewS_Click(object sender, EventArgs e)
        {
            url = textBox1.Text;
            var html = getHTML(url);
            ViewSource view = new ViewSource();
            view.Hienthi(html.ToString());
            view.Show();
        }
    }
}
