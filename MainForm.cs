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
            main_form_name.Text = DataBank.name;
            main_form_surname.Text = DataBank.surname;
            main_form_age.Text = DataBank.age;
        }

        private void Avia_button_Click(object sender, EventArgs e)
        {

        }
    }
}
