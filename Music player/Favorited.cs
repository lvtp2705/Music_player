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
    public partial class Favorited : Form
    {
        DataTable dt;
        public Favorited()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Image", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Singer", typeof(string));
            dt.Columns.Add("Author", typeof(string));

            dt.Rows.Add("01", "Pop Việt", "Có chắc yêu là đây", "Sơn Tùng M-TP", "Sơn Tùng M-TP");
            dt.Rows.Add("02", "Pop Việt", "Có chàng trai viết lên cây", "Phan Mạnh Quỳnh", "Phan Mạnh Quỳnh");
            dt.Rows.Add("03", "Pop Việt", "Em gái mưa", "Hương Tràm", "Mr.Siro");

            dt.Rows.Add("11", "Rap Việt", "Bigcity boy", "Binz", "Binz x Touliver");
            dt.Rows.Add("12", "Rap Việt", "Đưa nhau đi trốn", "Đen", "Đen");
            dt.Rows.Add("13", "Rap Việt", "Hoa hải đường", "Jack", "Jack");

            dt.Rows.Add("21", "Trữ tình", "Đập vỡ cây đàn", "Quang Lê", "Trường Vũ");
            dt.Rows.Add("22", "Trữ tình", "Duyên phận", "Như Quỳnh", "Dương Hồng Loan");
            dt.Rows.Add("23", "Trữ tình", "Về đâu máy tóc người thương", "Hoài Lâm", "Hoài Linh");

            dt.Rows.Add("31", "Remix", "Đường tôi chở em về ", "BuiTruongLinh", "BuiTruongLinh x CuCak");
            dt.Rows.Add("32", "Remix", "See tình", "Rin9", "Hàng Thùy Linh x Cucak");
            dt.Rows.Add("33", "Remix", "Bỏ em vào balo", "Tân Trần", "Orinn");

            dt.Rows.Add("41", "US&UK", "Senorita", "Camilo Cabelo x Shawn Mendes", "Camilo Cabelo x Shawn Mendes");
            dt.Rows.Add("42", "US&UK", "Shape of you", "Ed Sheeran", "Ed Sheeran");
            dt.Rows.Add("43", "US&UK", "Head in the clouds", "Hayd", "Hayd");

            dt.Rows.Add("51", "Kpop", "Pink Venom", "BlackPink", "BlackPink");
            dt.Rows.Add("52", "Kpop", "Dynamite", "BTS", "BTS");
            dt.Rows.Add("53", "Kpop", "Let's kill this love", "BlackPink", "BlackPink");


        }

        private void InitName(Label content, Button b, string name)
        {
            content.Location = new Point(b.Location.X, b.Location.Y + b.Height + 20);
            content.AutoSize = false;
            content.Width = b.Width;
            content.Font = new Font(new FontFamily("Microsoft Sans Serif"), 10, FontStyle.Bold);
            content.ForeColor = Color.DarkGray;
            content.BackColor = Color.Transparent;
            content.TextAlign = ContentAlignment.MiddleCenter;
            content.Text = name;
        }
        private void InitButton(Button b, Point x, string Name)
        {
            b.Location = x;
            b.Size = new Size(150, 150);
            b.BackgroundImageLayout = ImageLayout.Stretch;
            switch (Name)
            {
                case "01":
                    b.BackgroundImage = Properties.Resources._01;
                    Label l = new Label();
                    InitName(l, b, "Có chắc yêu là đây");
                    panel1.Controls.Add(l);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Có chắc yêu là đây";
                        m.Show();
                    };
                    break;

                case "02":
                    b.BackgroundImage = Properties.Resources._02;
                    Label l1 = new Label();
                    InitName(l1, b, "Có chàng trai viết lên cây");
                    panel1.Controls.Add(l1);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Có chàng trai viết lên cây";
                        m.Show();
                    };
                    break;

                case "03":
                    b.BackgroundImage = Properties.Resources._03;
                    Label l2 = new Label();
                    InitName(l2, b, "Em gái mưa");
                    panel1.Controls.Add(l2);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Em gái mưa";
                        m.Show();
                    };
                    break;

                case "11":
                    b.BackgroundImage = Properties.Resources._11;
                    Label l3 = new Label();
                    InitName(l3, b, "Bigcity boy");
                    panel1.Controls.Add(l3);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Bigcity boy";
                        m.Show();
                    };
                    break;

                case "12":
                    b.BackgroundImage = Properties.Resources._12;
                    Label l4 = new Label();
                    InitName(l4, b, "Đưa nhau đi trốn");
                    panel1.Controls.Add(l4);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Đưa nhau đi trốn";
                        m.Show();
                    };
                    break;

                case "13":
                    b.BackgroundImage = Properties.Resources._13;
                    Label l5 = new Label();
                    InitName(l5, b, "Hoa hải đường");
                    panel1.Controls.Add(l5);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Hoa hải đường";
                        m.Show();
                    };
                    break;

                case "21":
                    b.BackgroundImage = Properties.Resources._21;
                    Label l6 = new Label();
                    InitName(l6, b, "Đập vỡ cây đàn");
                    panel1.Controls.Add(l6);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Đập vỡ cây đàn";
                        m.Show();
                    };
                    break;

                case "22":
                    b.BackgroundImage = Properties.Resources._22;
                    Label l7 = new Label();
                    InitName(l7, b, "Duyên phận");
                    panel1.Controls.Add(l7);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Duyên phận";
                        m.Show();
                    };
                    break;

                case "23":
                    b.BackgroundImage = Properties.Resources._23;
                    Label l8 = new Label();
                    InitName(l8, b, "Về đâu máy tóc người thương");
                    panel1.Controls.Add(l8);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Về đâu máy tóc người thương";
                        m.Show();
                    };
                    break;

                case "31":
                    b.BackgroundImage = Properties.Resources._31;
                    Label l9 = new Label();
                    InitName(l9, b, "Đường tôi chở em v");
                    panel1.Controls.Add(l9);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Đường tôi chở em v";
                        m.Show();
                    };
                    break;

                case "32":
                    b.BackgroundImage = Properties.Resources._32;
                    Label l10 = new Label();
                    InitName(l10, b, "See tình");
                    panel1.Controls.Add(l10);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "See tình";
                        m.Show();
                    };
                    break;
                case "33":
                    b.BackgroundImage = Properties.Resources._33;
                    Label l11 = new Label();
                    InitName(l11, b, "Bỏ em vào balo");
                    panel1.Controls.Add(l11);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Bỏ em vào balo";
                        m.Show();
                    };
                    break;
                case "41":
                    b.BackgroundImage = Properties.Resources._41;
                    Label l12 = new Label();
                    InitName(l12, b, "Senorita");
                    panel1.Controls.Add(l12);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Senorita";
                        m.Show();
                    };
                    break;
                case "42":
                    b.BackgroundImage = Properties.Resources._42;
                    Label l13 = new Label();
                    InitName(l13, b, "Shape of you");
                    panel1.Controls.Add(l13);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Shape of you";
                        m.Show();
                    };
                    break;
                case "43":
                    b.BackgroundImage = Properties.Resources._43;
                    Label l14 = new Label();
                    InitName(l14, b, "Shape of you");
                    panel1.Controls.Add(l14);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Shape of you";
                        m.Show();
                    };
                    break;
                case "51":
                    b.BackgroundImage = Properties.Resources._51;
                    Label l15 = new Label();
                    InitName(l15, b, "Pink Venom");
                    panel1.Controls.Add(l15);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Pink Venom";
                        m.Show();
                    };
                    break;
                case "52":
                    b.BackgroundImage = Properties.Resources._42;
                    Label l16 = new Label();
                    InitName(l16, b, "Dynamite");
                    panel1.Controls.Add(l16);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Dynamite";
                        m.Show();
                    };
                    break;
                case "53":
                    b.BackgroundImage = Properties.Resources._42;
                    Label l17 = new Label();
                    InitName(l17, b, "Let's kill this love");
                    panel1.Controls.Add(l17);
                    b.Click += (sender, args) =>
                    {
                        Music m = new Music();
                        m.Text = "Let's kill this love";
                        m.Show();
                    };
                    break;


            }
        }

        private void Favorited_Load(object sender, EventArgs e)
        {
            string[] allfiles = Directory.GetFiles(@"C:\\Users\\LENOVO\\Desktop\\Music player\\Yeuthich", "*.*", SearchOption.AllDirectories);
            Point locate = new Point(50, 50);
            int item = 1;
            foreach (string file in allfiles)
            {
                string name = file.Replace(@"C:\\Users\\LENOVO\\Desktop\\Music player\\Yeuthich\", "");
                name = name.Replace(".mp3", "");
                Button b = new Button();
                InitButton(b, locate, name);
                panel1.Controls.Add(b);
                if (item == 4)
                {
                    item = 1;
                    locate.X = 50;
                    locate.Y += 100 + b.Height;
                }
                else
                {
                    item += 1;
                    locate.X += 50 + b.Width;
                }
            }
        }
    
    }
    
}
