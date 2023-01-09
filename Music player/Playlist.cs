using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Music_player
{
    public partial class Playlist : Form
    {
        public Playlist()
        {
            InitializeComponent();
        }

        string playlist_folder = @"C:\Users\LENOVO\Desktop\Music player\Playlist";

        private void addplaylist_button_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void InitFolder(Button b, Point x, Label list_name, String name)
        {
            b.Location = x;
            b.BackgroundImageLayout = ImageLayout.Stretch;
            b.BackColor = Color.White;
            b.Size = new Size(50, 50);
            b.BackgroundImage = Properties.Resources.ipiccy_image;
            list_name.Location = new Point(b.Location.X, b.Location.Y + b.Height + 5);
            list_name.AutoSize = false;
            list_name.Width = b.Width;
            list_name.Font = new Font(new FontFamily("Microsoft Sans Serif"), 10);
            list_name.TextAlign = ContentAlignment.MiddleCenter;
            list_name.Text = name;

            string playlist_path = @"C:\Users\LENOVO\Desktop\Music player\Playlist\" + name + @"\";

            b.Click += (sender, args) =>
            {
                listBox1.Items.Clear();
                string[] allfiles = Directory.GetFiles(playlist_path, "*.*", SearchOption.AllDirectories);
                foreach (var item in allfiles)
                {
                    string item1 = item.Replace(playlist_path, "");
                    item1 = item1.Replace(".mp3", "");
                    listBox1.Items.Add(item1);
                }

                 add_click(playlist_path);
                 previous_button_Click(playlist_path);
                 next_button_Click(playlist_path);
                 choose_music(playlist_path);
                 delete(playlist_path);



            };

        }


        string[] filePath;
        string[] fileName;
        private void add_click(string path)
        {
            button3.Click += (sender, args) =>
            {
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "Select music";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileNames;
                    fileName = openFileDialog.SafeFileNames;
                    foreach (var item in filePath)
                    {
                        File.Copy(item, path + Path.GetFileName(item));
                    }
                    listBox1.Items.Clear();
                    string[] allfiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                    foreach (var item in allfiles)
                    {
                        string item1 = item.Replace(path, "");
                        item1 = item1.Replace(".mp3", "");
                        listBox1.Items.Add(item1);
                    }
                }
            };
        }

        private void Playlist_Load(object sender, EventArgs e)
        {
            string[] folders = Directory.GetDirectories(playlist_folder, "*", SearchOption.AllDirectories);
            Point locate = new Point(20, 10);
            int item = 1;
            foreach (string folder in folders)
            {
                string playlistname = folder.Replace(@"C:\Users\LENOVO\Desktop\Music player\Playlist\", "");
                Button b = new Button();
                Label l = new Label();
                InitFolder(b, locate, l, playlistname);
                panel1.Controls.Add(b);
                panel1.Controls.Add(l);
                if (item == 3)
                {
                    item = 1;
                    locate.X = 20;
                    locate.Y += 30 + b.Height;
                }
                else
                {
                    item += 1;
                    locate.X += 20 + b.Width;
                }
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string list_name = textBox1.Text;
            if (e.KeyChar == (char)Keys.Enter)
            {
                string pathString = System.IO.Path.Combine(playlist_folder, list_name);
                System.IO.Directory.CreateDirectory(pathString);

            }

            panel1.Controls.Clear();

            string[] folders = Directory.GetDirectories(playlist_folder, "*", SearchOption.AllDirectories);

            Point locate = new Point(20, 10);
            int item = 1;
            foreach (string folder in folders)
            {
                string playlistname = folder.Replace(@"C:\Users\LENOVO\Desktop\Music player\Playlist\", "");
                Button b = new Button();
                Label l = new Label();
                InitFolder(b, locate, l, playlistname);
                panel1.Controls.Add(b);
                panel1.Controls.Add(l);
                if (item == 5)
                {
                    item = 1;
                    locate.X = 20;
                    locate.Y += 30 + b.Height;
                }
                else
                {
                    item += 1;
                    locate.X += 20 + b.Width;
                }
            }

        }
        private void choose_music(string path)
        {
            string[] allfiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            listBox1.DoubleClick += (sender, args) =>
            {
                if (listBox1.SelectedIndex != -1)
                {
                    int choose = listBox1.SelectedIndex;
                    axWindowsMediaPlayer1.URL = allfiles[listBox1.SelectedIndex];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            };
        }
        private void pause_button_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void next_button_Click(string path)
        {
            next_button.Click += (sender, args) =>
            {
                string[] allfiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                    axWindowsMediaPlayer1.URL = allfiles[listBox1.SelectedIndex];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            };

        }

        private void previous_button_Click(string path)
        {
            previous_button.Click += (sender, args) =>
            {
                string[] allfiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                if (listBox1.SelectedIndex < listBox1.Items.Count + 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
                    axWindowsMediaPlayer1.URL = allfiles[listBox1.SelectedIndex];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }

            };
        }
        private void delete(string path)
        {
            string[] allfiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            delete_button.Click += (sender, args) =>
            {
                if (listBox1.SelectedItems.Count > 0)
                {
                    File.Delete(path + listBox1.SelectedItems[0] + ".mp3");
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }
            };
        }

        private void pause_button_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void play_button_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
    
}
