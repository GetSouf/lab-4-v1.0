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
        }
    }
}
