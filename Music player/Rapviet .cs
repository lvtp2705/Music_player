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
    public partial class Rapviet: Form
    {
        DataTable dt;

        public Rapviet()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Image", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Singer", typeof(string));
            dt.Columns.Add("Author", typeof(string));

            // Rap Việt
            dt.Rows.Add("11", "Rap Việt", "Bigcity boy", "Binz", "Binz x Touliver");
            dt.Rows.Add("12", "Rap Việt", "Đưa nhau đi trốn", "Đen", "Đen");
            dt.Rows.Add("13", "Rap Việt", "Hoa hải đường", "Jack", "Jack");
            dt.Rows.Add("14", "Rap Việt", "Lạc trôi", "Sơn Tùng M-TP", "Sơn Tùng M-TP");
            dt.Rows.Add("15", "Rap Việt", "Đi về nhà", "Đen x Justatie", "Đen x Justatie");
            dt.Rows.Add("16", "Rap Việt", "Thiêu thân", "Bray x Sofia", "Châu Đăng Khoa");
            dt.Rows.Add("17", "Rap Việt", "Có chơi có chịu", "Karik x OnlyC", "OnlyC");
            dt.Rows.Add("18", "Rap Việt", "Yêu 5", "Rhymastic", "Rhymastic");
            dt.Rows.Add("19", "Rap Việt", "Vệ tinh", "Hoàng Tôn x Hieuthuhai", "Hoàng Tôn x Hieuthuhai");
            dt.Rows.Add("20", "Rap Việt", "Chìm sâu", "MCK x Trung Trần", "MCK x Trung Trần");


        }


        private void InitButton(Button b, Point x, string name)
        {
            b.Location = x;
            b.Size = new Size(150, 150);
            b.BackgroundImageLayout = ImageLayout.Stretch;
            switch (name)
            {
                case "Bigcity boy":
                    b.BackgroundImage = Properties.Resources._11;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Đưa nhau đi trốn":
                    b.BackgroundImage = Properties.Resources._12;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Hoa hải đường":
                    b.BackgroundImage = Properties.Resources._13;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Lạc trôi":
                    b.BackgroundImage = Properties.Resources._14;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Đi về nhà":
                    b.BackgroundImage = Properties.Resources._15;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Thiêu thân":
                    b.BackgroundImage = Properties.Resources._16;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Có chơi có chịu":
                    b.BackgroundImage = Properties.Resources._17;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Yêu 5":
                    b.BackgroundImage = Properties.Resources._18;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Vệ tinh":
                    b.BackgroundImage = Properties.Resources._19;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Chìm sâu":
                    b.BackgroundImage = Properties.Resources._20;
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
