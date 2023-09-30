using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4_v1._0
{
    public partial class HotelForm : Form
    {
        public HotelForm()
        {
            InitializeComponent();
        }

        private void one_room_button_Click(object sender, EventArgs e)
        {
            DataBank.number_of_room = 1;
        }

        private void two_room_button_Click(object sender, EventArgs e)
        {
            DataBank.number_of_room = 2;
        }

        private void three_room_button_Click(object sender, EventArgs e)
        {
            DataBank.number_of_room = 3;
        }

        private void Send_hotel_data_button_Click(object sender, EventArgs e)
        {
            DataBank.days_in_hotel = Int32.Parse(days_in_hotel_textbox.Text);
            DataBank.yes_no_breakfast = yes_or_no_breakfast.AutoCheck;
            if (days_in_hotel_textbox.Text == "")
            {
                MessageBox.Show("Вы не ввели дни.");
            }
            else
            {
                Hide();
            }
        }

        private void yes_breakfast_button_Click(object sender, EventArgs e)
        {
            DataBank.yes_no_breakfast = true;
        }

        private void No_breakfast_button_Click(object sender, EventArgs e)
        {
            DataBank.yes_no_breakfast = false;
        }


    }
}
