namespace lab_4_v1._0
{
    partial class DataForm
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
            datapanel = new Panel();
            age_field = new TextBox();
            surname_field = new TextBox();
            name_field = new TextBox();
            age_label = new Label();
            surname_label = new Label();
            name_label = new Label();
            sendData = new Button();
            datapanel.SuspendLayout();
            SuspendLayout();
            // 
            // datapanel
            // 
            datapanel.BackColor = SystemColors.ButtonShadow;
            datapanel.Controls.Add(age_field);
            datapanel.Controls.Add(surname_field);
            datapanel.Controls.Add(name_field);
            datapanel.Controls.Add(age_label);
            datapanel.Controls.Add(surname_label);
            datapanel.Controls.Add(name_label);
            datapanel.Controls.Add(sendData);
            datapanel.Dock = DockStyle.Fill;
            datapanel.Location = new Point(0, 0);
            datapanel.Name = "datapanel";
            datapanel.Size = new Size(514, 450);
            datapanel.TabIndex = 0;
            // 
            // age_field
            // 
            age_field.Location = new Point(125, 271);
            age_field.Name = "age_field";
            age_field.Size = new Size(310, 23);
            age_field.TabIndex = 7;
            // 
            // surname_field
            // 
            surname_field.Location = new Point(125, 164);
            surname_field.Name = "surname_field";
            surname_field.Size = new Size(310, 23);
            surname_field.TabIndex = 6;
            // 
            // name_field
            // 
            name_field.Location = new Point(125, 57);
            name_field.Name = "name_field";
            name_field.Size = new Size(310, 23);
            name_field.TabIndex = 5;
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            age_label.Location = new Point(12, 266);
            age_label.Name = "age_label";
            age_label.Size = new Size(83, 28);
            age_label.TabIndex = 4;
            age_label.Text = "Возраст";
            // 
            // surname_label
            // 
            surname_label.AutoSize = true;
            surname_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            surname_label.Location = new Point(12, 156);
            surname_label.Name = "surname_label";
            surname_label.Size = new Size(96, 28);
            surname_label.TabIndex = 3;
            surname_label.Text = "Фамилия";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            name_label.Location = new Point(12, 49);
            name_label.Name = "name_label";
            name_label.Size = new Size(51, 28);
            name_label.TabIndex = 2;
            name_label.Text = "Имя";
            // 
            // sendData
            // 
            sendData.Location = new Point(212, 380);
            sendData.Name = "sendData";
            sendData.Size = new Size(109, 58);
            sendData.TabIndex = 0;
            sendData.Text = "Отправить";
            sendData.UseVisualStyleBackColor = true;
            sendData.Click += sendData_Click;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 450);
            Controls.Add(datapanel);
            Name = "DataForm";
            Text = "DataForm";
            datapanel.ResumeLayout(false);
            datapanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel datapanel;
        private Button sendData;
        private Label name_label;
        private Label age_label;
        private Label surname_label;
        private TextBox age_field;
        private TextBox surname_field;
        private TextBox name_field;
    }
}