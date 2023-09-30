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
            Check_button = new Button();
            Hotel_Button = new Button();
            Avia_button = new Button();
            Fio_button = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(Check_button);
            panel1.Controls.Add(Hotel_Button);
            panel1.Controls.Add(Avia_button);
            panel1.Controls.Add(Fio_button);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 567);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Check_button
            // 
            Check_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            Check_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            Check_button.Location = new Point(12, 463);
            Check_button.Name = "Check_button";
            Check_button.Size = new Size(813, 92);
            Check_button.TabIndex = 3;
            Check_button.Text = "Итог";
            Check_button.UseVisualStyleBackColor = true;
            Check_button.Click += Check_button_Click;
            // 
            // Hotel_Button
            // 
            Hotel_Button.Location = new Point(561, 0);
            Hotel_Button.Name = "Hotel_Button";
            Hotel_Button.Size = new Size(274, 457);
            Hotel_Button.TabIndex = 2;
            Hotel_Button.Text = "Отель";
            Hotel_Button.UseVisualStyleBackColor = true;
            Hotel_Button.Click += Hotel_Button_Click;
            // 
            // Avia_button
            // 
            Avia_button.Location = new Point(281, 0);
            Avia_button.Name = "Avia_button";
            Avia_button.Size = new Size(274, 457);
            Avia_button.TabIndex = 1;
            Avia_button.Text = "Страна";
            Avia_button.UseVisualStyleBackColor = true;
            Avia_button.Click += Avia_button_Click;
            // 
            // Fio_button
            // 
            Fio_button.Location = new Point(0, 0);
            Fio_button.Name = "Fio_button";
            Fio_button.Size = new Size(275, 457);
            Fio_button.TabIndex = 0;
            Fio_button.Text = "Имя/Фамилия";
            Fio_button.UseVisualStyleBackColor = true;
            Fio_button.Click += Fio_button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 567);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Hotel_Button;
        private Button Avia_button;
        private Button Fio_button;
        private Button Check_button;
    }
}