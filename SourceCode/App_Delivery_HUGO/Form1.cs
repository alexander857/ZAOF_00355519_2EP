using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Delivery_HUGO
{
    public partial class Form1 : Form
    {
        private User unUser;
        private UserControl current;
        public Form1(User u)
        {
            InitializeComponent();
            unUser = u;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //cerrar el programa
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar la sesion?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}