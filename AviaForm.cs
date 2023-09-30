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
    public partial class AviaForm : Form
    {
        public AviaForm()
        {
            InitializeComponent();
        }
        private void AviaForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Я даун";
        }
    }
}
