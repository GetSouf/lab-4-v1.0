namespace lab_4_v1._0
{
    partial class AviaForm
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
            send_Country = new Button();
            label1 = new Label();
            country_name_field = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(send_Country);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(country_name_field);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // send_Country
            // 
            send_Country.Location = new Point(307, 377);
            send_Country.Name = "send_Country";
            send_Country.Size = new Size(120, 32);
            send_Country.TabIndex = 2;
            send_Country.Text = "Отравить";
            send_Country.UseVisualStyleBackColor = true;
            send_Country.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(237, 79);
            label1.Name = "label1";
            label1.Size = new Size(299, 37);
            label1.TabIndex = 1;
            label1.Text = "Куда вы хотите лететь?";
            // 
            // country_name_field
            // 
            country_name_field.Location = new Point(207, 190);
            country_name_field.Multiline = true;
            country_name_field.Name = "country_name_field";
            country_name_field.Size = new Size(345, 50);
            country_name_field.TabIndex = 0;
            // 
            // AviaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "AviaForm";
            Text = "AviaForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button send_Country;
        private Label label1;
        private TextBox country_name_field;
    }
}