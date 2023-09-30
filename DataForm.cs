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
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void sendData_Click(object sender, EventArgs e)
        {
            DataBank.name = name_field.Text;
            DataBank.surname = surname_field.Text;
            DataBank.age = age_field.Text;
            if (name_field.Text == "")
            {
                MessageBox.Show("Вы не ввели имя");
            }
            if (surname_field.Text == "")
            {
                MessageBox.Show("Вы не ввели фамилию");
            }
            if (age_field.Text == "")
            {
                MessageBox.Show("Вы не ввели возраст");
            }
            if (Int32.Parse(age_field.Text) < 18)
            {
                MessageBox.Show("Услуги нашей компании доступны только лицам старше 18 лет.");
            }
            else
            {
                Hide();
            }
        }
    }
}
