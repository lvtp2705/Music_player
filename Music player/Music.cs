using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_player
{
    public partial class Music : Form
    {
        public Music()
        {
            InitializeComponent();
        }

        private void download_music(string file_url)
        {
            download_button.Click += (sender, args) =>
            {
                var folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string des_path = folderDlg.SelectedPath;
                    File.Copy(file_url, des_path + "\\" + Path.GetFileName(file_url));
                }

            };
        }

        private void like_music(string file_url)
        {
            like_button.Click += (sender, args) =>
            {
                string message = "Đã thêm vào mục Yêu Thích";
                MessageBox.Show(message);
                string des_path = @"C:\\Users\\LENOVO\\Desktop\\Music player\\Yeuthich";
                File.Copy(file_url, des_path + "\\" + Path.GetFileName(file_url));
            };
        }
        private void Music_Load(object sender, EventArgs e)
        {
            star1.BackgroundImage = Properties.Resources.empty_star;
            star2.BackgroundImage = Properties.Resources.empty_star;
            star3.BackgroundImage = Properties.Resources.empty_star;
            star4.BackgroundImage = Properties.Resources.empty_star;
            star5.BackgroundImage = Properties.Resources.empty_star;
        
            


            switch (this.Text)
            {
                case "Có chắc yêu là đây":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\01.mp3";
                    music_pic.Image = Properties.Resources._01;
                    comment_pic.Image = Properties.Resources._01;
                    rating_pic.Image = Properties.Resources._01;
                    label1.Text = Properties.Resources._01x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Sơn Tùng M-TP";
                    composer_label1.Text = "Sơn Tùng M-TP";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Có chàng trai viết lên cây":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\02.mp3";
                    music_pic.Image = Properties.Resources._02;
                    comment_pic.Image = Properties.Resources._02;
                    rating_pic.Image = Properties.Resources._02;
                    label1.Text = Properties.Resources._02x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Phan Mạnh Quỳnh";
                    composer_label1.Text = "Phan Mạnh Quỳnh";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Em gái mưa":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\03.mp3";
                    music_pic.Image = Properties.Resources._03;
                    comment_pic.Image = Properties.Resources._03;
                    rating_pic.Image = Properties.Resources._03;
                    label1.Text = Properties.Resources._03x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Hương Tràm";
                    composer_label1.Text = "Mr.Siro";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Bigcity boy":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\11.mp3";
                    music_pic.Image = Properties.Resources._11;
                    comment_pic.Image = Properties.Resources._11;
                    rating_pic.Image = Properties.Resources._11;
                    label1.Text = Properties.Resources._11x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Binz";
                    composer_label1.Text = "Binz";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Đưa nhau đi trốn":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\12.mp3";
                    music_pic.Image = Properties.Resources._12;
                    comment_pic.Image = Properties.Resources._12;
                    rating_pic.Image = Properties.Resources._12;
                    label1.Text = Properties.Resources._12x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Đen";
                    composer_label1.Text = "Đen";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;
                case "Hoa hải đường":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\13.mp3";
                    music_pic.Image = Properties.Resources._13;
                    comment_pic.Image = Properties.Resources._13;
                    rating_pic.Image = Properties.Resources._13;
                    label1.Text = Properties.Resources._13x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Jack";
                    composer_label1.Text = "Jack";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Đập vỡ cây đàn":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\21.mp3";
                    music_pic.Image = Properties.Resources._21;
                    comment_pic.Image = Properties.Resources._21;
                    rating_pic.Image = Properties.Resources._21;
                    label1.Text = Properties.Resources._21x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Quang Lê";
                    composer_label1.Text = "Trường Vũ";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Duyên phận":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\22.mp3";
                    music_pic.Image = Properties.Resources._22;
                    comment_pic.Image = Properties.Resources._22;
                    rating_pic.Image = Properties.Resources._22;
                    label1.Text = Properties.Resources._22x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Như Quỳnh";
                    composer_label1.Text = "Dương Hồng Loan";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Về đâu máy tóc người thương":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\23.mp3";
                    music_pic.Image = Properties.Resources._23;
                    comment_pic.Image = Properties.Resources._23;
                    rating_pic.Image = Properties.Resources._23;
                    label1.Text = Properties.Resources._23x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Hoài Lâm";
                    composer_label1.Text = "Hoài Linh";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Đường tôi chở em về":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\31.mp3";
                    music_pic.Image = Properties.Resources._31;
                    comment_pic.Image = Properties.Resources._31;
                    rating_pic.Image = Properties.Resources._31;
                    label1.Text = Properties.Resources._31x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "BuiTruongLinh";
                    composer_label1.Text = "BuiTruongLinh x CuCak";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "See tình":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\32.mp3";
                    music_pic.Image = Properties.Resources._32;
                    comment_pic.Image = Properties.Resources._32;
                    rating_pic.Image = Properties.Resources._32;
                    label1.Text = Properties.Resources._32x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Rin9";
                    composer_label1.Text = "Hoàng Thùy Linh x Cucak";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Bỏ em vào balo":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\33.mp3";
                    music_pic.Image = Properties.Resources._33;
                    comment_pic.Image = Properties.Resources._33;
                    rating_pic.Image = Properties.Resources._33;
                    label1.Text = Properties.Resources._33x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Ed Sheeran";
                    composer_label1.Text = "Ed Sheeran";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Senorita":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\41.mp3";
                    music_pic.Image = Properties.Resources._41;
                    comment_pic.Image = Properties.Resources._41;
                    rating_pic.Image = Properties.Resources._41;
                    label1.Text = Properties.Resources._41x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Camilo Cabelo x Shawn Mendes";
                    composer_label1.Text = "Camilo Cabelo x Shawn Mendes";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Shape of you":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\42.mp3";
                    music_pic.Image = Properties.Resources._41;
                    music_pic.Image = Properties.Resources._42;
                    comment_pic.Image = Properties.Resources._42;
                    rating_pic.Image = Properties.Resources._42;
                    label1.Text = Properties.Resources._42x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Ed Sheeran";
                    composer_label1.Text = "Ed Sheeran";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Head in the clouds":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\43.mp3";
                    music_pic.Image = Properties.Resources._43;
                    comment_pic.Image = Properties.Resources._43;
                    rating_pic.Image = Properties.Resources._43;
                    label1.Text = Properties.Resources._43x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "Hayd";
                    composer_label1.Text = "Hayd";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Pink Venom":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\51.mp3";
                    music_pic.Image = Properties.Resources._51;
                    comment_pic.Image = Properties.Resources._51;
                    rating_pic.Image = Properties.Resources._51;
                    label1.Text = Properties.Resources._51x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "BlackPink";
                    composer_label1.Text = "BlackPink";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Dynamite":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\52.mp3";
                    music_pic.Image = Properties.Resources._52;
                    comment_pic.Image = Properties.Resources._52;
                    rating_pic.Image = Properties.Resources._52;
                    label1.Text = Properties.Resources._52x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "BTS";
                    composer_label1.Text = "BTS";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;

                case "Let's kill this love":
                    axWindowsMediaPlayer1.URL = @"C:\Users\LENOVO\Desktop\Media\53.mp3";
                    music_pic.Image = Properties.Resources._53;
                    comment_pic.Image = Properties.Resources._53;
                    rating_pic.Image = Properties.Resources._53;
                    label1.Text = Properties.Resources._53x;
                    song_label.Text = this.Text;
                    comment_name.Text = song_label.Text;
                    rating_name.Text = song_label.Text;
                    singer_label.Text = "BlackPink";
                    composer_label1.Text = "BlackPink";
                    download_music(axWindowsMediaPlayer1.URL);
                    like_music(axWindowsMediaPlayer1.URL);
                    break;
            }
        }

        private void music_pic_Click(object sender, EventArgs e)
        {

        }

        private void comment_button_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Text += System.Environment.NewLine + textBox1.Text;
                textBox1.Text = string.Empty;
                
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

       

        private void star1_Click_1(object sender, EventArgs e)
        {
            star1.BackgroundImage = Properties.Resources.yellow_star;
            star2.BackgroundImage = Properties.Resources.empty_star;
            star3.BackgroundImage = Properties.Resources.empty_star;
            star4.BackgroundImage = Properties.Resources.empty_star;
            star5.BackgroundImage = Properties.Resources.empty_star;
        }

        private void star2_Click_1(object sender, EventArgs e)
        {
            star1.BackgroundImage = Properties.Resources.yellow_star;
            star2.BackgroundImage = Properties.Resources.yellow_star;
            star3.BackgroundImage = Properties.Resources.empty_star;
            star4.BackgroundImage = Properties.Resources.empty_star;
            star5.BackgroundImage = Properties.Resources.empty_star;
        }

        private void star3_Click_1(object sender, EventArgs e)
        {
            star1.BackgroundImage = Properties.Resources.yellow_star;
            star2.BackgroundImage = Properties.Resources.yellow_star;
            star3.BackgroundImage = Properties.Resources.yellow_star;
            star4.BackgroundImage = Properties.Resources.empty_star;
            star5.BackgroundImage = Properties.Resources.empty_star;
        }

        private void star4_Click_1(object sender, EventArgs e)
        {
            star1.BackgroundImage = Properties.Resources.yellow_star;
            star2.BackgroundImage = Properties.Resources.yellow_star;
            star3.BackgroundImage = Properties.Resources.yellow_star;
            star4.BackgroundImage = Properties.Resources.yellow_star;
            star5.BackgroundImage = Properties.Resources.empty_star;
        }

        private void star5_Click_1(object sender, EventArgs e)
        {
            star1.BackgroundImage = Properties.Resources.yellow_star;
            star2.BackgroundImage = Properties.Resources.yellow_star;
            star3.BackgroundImage = Properties.Resources.yellow_star;
            star4.BackgroundImage = Properties.Resources.yellow_star;
            star5.BackgroundImage = Properties.Resources.yellow_star;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void download_button_Click(object sender, EventArgs e)
        {

        }
        
    }
    
}

                