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
            current = orders1;
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

        
        
        //metodo de llamada de UC de ordenes
        public void ordersUC()
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Orders(unUser);
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }
        
        //botones de llamadas a UC
        private void btnOrderAdmin_Click(object sender, EventArgs e)
        {
            ordersUC();
        }

        private void btnOrderUser_Click(object sender, EventArgs e)
        {
            ordersUC();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new ViewUsers(unUser);
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Chart();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Business(unUser);
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Products(unUser);
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new ChangePassword(unUser);
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Address();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }
    }
}