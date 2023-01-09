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
    public partial class Kpop : Form
    {
        DataTable dt;

        public Kpop()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Image", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Singer", typeof(string));
            dt.Columns.Add("Author", typeof(string));

            // Kpop
            dt.Rows.Add("51", "Kpop", "Pink Venom", "BlackPink", "BlackPink");
            dt.Rows.Add("52", "Kpop", "Dynamite", "BTS", "BTS");
            dt.Rows.Add("53", "Kpop", "Let's kill this love", "BlackPink", "BlackPink");
            dt.Rows.Add("54", "Kpop", "Money", "Lisa", "Lisa");
            dt.Rows.Add("55", "Kpop", "Dance the night away", "Twice", "Twice");
            dt.Rows.Add("56", "Kpop", "Dreamers", "JungCook", "JungCook");
            dt.Rows.Add("57", "Kpop", "Boy With Luv", "BTS", "BTS");
            dt.Rows.Add("58", "Kpop", "Bad Boy", "Red Velvet", "Red Velvet");
            dt.Rows.Add("59", "Kpop", "BBIBBI", "IU", "IU");
            dt.Rows.Add("60", "Kpop", "CheckMate", "Itzy", "Itzy");

        }


        private void InitButton(Button b, Point x, string name)
        {
            b.Location = x;
            b.Size = new Size(150, 150);
            b.BackgroundImageLayout = ImageLayout.Stretch;
            switch (name)
            {
                case "Pink Venom":
                    b.BackgroundImage = Properties.Resources._51;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Dynamite":
                    b.BackgroundImage = Properties.Resources._52;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Let's kill this love":
                    b.BackgroundImage = Properties.Resources._53;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Money":
                    b.BackgroundImage = Properties.Resources._54;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Dance the night away":
                    b.BackgroundImage = Properties.Resources._55;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Dreamers":
                    b.BackgroundImage = Properties.Resources._56;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Boy With Luv":
                    b.BackgroundImage = Properties.Resources._57;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Bad Boy":
                    b.BackgroundImage = Properties.Resources._58;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "BBIBBI":
                    b.BackgroundImage = Properties.Resources._59;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "CheckMate":
                    b.BackgroundImage = Properties.Resources._60;
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
