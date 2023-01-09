
namespace Music_player
{
    partial class Music
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.music_pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.comment_pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.song_label = new System.Windows.Forms.Label();
            this.comment_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.singer_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.composer_label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.download_button = new Guna.UI2.WinForms.Guna2Button();
            this.like_button = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comment_button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.star5 = new System.Windows.Forms.Button();
            this.star4 = new System.Windows.Forms.Button();
            this.star3 = new System.Windows.Forms.Button();
            this.star2 = new System.Windows.Forms.Button();
            this.star1 = new System.Windows.Forms.Button();
            this.rating_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rating_pic = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.music_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comment_pic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rating_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // music_pic
            // 
            this.music_pic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.music_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.music_pic.ImageRotate = 0F;
            this.music_pic.Location = new System.Drawing.Point(55, 119);
            this.music_pic.Name = "music_pic";
            this.music_pic.Size = new System.Drawing.Size(154, 134);
            this.music_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.music_pic.TabIndex = 1;
            this.music_pic.TabStop = false;
            this.music_pic.Click += new System.EventHandler(this.music_pic_Click);
            // 
            // comment_pic
            // 
            this.comment_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.comment_pic.ImageRotate = 0F;
            this.comment_pic.Location = new System.Drawing.Point(49, 137);
            this.comment_pic.Name = "comment_pic";
            this.comment_pic.Size = new System.Drawing.Size(185, 169);
            this.comment_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comment_pic.TabIndex = 2;
            this.comment_pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 478);
            this.label1.TabIndex = 4;
            this.label1.Text = "label";
            // 
            // song_label
            // 
            this.song_label.AutoSize = true;
            this.song_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.song_label.ForeColor = System.Drawing.Color.DeepPink;
            this.song_label.Location = new System.Drawing.Point(115, 270);
            this.song_label.Name = "song_label";
            this.song_label.Size = new System.Drawing.Size(37, 16);
            this.song_label.TabIndex = 5;
            this.song_label.Text = "label";
            // 
            // comment_name
            // 
            this.comment_name.BackColor = System.Drawing.Color.Transparent;
            this.comment_name.Location = new System.Drawing.Point(89, 312);
            this.comment_name.Name = "comment_name";
            this.comment_name.Size = new System.Drawing.Size(108, 18);
            this.comment_name.TabIndex = 6;
            this.comment_name.Text = "guna2HtmlLabel1";
            // 
            // singer_label
            // 
            this.singer_label.BackColor = System.Drawing.Color.Transparent;
            this.singer_label.ForeColor = System.Drawing.Color.DeepPink;
            this.singer_label.Location = new System.Drawing.Point(118, 335);
            this.singer_label.Name = "singer_label";
            this.singer_label.Size = new System.Drawing.Size(108, 18);
            this.singer_label.TabIndex = 8;
            this.singer_label.Text = "guna2HtmlLabel3";
            // 
            // composer_label1
            // 
            this.composer_label1.BackColor = System.Drawing.Color.Transparent;
            this.composer_label1.ForeColor = System.Drawing.Color.DeepPink;
            this.composer_label1.Location = new System.Drawing.Point(118, 301);
            this.composer_label1.Name = "composer_label1";
            this.composer_label1.Size = new System.Drawing.Size(108, 18);
            this.composer_label1.TabIndex = 9;
            this.composer_label1.Text = "composer_label1";
            // 
            // download_button
            // 
            this.download_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.download_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.download_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.download_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.download_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.download_button.ForeColor = System.Drawing.Color.White;
            this.download_button.Image = global::Music_player.Properties.Resources.download;
            this.download_button.Location = new System.Drawing.Point(1124, 82);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(63, 45);
            this.download_button.TabIndex = 10;
            this.download_button.Click += new System.EventHandler(this.download_button_Click);
            // 
            // like_button
            // 
            this.like_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.like_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.like_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.like_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.like_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.like_button.ForeColor = System.Drawing.Color.White;
            this.like_button.Image = global::Music_player.Properties.Resources.heart;
            this.like_button.Location = new System.Drawing.Point(1055, 82);
            this.like_button.Name = "like_button";
            this.like_button.Size = new System.Drawing.Size(63, 45);
            this.like_button.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(46, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 158);
            this.panel1.TabIndex = 12;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(34, 9);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1098, 124);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Song :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tác giả :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ca sĩ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.comment_pic);
            this.panel2.Controls.Add(this.comment_name);
            this.panel2.Location = new System.Drawing.Point(253, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 450);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Comment";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Music_player.Properties.Resources.exit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(581, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 42);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(303, 242);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 191);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 188);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // comment_button
            // 
            this.comment_button.BackColor = System.Drawing.Color.Transparent;
            this.comment_button.BackgroundImage = global::Music_player.Properties.Resources.bubble_chat;
            this.comment_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.comment_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.comment_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.comment_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.comment_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.comment_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comment_button.ForeColor = System.Drawing.Color.White;
            this.comment_button.Image = global::Music_player.Properties.Resources.bubble_chat;
            this.comment_button.Location = new System.Drawing.Point(917, 82);
            this.comment_button.Name = "comment_button";
            this.comment_button.Size = new System.Drawing.Size(63, 45);
            this.comment_button.TabIndex = 17;
            this.comment_button.Click += new System.EventHandler(this.comment_button_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::Music_player.Properties.Resources.rate;
            this.guna2Button2.Location = new System.Drawing.Point(986, 82);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(63, 45);
            this.guna2Button2.TabIndex = 18;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.star5);
            this.panel3.Controls.Add(this.star4);
            this.panel3.Controls.Add(this.star3);
            this.panel3.Controls.Add(this.star2);
            this.panel3.Controls.Add(this.star1);
            this.panel3.Location = new System.Drawing.Point(232, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 280);
            this.panel3.TabIndex = 9;
            this.panel3.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Music_player.Properties.Resources.exit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(524, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 42);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đánh giá";
            // 
            // star5
            // 
            this.star5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.star5.Location = new System.Drawing.Point(484, 173);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(75, 72);
            this.star5.TabIndex = 4;
            this.star5.UseVisualStyleBackColor = true;
            this.star5.Click += new System.EventHandler(this.star5_Click_1);
            // 
            // star4
            // 
            this.star4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.star4.Location = new System.Drawing.Point(370, 173);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(75, 72);
            this.star4.TabIndex = 3;
            this.star4.UseVisualStyleBackColor = true;
            this.star4.Click += new System.EventHandler(this.star4_Click_1);
            // 
            // star3
            // 
            this.star3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.star3.Location = new System.Drawing.Point(252, 173);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(75, 72);
            this.star3.TabIndex = 2;
            this.star3.UseVisualStyleBackColor = true;
            this.star3.Click += new System.EventHandler(this.star3_Click_1);
            // 
            // star2
            // 
            this.star2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.star2.Location = new System.Drawing.Point(139, 173);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(75, 72);
            this.star2.TabIndex = 1;
            this.star2.UseVisualStyleBackColor = true;
            this.star2.Click += new System.EventHandler(this.star2_Click_1);
            // 
            // star1
            // 
            this.star1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.star1.Location = new System.Drawing.Point(31, 173);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(70, 72);
            this.star1.TabIndex = 0;
            this.star1.UseVisualStyleBackColor = true;
            this.star1.Click += new System.EventHandler(this.star1_Click_1);
            // 
            // rating_name
            // 
            this.rating_name.BackColor = System.Drawing.Color.Transparent;
            this.rating_name.Location = new System.Drawing.Point(972, 380);
            this.rating_name.Name = "rating_name";
            this.rating_name.Size = new System.Drawing.Size(77, 18);
            this.rating_name.TabIndex = 7;
            this.rating_name.Text = "rating_name";
            this.rating_name.Visible = false;
            // 
            // rating_pic
            // 
            this.rating_pic.ImageRotate = 0F;
            this.rating_pic.Location = new System.Drawing.Point(1023, 184);
            this.rating_pic.Name = "rating_pic";
            this.rating_pic.Size = new System.Drawing.Size(59, 53);
            this.rating_pic.TabIndex = 3;
            this.rating_pic.TabStop = false;
            this.rating_pic.Visible = false;
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 735);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.comment_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.music_pic);
            this.Controls.Add(this.singer_label);
            this.Controls.Add(this.composer_label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.like_button);
            this.Controls.Add(this.song_label);
            this.Controls.Add(this.download_button);
            this.Controls.Add(this.rating_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rating_pic);
            this.Name = "Music";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Music_Load);
            ((System.ComponentModel.ISupportInitialize)(this.music_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comment_pic)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rating_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Guna.UI2.WinForms.Guna2PictureBox music_pic;
        private Guna.UI2.WinForms.Guna2PictureBox comment_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label song_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel comment_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel singer_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel composer_label1;
        private Guna.UI2.WinForms.Guna2Button download_button;
        private Guna.UI2.WinForms.Guna2Button like_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button comment_button;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button star5;
        private System.Windows.Forms.Button star4;
        private System.Windows.Forms.Button star3;
        private System.Windows.Forms.Button star2;
        private System.Windows.Forms.Button star1;
        private Guna.UI2.WinForms.Guna2HtmlLabel rating_name;
        private Guna.UI2.WinForms.Guna2PictureBox rating_pic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}