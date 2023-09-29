using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4_v1._0
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
            this.password_field.AutoSize = false;
            this.password_field.Size = new Size(this.password_field.Size.Width, 60);
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_button_MouseEnter(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.Red;
        }

        private void close_button_MouseLeave(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.White;
        }
        Point lastpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void login_button_Click(object sender, EventArgs e)
        {

        }
    }
}
