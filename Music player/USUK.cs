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
    public partial class USUK : Form
    {
        DataTable dt;

        public USUK()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Image", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Singer", typeof(string));
            dt.Columns.Add("Author", typeof(string));

            // US&UK
            dt.Rows.Add("41", "US&UK", "Senorita", "Camilo Cabelo x Shawn Mendes", "Camilo Cabelo x Shawn Mendes");
            dt.Rows.Add("42", "US&UK", "Shape of you", "Ed Sheeran", "Ed Sheeran");
            dt.Rows.Add("43", "US&UK", "Head in the clouds", "Hayd", "Hayd");
            dt.Rows.Add("44", "US&UK", "Love your self", "Justin Bieber", "Justin Bieber");
            dt.Rows.Add("45", "US&UK", "2002", "Anne-Marie", "Anne-Marie");
            dt.Rows.Add("46", "US&UK", "Sugar", "Maroon 5", "Maroon 5");
            dt.Rows.Add("47", "US&UK", "At the worst", "Pink Sweat$", "Pink Sweat$");
            dt.Rows.Add("48", "US&UK", "Attention", "Charlie Puth", "Charlie Puth");
            dt.Rows.Add("49", "US&UK", "Unstoppable", "Sia", "Sia");
            dt.Rows.Add("50", "US&UK", "Look what you made me do", "Taylor Swift", "Taylor Swift");
            panel1.FillColor = Color.FromArgb(253, 245, 249);

        }


        private void InitButton(Button b, Point x, string name)
        {
            b.Location = x;
            b.Size = new Size(150, 150);
            b.BackgroundImageLayout = ImageLayout.Stretch;
            switch (name)
            {
                case "Senorita":
                    b.BackgroundImage = Properties.Resources._41;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Shape of you":
                    b.BackgroundImage = Properties.Resources._42;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Head in the clouds":
                    b.BackgroundImage = Properties.Resources._43;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Love your self":
                    b.BackgroundImage = Properties.Resources._44;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "2002":
                    b.BackgroundImage = Properties.Resources._45;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Sugar":
                    b.BackgroundImage = Properties.Resources._46;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "At the worst":
                    b.BackgroundImage = Properties.Resources._47;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Attention":
                    b.BackgroundImage = Properties.Resources._48;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Unstoppable":
                    b.BackgroundImage = Properties.Resources._49;
                    b.Click += (sender, args) =>
                    {
                        File.AppendAllText(@"C:\\Users\\LENOVO\\Desktop\\CS511\\Bài_3\History.txt", DateTime.Now.ToString() + "    " + name + Environment.NewLine);
                        Music m = new Music();
                        m.Text = name;
                        m.Show();
                    };
                    break;

                case "Look what you made me do":
                    b.BackgroundImage = Properties.Resources._50;
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
