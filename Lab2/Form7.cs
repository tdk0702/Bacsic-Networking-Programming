using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private string removeInvalidFileName(string name)
        {
            return string.Join("_", name.Split(Path.GetInvalidFileNameChars()));
        }

        private string removeInvalidPath(string name)
        {
            return string.Join("_", name.Split(Path.GetInvalidPathChars()));
        }
        private void fillDirectory(string path)
        {
            try
            {
                path = removeInvalidPath(path);
                DirectoryInfo dir = new DirectoryInfo(path);
                prbBrowse.Maximum = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories).Length
                    + Directory.GetFiles(path, "*.png", SearchOption.AllDirectories).Length
                    + Directory.GetFiles(path, "*.bmp", SearchOption.AllDirectories).Length
                    + Directory.GetDirectories(path, "**", SearchOption.AllDirectories).Length;
                TreeNode tn = trvFile.Nodes.Add(dir.Name);
                tn.Tag = dir.FullName;
                tn.StateImageIndex = 0;
                loadFolders(path, tn);
                loadFiles(path, tn);
                //prbBrowse.CreateGraphics().DrawString("Xong", new Font("Arial", 5), Brushes.Black, new PointF(prbBrowse.Width / 2 - 5, prbBrowse.Height / 2 - 3));
                MessageBox.Show("Xong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }
        private void loadFiles(string path, TreeNode tn)
        {
            string[] Files = Directory.GetFiles(path).Where(f => (f.EndsWith(".jpg") || f.EndsWith(".png") || f.EndsWith(".bmp"))).ToArray();
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(removeInvalidPath(file));
                TreeNode stn = tn.Nodes.Add(fi.Name);
                stn.Tag = removeInvalidPath(fi.FullName);
                stn.StateImageIndex = 0;
                updateProgress();
            }
        }
        private void loadFolders(string path, TreeNode tn)
        {
            string[] Folders = Directory.GetDirectories(path);
            foreach (string folder in Folders)
            {
                string fd = removeInvalidPath(folder);
                DirectoryInfo di = new DirectoryInfo(fd);
                TreeNode stn = tn.Nodes.Add(di.Name);
                stn.Tag = di.FullName + "\\";
                stn.StateImageIndex = 0;
                loadFolders(fd, stn);
                loadFiles(fd, stn);
                updateProgress();
            }
        }
        private void updateProgress()
        {
            if (prbBrowse.Value < prbBrowse.Maximum)
            {
                prbBrowse.Value++;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            tbxBrowse.Text = fbd.SelectedPath;
        }

        private void tbxBrowse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                trvFile.Nodes.Clear();
                prbBrowse.Value = 0;
                if (Directory.Exists(tbxBrowse.Text.Trim()))
                    fillDirectory(string.Join("_",tbxBrowse.Text.Split(Path.GetInvalidPathChars())));
                else
                {
                    MessageBox.Show("Chưa chọn đường dẫn.");
                    btnBrowse_Click(this, new EventArgs());
                }

            }
        }

        private void trvFile_DoubleClick(object sender, EventArgs e)
        {
            string path = removeInvalidPath(trvFile.SelectedNode.Tag.ToString());
            if (!path.EndsWith("\\"))
            pbxMain.Image = Image.FromFile(path);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
                trvFile.Nodes.Clear();
        }
    }
}
