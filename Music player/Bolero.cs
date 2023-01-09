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
    public partial class Bolero: Form
    {
        DataTable dt;

        public Bolero()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Image", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Singer", typeof(string));
            dt.Columns.Add("Author", typeof(string));

            // Trữ tình
            dt.Rows.Add("21", "Trữ tình", "Đập vỡ cây đàn", "Quang Lê", "Trường Vũ");
            dt.Rows.Add("22", "Trữ tình", "Duyên phận", "Như Quỳnh", "Dương Hồng Loan");
            dt.Rows.Add("23", "Trữ tình", "Về đâu máy tóc người thương", "Hoài Lâm", "Hoài Linh");
            dt.Rows.Add("24", "Trữ tình", "Buồn làm chi em ơi", "Hoài Lâm", " Nguyễn Minh Cường");
            dt.Rows.Add("25", "Trữ tình", "Xin gọi nhau là cố nhân", "Quang Lê", "Song Ngọc");
            dt.Rows.Add("26", "Trữ tình", "Tình bơ vơ", "Chế Linh", "Lam Phương");
            dt.Rows.Add("27", "Trữ tình", "Giấc mơ có thật", "Lệ Quyên", "Tường Văn");
            dt.Rows.Add("28", "Trữ tình", "Gõ cửa trái tim", "Quang Lê", "Vinh Sử");
            dt.Rows.Add("29", "Trữ tình", "Vùng lá me bay"," Như Quỳnh", "Anh Việt Thanh");
            dt.Rows.Add("30", "Trữ tình", "Không giờ rồi", "Như Quỳnh", "Vinh Sử");
            panel1.FillColor = Color.FromArgb(253, 245, 249);

        }


        private void InitButton(Button b, Point x, string name)
        {
            b.Location = x;
            b.Size = new Size(150, 150);
            b.BackgroundImageLayout = ImageLayout.Stretch;
            switch (name)
            {
                case "Đập vỡ cây đàn":
                    b.BackgroundImage = Properties.Resources._21;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Duyên phận":
                    b.BackgroundImage = Properties.Resources._22;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Về đâu máy tóc người thương":
                    b.BackgroundImage = Properties.Resources._23;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Buồn làm chi em ơi":
                    b.BackgroundImage = Properties.Resources._24;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Xin gọi nhau là cố nhân":
                    b.BackgroundImage = Properties.Resources._25;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Tình bơ vơ":
                    b.BackgroundImage = Properties.Resources._26;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Giấc mơ có thật":
                    b.BackgroundImage = Properties.Resources._27;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Gõ cửa trái tim":
                    b.BackgroundImage = Properties.Resources._28;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Vùng lá me bay":
                    b.BackgroundImage = Properties.Resources._29;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Không giờ rồi":
                    b.BackgroundImage = Properties.Resources._30;
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
