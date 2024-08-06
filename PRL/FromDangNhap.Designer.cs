namespace PRL
{
    partial class FromDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnLogin = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txbUserName = new TextBox();
            lb_dk = new Label();
            label2 = new Label();
            txbPassWord = new TextBox();
            label1 = new Label();
            btn_close = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txbUserName);
            panel1.Controls.Add(lb_dk);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbPassWord);
            panel1.Controls.Add(label1);
            panel1.Cursor = Cursors.Hand;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(85, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 350);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(117, 145, 105);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(108, 261);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(212, 52);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pngtree_black_padlock_png_image_3729324;
            pictureBox3.Location = new Point(65, 195);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.profile_user_icon_isolated_on_white_background_eps10_free_vector;
            pictureBox2.Location = new Point(65, 146);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User_icon_2_svg;
            pictureBox1.Location = new Point(163, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txbUserName
            // 
            txbUserName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbUserName.Location = new Point(108, 146);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(212, 24);
            txbUserName.TabIndex = 7;
            // 
            // lb_dk
            // 
            lb_dk.AutoSize = true;
            lb_dk.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_dk.ForeColor = Color.SteelBlue;
            lb_dk.Location = new Point(233, 316);
            lb_dk.Name = "lb_dk";
            lb_dk.Size = new Size(104, 20);
            lb_dk.TabIndex = 6;
            lb_dk.Text = "Đăng ký ở đây";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(75, 316);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 4;
            label2.Text = "Chưa có tài khoản ?";
            // 
            // txbPassWord
            // 
            txbPassWord.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbPassWord.Location = new Point(108, 195);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(212, 24);
            txbPassWord.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(108, 101);
            label1.Name = "label1";
            label1.Size = new Size(212, 27);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập Tài Khoản";
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.DarkRed;
            btn_close.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.Location = new Point(506, 12);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(56, 29);
            btn_close.TabIndex = 1;
            btn_close.Text = "X";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // FromDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 113, 73);
            ClientSize = new Size(574, 463);
            Controls.Add(btn_close);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FromDangNhap";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_close;
        private Label label1;
        private Label label2;
        private TextBox txbPassWord;
        private TextBox txbUserName;
        private Label lb_dk;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnLogin;
    }
}
