using System;
using System.Windows.Forms;

namespace App_Delivery_HUGO
{
    public partial class ChangePassword : UserControl
    {
        private User unUser;
        public ChangePassword(User u)
        {
            InitializeComponent();
            unUser = u;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtPasswordActual.Text.Equals("") || txtNewPassword.Text.Equals("") ||
                txtVerifyPassword.Text.Equals(""))
            {
                MessageBox.Show("No deje espacios vacios!", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else if (txtPasswordActual.Text.Equals(unUser.Password))//se verifica la contra actual del usuario
            {
                if (txtNewPassword.Text.Equals(txtVerifyPassword.Text)) //se verifica la nueva contra 
                {
                    //se actualiza la contra
                    UserDAO.UpdatePassword(unUser.Id, txtVerifyPassword.Text);
                    MessageBox.Show("Contraseña actualizada con exito!");
                    CleanTxTPassword();
                }
                else
                {
                    MessageBox.Show("Su contraseña de verificacion no coincide!", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Su contraseña actual no coincide!", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        public void CleanTxTPassword()
        {
            txtPasswordActual.Text = "";
            txtNewPassword.Text = "";
            txtVerifyPassword.Text = "";
        }
    }
}