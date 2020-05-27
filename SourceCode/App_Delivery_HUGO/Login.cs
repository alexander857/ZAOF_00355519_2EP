using System;
using System.Windows.Forms;

namespace App_Delivery_HUGO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //se llena el combo box de usuarios
        public void FillComboBoxUser()
        {
            cmbUsers.DataSource = null;
            cmbUsers.ValueMember = "password";
            cmbUsers.DisplayMember = "username";
            cmbUsers.DataSource = UserDAO.getListaUsers();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            FillComboBoxUser();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedValue.Equals(txtPassword.Text))
            {
                User u = (User) cmbUsers.SelectedItem;
                
                Form1 f = new Form1(u);
                f.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta!", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }
        
      
    }  
}