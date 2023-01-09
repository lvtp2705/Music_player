using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Music_player
{
    public partial class Form1 : Form
    {
        DataTable dt;
        public Form1()

        {
            InitializeComponent();
            dt = new DataTable();
            //dataGridView1.DataSource = dt;
            dt.Columns.Add("Image", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Singer", typeof(string));
            dt.Columns.Add("Author", typeof(string));
            //thêm column danh gia
            dt.Columns.Add("Rate", typeof(int));// 1 -> 5 cho 5 sao
            // Pop Việt
            dt.Rows.Add("01", "Pop Việt", "Có chắc yêu là đây ", "Sơn Tùng M-TP", "Sơn Tùng M-TP");
            dt.Rows.Add("02", "Pop Việt", "Có chàng trai viết lên cây ", "Phan Mạnh Quỳnh", "Phan Mạnh Quỳnh");
            dt.Rows.Add("03", "Pop Việt", "Em gái mưa ", "Hương Tràm", "Mr.Siro");
            dt.Rows.Add("04", "Pop Việt", "Waiting for you ", "Mono", "Mono");
            dt.Rows.Add("05", "Pop Việt", "3107 ", "DuongxNau", "W/n");
            dt.Rows.Add("06", "Pop Việt", "Tháng năm ", "Soobin Hoàng Sơn", "Soobin Hoàng Sơn");
            dt.Rows.Add("07", "Pop Việt", "See tình ", "Hoàng Thùy Linh", "DTAP");
            dt.Rows.Add("08", "Pop Việt", "Có hẹn với thanh xuân ", "Monstar", "Monstar");
            dt.Rows.Add("09", "Pop Việt", "Tháng tư là lời nói dối của em ", "Hà Anh Tuấn", "Phạm Toàn Thắng");
            dt.Rows.Add("10", "Pop Việt", "Thuận theo ý trời ", "Bùi Anh Tuấn", "Vương Anh Tú");

            // Rap Việt
            dt.Rows.Add("11", "Rap Việt", "Bigcity boy ", "Binz", "Binz x Touliver");
            dt.Rows.Add("12", "Rap Việt", "Đưa nhau đi trốn", "Đen", "Đen");
            dt.Rows.Add("13", "Rap Việt", "Hoa hải đường", "Jack", "Jack");
            dt.Rows.Add("14", "Rap Việt", "Lạc trôi ", "Sơn Tùng M-TP", "Sơn Tùng M-TP");
            dt.Rows.Add("15", "Rap Việt", "Đi về nhà ", "Đen x Justatie", "Đen x Justatie");
            dt.Rows.Add("16", "Rap Việt", "Thiêu thân ", "Bray x Sofia", "Châu Đăng Khoa");
            dt.Rows.Add("17", "Rap Việt", "Có chơi có chịu ", "Karik x OnlyC", "OnlyC");
            dt.Rows.Add("18", "Rap Việt", "Yêu 5 ", "Rhymastic", "Rhymastic");
            dt.Rows.Add("19", "Rap Việt", "Vệ tinh", "Hoàng Tôn x Hieuthuhai", "Hoàng Tôn x Hieuthuhai");
            dt.Rows.Add("20", "Rap Việt", "Chìm sâu ", "MCK x Trung Trần", "MCK x Trung Trần");


            // Trữ tình
            dt.Rows.Add("21", "Trữ tình", "Đập vỡ cây đàn ", "Quang Lê", "Trường Vũ");
            dt.Rows.Add("22", "Trữ tình", "Duyên phận", "Như Quỳnh", "Dương Hồng Loan");
            dt.Rows.Add("23", "Trữ tình", "Về đâu máy tóc người thương", "Hoài Lâm", "Hoài Linh");
            dt.Rows.Add("24", "Trữ tình", "Buồn làm chi em ơi ", "Hoài Lâm", " Nguyễn Minh Cường");
            dt.Rows.Add("25", "Trữ tình", "Xin gọi nhau là cố nhân ", "Quang Lê", "Song Ngọc");
            dt.Rows.Add("26", "Trữ tình", "Tình bơ vơ ", "Chế Linh", "Lam Phương");
            dt.Rows.Add("27", "Trữ tình", "Giấc mơ có thật ", "Lệ Quyên", "Tường Văn");
            dt.Rows.Add("28", "Trữ tình", "Gõ cửa trái tim ", "Quang Lê", "Vinh Sử");
            dt.Rows.Add("29", "Trữ tình", "Vùng lá me bay", " Như Quỳnh", "Anh Việt Thanh");
            dt.Rows.Add("30", "Trữ tình", "Không giờ rồi", "Như Quỳnh", "Vinh Sử");


            // Remix
            dt.Rows.Add("31", "Remix", "Đường tôi chở em về ", "BuiTruongLinh", "BuiTruongLinh x CuCak");
            dt.Rows.Add("32", "Remix", "See tình", "Rin9", "Hàng Thùy Linh x Cucak");
            dt.Rows.Add("33", "Remix", "Bỏ em vào balo", "Tân Trần", "Orinn");
            dt.Rows.Add("34", "Remix", "Vina Rap ", "Xteam", "Xteam");
            dt.Rows.Add("35", "Remix", "Kém duyên ", "Rum x Nit", "Masew");
            dt.Rows.Add("36", "Remix", "Anh đã lạc vào ", "Green", "Green x Orinn");
            dt.Rows.Add("37", "Remix", "Hương ", "Hứa Kim Tuyền", "Văn Mai Hương x Cucak");
            dt.Rows.Add("38", "Remix", "Tay To ", "RPT MCK x RPT PhongKhin", "RPT MCK x RPT PhongKhin");
            dt.Rows.Add("39", "Remix", "Kẹo bông gòn", "H2K", "H2k x Uni");
            dt.Rows.Add("40", "Remix", "Chỉ muốn bên em thật gần ", "Yling", "Yling");


            // US&UK
            dt.Rows.Add("41", "US&UK", "Senorita ", "Camilo Cabelo x Shawn Mendes", "Camilo Cabelo x Shawn Mendes");
            dt.Rows.Add("42", "US&UK", "Shape of you", "Ed Sheeran", "Ed Sheeran");
            dt.Rows.Add("43", "US&UK", "Head in the clouds", "Hayd", "Hayd");
            dt.Rows.Add("44", "US&UK", "Love your self ", "Justin Bieber", "Justin Bieber");
            dt.Rows.Add("45", "US&UK", "2002 ", "Anne-Marie", "Anne-Marie");
            dt.Rows.Add("46", "US&UK", "Sugar ", "Maroon 5", "Maroon 5");
            dt.Rows.Add("47", "US&UK", "At the worst ", "Pink Sweat$", "Pink Sweat$");
            dt.Rows.Add("48", "US&UK", "Attention", "Charlie Puth", "Charlie Puth");
            dt.Rows.Add("49", "US&UK", "Unstoppable", "Sia", "Sia");
            dt.Rows.Add("50", "US&UK", "Look what you made me do ", "Taylor Swift", "Taylor Swift");


            // Kpop
            dt.Rows.Add("51", "Kpop", "Pink Venom ", "BlackPink", "BlackPink");
            dt.Rows.Add("52", "Kpop", "Dynamite", "BTS", "BTS");
            dt.Rows.Add("53", "Kpop", "Let's kill this love", "BlackPink", "BlackPink");
            dt.Rows.Add("54", "Kpop", "Money ", "Lisa", "Lisa");
            dt.Rows.Add("55", "Kpop", "Dance the night away ", "Twice", "Twice");
            dt.Rows.Add("56", "Kpop", "Dreamers ", "JungCook", "JungCook");
            dt.Rows.Add("57", "Kpop", " Boy With Luv", "BTS", "BTS");
            dt.Rows.Add("58", "Kpop", "Bad Boy ", "Red Velvet", "Red Velvet");
            dt.Rows.Add("59", "Kpop", "BBIBBI", "IU", "IU");
            dt.Rows.Add("60", "Kpop", "CheckMate ", "Itzy", "Itzy");

            listcollection.Clear();
            foreach (string str in listBox1.Items)
            {
                listcollection.Add(str);
                guna2TextBox1.CharacterCasing = CharacterCasing.Normal;
            }
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            guna2Panel1.BackColor = Color.FromArgb(253, 245, 249);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button2.FillColor = Color.FromArgb(253, 245, 249);

            PopViet music = new PopViet();
            music.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            guna2Button2.FillColor = Color.FromArgb(253, 245, 249);

            USUK music = new USUK();
            music.Show();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            guna2Button2.FillColor = Color.FromArgb(253, 245, 249);

            Kpop music = new Kpop();
            music.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Button2.FillColor = Color.FromArgb(253, 245, 249);

            Rapviet music = new Rapviet();
            music.Show();
        }


        Color farbe;
        string ph = "Nhập bài hát, ca sĩ, nhạc sĩ cần tìm vào đây";

        public void RemoveText(object sender, EventArgs e)
        {
            guna2TextBox1.ForeColor = Color.Black;
            if (guna2TextBox1.Text == ph)
                guna2TextBox1.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                guna2TextBox1.ForeColor = Color.DarkGray;
                guna2TextBox1.Text = ph;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<string> listcollection = new List<string>();


        private void Form1_Load(object sender, EventArgs e)
        {
            farbe = guna2TextBox1.ForeColor;
            guna2TextBox1.GotFocus += RemoveText;
            guna2TextBox1.LostFocus += AddText;
            guna2TextBox1.Text = ph;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
            {
                guna2Button2.FillColor = Color.FromArgb(253, 245, 249);

                Bolero music = new Bolero();
                music.Show();

            }

            private void guna2Button5_Click(object sender, EventArgs e)
            {
                guna2Button2.FillColor = Color.FromArgb(253, 245, 249);

                Remix music = new Remix();
                music.Show();
            }

            private void guna2Panel2_Paint(object sender, PaintEventArgs e)
            {

            }

            private void guna2Button3_Click(object sender, EventArgs e)
            {
                Favorited music = new Favorited();
                music.Show();
            }

            private void guna2Button10_Click(object sender, EventArgs e)
            {
                Playlist music = new Playlist();
                music.Show();
            }
           

            private void guna2TextBox1_MouseClick(object sender, MouseEventArgs e)
            {
               listBox1.Visible = true;
            }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Music m = new Music();
            if (listBox1.SelectedItem != null)
            {
                switch (listBox1.SelectedItem)
                {
                    case "Có chắc yêu là đây":

                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();
                        break;

                    case "Có chàng trai viết lên cây":

                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();
                        break;

                    case "Em gái mưa":

                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();
                        break;

                    case "Bigcity boy":
                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;

                    case "Đưa nhau đi trốn":
                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;

                    case "Hoa hải đường":
                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;

                    case "Đập vỡ cây đàn":
                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;

                    case "Duyên phận":
                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;

                    case "Về đâu máy tóc người thương":
                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;

                    case "Đường tôi chở em về":
                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;
                    case "See tình":
                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;
                    case "Bỏ em vào balo":
                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;
                    case "Senorita":


                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;
                    case "Shape of you":


                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;
                    case "Head in the clouds":


                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;
                    case "Pink Venom":


                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;
                    case "Dynamite":


                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;
                    case "Let's kill this love":


                        m.Text = listBox1.SelectedItem.ToString();
                        m.Show();

                        break;

                }
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox1.Text) == false)
            {
                listBox1.Items.Clear();
                foreach (string str in listcollection)
                {
                    if (str.StartsWith(guna2TextBox1.Text))
                    {
                        listBox1.Items.Add(str);
                    }
                }
            }
            else if (guna2TextBox1.Text == "")
            {
                listBox1.Items.Clear();
                foreach (string str in listcollection)
                {
                    listBox1.Items.Add(str);
                }
            }
        }
    }
    }
