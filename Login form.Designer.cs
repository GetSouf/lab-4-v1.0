namespace lab_4_v1._0
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            panel1 = new Panel();
            login_button = new Button();
            password_field = new TextBox();
            pictureBox2 = new PictureBox();
            login_field = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            close_button = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(login_button);
            panel1.Controls.Add(password_field);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(login_field);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 541);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // login_button
            // 
            login_button.BackColor = Color.LightSlateGray;
            login_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            login_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            login_button.Location = new Point(328, 448);
            login_button.Name = "login_button";
            login_button.Size = new Size(201, 64);
            login_button.TabIndex = 5;
            login_button.Text = "Вход";
            login_button.TextImageRelation = TextImageRelation.ImageAboveText;
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // password_field
            // 
            password_field.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            password_field.Location = new Point(267, 359);
            password_field.Name = "password_field";
            password_field.Size = new Size(341, 43);
            password_field.TabIndex = 4;
            password_field.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 323);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // login_field
            // 
            login_field.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            login_field.Location = new Point(267, 191);
            login_field.Multiline = true;
            login_field.Name = "login_field";
            login_field.Size = new Size(341, 60);
            login_field.TabIndex = 2;
            login_field.Text = "OMO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(44, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 192);
            panel2.Controls.Add(close_button);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 109);
            panel2.TabIndex = 0;
            // 
            // close_button
            // 
            close_button.AutoSize = true;
            close_button.BackColor = Color.DimGray;
            close_button.Cursor = Cursors.Hand;
            close_button.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            close_button.ForeColor = SystemColors.ButtonHighlight;
            close_button.Location = new Point(764, 9);
            close_button.Name = "close_button";
            close_button.Size = new Size(21, 40);
            close_button.TabIndex = 1;
            close_button.Text = "x";
            close_button.TextAlign = ContentAlignment.TopRight;
            close_button.UseCompatibleTextRendering = true;
            close_button.Click += close_button_Click;
            close_button.MouseEnter += close_button_MouseEnter;
            close_button.MouseLeave += close_button_MouseLeave;
            // 
            // label1
            // 
            label1.BackColor = Color.DimGray;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe Print", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(801, 109);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 541);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_form";
            Text = "Login_form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label close_button;
        private PictureBox pictureBox1;
        private TextBox password_field;
        private PictureBox pictureBox2;
        private TextBox login_field;
        private Button login_button;
    }
}