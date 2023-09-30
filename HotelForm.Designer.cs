namespace lab_4_v1._0
{
    partial class HotelForm
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
            yes_or_no_breakfast = new CheckBox();
            Send_hotel_data_button = new Button();
            days_in_hotel_textbox = new TextBox();
            label1 = new Label();
            need_breakfast_label = new Label();
            How_much_rooms_label = new Label();
            three_room_button = new RadioButton();
            two_room_button = new RadioButton();
            one_room_button = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(yes_or_no_breakfast);
            panel1.Controls.Add(Send_hotel_data_button);
            panel1.Controls.Add(days_in_hotel_textbox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(need_breakfast_label);
            panel1.Controls.Add(How_much_rooms_label);
            panel1.Controls.Add(three_room_button);
            panel1.Controls.Add(two_room_button);
            panel1.Controls.Add(one_room_button);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 387);
            panel1.TabIndex = 0;
            // 
            // yes_or_no_breakfast
            // 
            yes_or_no_breakfast.AutoSize = true;
            yes_or_no_breakfast.Location = new Point(350, 279);
            yes_or_no_breakfast.Name = "yes_or_no_breakfast";
            yes_or_no_breakfast.Size = new Size(15, 14);
            yes_or_no_breakfast.TabIndex = 10;
            yes_or_no_breakfast.UseVisualStyleBackColor = true;
            // 
            // Send_hotel_data_button
            // 
            Send_hotel_data_button.Location = new Point(194, 334);
            Send_hotel_data_button.Name = "Send_hotel_data_button";
            Send_hotel_data_button.Size = new Size(120, 41);
            Send_hotel_data_button.TabIndex = 9;
            Send_hotel_data_button.Text = "Отправить";
            Send_hotel_data_button.UseVisualStyleBackColor = true;
            Send_hotel_data_button.Click += Send_hotel_data_button_Click;
            // 
            // days_in_hotel_textbox
            // 
            days_in_hotel_textbox.Location = new Point(402, 174);
            days_in_hotel_textbox.Name = "days_in_hotel_textbox";
            days_in_hotel_textbox.Size = new Size(64, 23);
            days_in_hotel_textbox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 166);
            label1.Name = "label1";
            label1.Size = new Size(351, 28);
            label1.TabIndex = 7;
            label1.Text = "Сколько дней вы будете проживать?";
            // 
            // need_breakfast_label
            // 
            need_breakfast_label.AutoSize = true;
            need_breakfast_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            need_breakfast_label.Location = new Point(12, 270);
            need_breakfast_label.Name = "need_breakfast_label";
            need_breakfast_label.Size = new Size(241, 28);
            need_breakfast_label.TabIndex = 4;
            need_breakfast_label.Text = "Нужны ли вам завтраки?";
            // 
            // How_much_rooms_label
            // 
            How_much_rooms_label.AutoSize = true;
            How_much_rooms_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            How_much_rooms_label.Location = new Point(12, 66);
            How_much_rooms_label.Name = "How_much_rooms_label";
            How_much_rooms_label.Size = new Size(275, 28);
            How_much_rooms_label.TabIndex = 3;
            How_much_rooms_label.Text = "Сколько вам нужно комнат?";
            // 
            // three_room_button
            // 
            three_room_button.AutoSize = true;
            three_room_button.Location = new Point(439, 75);
            three_room_button.Name = "three_room_button";
            three_room_button.Size = new Size(31, 19);
            three_room_button.TabIndex = 2;
            three_room_button.TabStop = true;
            three_room_button.Text = "3";
            three_room_button.UseVisualStyleBackColor = true;
            three_room_button.Click += three_room_button_Click;
            // 
            // two_room_button
            // 
            two_room_button.AutoSize = true;
            two_room_button.Location = new Point(402, 75);
            two_room_button.Name = "two_room_button";
            two_room_button.Size = new Size(31, 19);
            two_room_button.TabIndex = 1;
            two_room_button.TabStop = true;
            two_room_button.Text = "2";
            two_room_button.UseVisualStyleBackColor = true;
            two_room_button.Click += two_room_button_Click;
            // 
            // one_room_button
            // 
            one_room_button.AutoSize = true;
            one_room_button.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            one_room_button.Location = new Point(362, 75);
            one_room_button.Name = "one_room_button";
            one_room_button.Size = new Size(31, 19);
            one_room_button.TabIndex = 0;
            one_room_button.TabStop = true;
            one_room_button.Text = "1";
            one_room_button.UseVisualStyleBackColor = true;
            one_room_button.Click += one_room_button_Click;
            // 
            // HotelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 387);
            Controls.Add(panel1);
            Name = "HotelForm";
            Text = "HotelForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label How_much_rooms_label;
        private RadioButton three_room_button;
        private RadioButton two_room_button;
        private RadioButton one_room_button;
        private Label need_breakfast_label;
        private TextBox days_in_hotel_textbox;
        private Label label1;
        private RadioButton No_breakfast_button;
        private RadioButton yes_breakfast_button;
        private Button Send_hotel_data_button;
        private CheckBox yes_or_no_breakfast;
    }
}