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
    public partial class MainForm : Form
    {
        DataForm dataForm;
        AviaForm aviaForm;
        HotelForm hotelForm;
        EndForm endForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Fio_button_Click(object sender, EventArgs e)
        {
            dataForm = new DataForm();
            dataForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Avia_button_Click(object sender, EventArgs e)
        {
            aviaForm = new AviaForm();
            aviaForm.Show();
        }

        private void Hotel_Button_Click(object sender, EventArgs e)
        {
            hotelForm = new HotelForm();
            hotelForm.Show();
        }

        private void Check_button_Click(object sender, EventArgs e)
        {
            endForm = new EndForm();
            endForm.Show();
        }
    }
}
