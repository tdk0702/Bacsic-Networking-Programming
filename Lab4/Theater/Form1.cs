using System.Net;
using HtmlAgilityPack;
namespace Theater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(@"https://betacinemas.vn/phim.htm");
                HtmlAgilityPack.HtmlDocument hd = new HtmlAgilityPack.HtmlDocument();
                hd.LoadHtml(json);
                HtmlNodeCollection hnc = hd.DocumentNode.SelectNodes("//div[@class='film-info film-xs-info']/h3/a");
                List<string> urls = new List<string>();
                foreach(HtmlNode hn in hnc)
                {
                    string url = hn.GetAttributeValue("href", "");
                    urls.Add(@"https://betacinemas.vn" + url);
                }
                foreach (string url in urls) {
                    json = wc.DownloadString(url);
                    hd.LoadHtml(json);
                    HtmlNode hn = hd.DocumentNode.SelectSingleNode("//h1[@class='bold no-margin margin-bottom-15']");
                    string name = hn.InnerText.Trim();
                    richTextBox1.Text += name + "\r\n";
                    hn = hd.DocumentNode.SelectSingleNode("//p[@class='margin-bottom-15 font-lg font-family-san text-justify']");
                    string origin = hn.InnerText.Trim() + "\r\n";
                    hnc = hd.DocumentNode.SelectNodes("//div[@class='row font-lg font-family-san font-xs-14']/div");
                    foreach(HtmlNode htmlNode in hnc) { 
                        origin += htmlNode.InnerText.Trim() + "\r\n";
                        Thread.Sleep(10);
                    }
                    origin = origin.Replace(":\r\n", ": ");
                    richTextBox1.Text += origin + "\r\n";
                    hn = hd.DocumentNode.SelectSingleNode("//div[@class='pi-img-wrapper']/img");
                    string img = hn.GetAttributeValue("src", "");
                    richTextBox1.Text += img + "\r\n";
                }
                /*var request = WebRequest.Create(imgs[0]);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBox1.Image = Bitmap.FromStream(stream);
                }*/
                //richTextBox1.Text = string.Join("\r\n", urls);
            }
        }
    }
}
