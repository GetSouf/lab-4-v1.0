﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            DataBank.country = country_name_field.Text;
            if (country_name_field.Text == "")
            {
                MessageBox.Show("Введите страну");
            }
            else
            {
                Hide();
            }

        }
    }
}
