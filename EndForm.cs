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
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void EndForm_Load(object sender, EventArgs e)
        {
            Bye_name.Text = DataBank.name;
            Bye_country.Text = DataBank.country;
            Bye_days.Text = DataBank.days_in_hotel.ToString();
            Bye_flying_price.Text = DataBank.price_of_country.ToString();
            Bye_number_of_rooms.Text = DataBank.number_of_room.ToString();

        }
    }
}
