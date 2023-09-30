namespace lab_4_v1._0
{
    partial class MainForm
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
            panel1 = new Panel();
            main_form_age = new Label();
            main_form_surname = new Label();
            main_form_name = new Label();
            Hotel_Button = new Button();
            Avia_button = new Button();
            Fio_button = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(main_form_age);
            panel1.Controls.Add(main_form_surname);
            panel1.Controls.Add(main_form_name);
            panel1.Controls.Add(Hotel_Button);
            panel1.Controls.Add(Avia_button);
            panel1.Controls.Add(Fio_button);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 567);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // main_form_age
            // 
            main_form_age.AutoSize = true;
            main_form_age.Location = new Point(70, 154);
            main_form_age.Name = "main_form_age";
            main_form_age.Size = new Size(13, 15);
            main_form_age.TabIndex = 5;
            main_form_age.Text = "3";
            // 
            // main_form_surname
            // 
            main_form_surname.AutoSize = true;
            main_form_surname.Location = new Point(67, 101);
            main_form_surname.Name = "main_form_surname";
            main_form_surname.Size = new Size(13, 15);
            main_form_surname.TabIndex = 4;
            main_form_surname.Text = "2";
            // 
            // main_form_name
            // 
            main_form_name.AutoSize = true;
            main_form_name.Location = new Point(74, 52);
            main_form_name.Name = "main_form_name";
            main_form_name.Size = new Size(13, 15);
            main_form_name.TabIndex = 3;
            main_form_name.Text = "1";
            // 
            // Hotel_Button
            // 
            Hotel_Button.Location = new Point(603, 468);
            Hotel_Button.Name = "Hotel_Button";
            Hotel_Button.Size = new Size(164, 72);
            Hotel_Button.TabIndex = 2;
            Hotel_Button.Text = "Отель";
            Hotel_Button.UseVisualStyleBackColor = true;
            // 
            // Avia_button
            // 
            Avia_button.Location = new Point(317, 418);
            Avia_button.Name = "Avia_button";
            Avia_button.Size = new Size(164, 72);
            Avia_button.TabIndex = 1;
            Avia_button.Text = "Страна";
            Avia_button.UseVisualStyleBackColor = true;
            Avia_button.Click += Avia_button_Click;
            // 
            // Fio_button
            // 
            Fio_button.Location = new Point(46, 468);
            Fio_button.Name = "Fio_button";
            Fio_button.Size = new Size(164, 72);
            Fio_button.TabIndex = 0;
            Fio_button.Text = "Имя/Фамилия";
            Fio_button.UseVisualStyleBackColor = true;
            Fio_button.Click += Fio_button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Hotel_Button;
        private Button Avia_button;
        private Button Fio_button;
        private Label main_form_name;
        private Label main_form_surname;
        private Label main_form_age;
    }
}