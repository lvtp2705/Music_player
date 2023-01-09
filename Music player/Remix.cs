using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;


namespace Music_player
{
    public partial class Remix : Form
    {
        DataTable dt;

        public Remix()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Image", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Singer", typeof(string));
            dt.Columns.Add("Author", typeof(string));

            // Remix
            dt.Rows.Add("31", "Remix", "Đường tôi chở em về", "BuiTruongLinh", "BuiTruongLinh x CuCak");
            dt.Rows.Add("32", "Remix", "See tình", "Rin9", "Hàng Thùy Linh x Cucak");
            dt.Rows.Add("33", "Remix", "Bỏ em vào balo", "Tân Trần", "Orinn");
            dt.Rows.Add("34", "Remix", "Vina Rap", "Xteam", "Xteam");
            dt.Rows.Add("35", "Remix", "Kém duyên", "Rum x Nit", "Masew");
            dt.Rows.Add("36", "Remix", "Anh đã lạc vào", "Green", "Green x Orinn");
            dt.Rows.Add("37", "Remix", "Hương", "Hứa Kim Tuyền", "Văn Mai Hương x Cucak");
            dt.Rows.Add("38", "Remix", "Tay To", "RPT MCK x RPT PhongKhin", "RPT MCK x RPT PhongKhin");
            dt.Rows.Add("39", "Remix", "Kẹo bông gòn", "H2K", "H2k x Uni");
            dt.Rows.Add("40", "Remix", "Chỉ muốn bên em thật gần", "Yling", "Yling");

        }


        private void InitButton(Button b, Point x, string name)
        {
            b.Location = x;
            b.Size = new Size(150, 150);
            b.BackgroundImageLayout = ImageLayout.Stretch;
            switch (name)
            {
                case "Đường tôi chở em về":
                    b.BackgroundImage = Properties.Resources._31;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "See tình":
                    b.BackgroundImage = Properties.Resources._32;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Bỏ em vào balo":
                    b.BackgroundImage = Properties.Resources._33;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Vina Rap":
                    b.BackgroundImage = Properties.Resources._34;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Kém duyên":
                    b.BackgroundImage = Properties.Resources._35;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Anh đã lạc vào":
                    b.BackgroundImage = Properties.Resources._36;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Hương":
                    b.BackgroundImage = Properties.Resources._37;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Tay To":
                    b.BackgroundImage = Properties.Resources._38;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Kẹo bông gòn":
                    b.BackgroundImage = Properties.Resources._39;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Chỉ muốn bên em thật gần":
                    b.BackgroundImage = Properties.Resources._40;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;


            }
        }
    
        private void PopViet_Load(object sender, EventArgs e)
        {
            
            Point locate = new Point(65, 50);
            int item = 1;
            foreach (DataRow r in dt.Rows)
            {
                Button b = new Button();
                Label name = new Label();
                Label singer = new Label();
                InitButton(b, locate, r.Field<string>("Name"));
                InitName(name, b, r.Field<string>("Name"));
                InitSinger(singer, b, r.Field<string>("Singer"));

                panel1.Controls.Add(b);
                panel1.Controls.Add(name);
                panel1.Controls.Add(singer);
                if (item == 3)
                {
                    item = 1;
                    locate.X = 65;
                    locate.Y += 100 + b.Height;
                }
                else
                {
                    item += 1;
                    locate.X += 65 + b.Width;
                }
            }
    }
        private void InitName(Label content, Button b, string name)
        {
            content.Location = new Point(b.Location.X, b.Location.Y + b.Height + 10);
            content.AutoSize = false;
            content.Width = b.Width;
            content.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9, FontStyle.Bold);
            content.ForeColor = Color.Black;
            content.BackColor = Color.Transparent;
            content.TextAlign = ContentAlignment.MiddleCenter;
            content.Text = name;
        }

        private void InitSinger(Label l, Button b, string price)
        {
            l.Location = new Point(b.Location.X, b.Location.Y + b.Height + 30);
            l.AutoSize = false;
            l.Width = b.Width;
            l.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9, FontStyle.Bold);
            l.ForeColor = Color.DarkGray;
            l.BackColor = Color.Transparent;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Text = price;
        }
    }
}
