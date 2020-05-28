using System;
using System.Windows.Forms;

namespace App_Delivery_HUGO
{
    public partial class ViewUsers : UserControl
    {
        private User unUser;
        public ViewUsers(User u)
        {
            InitializeComponent();
            unUser = u;
        }
        
        //llenar datagrid
        public void UpdateDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = UserDAO.getListaUsers();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
            FillComboBoxUsers();
        }

        //actualiza el combobox de usuarios
        public void FillComboBoxUsers()
        {
            cmbUserDelete.DataSource = null;
            cmbUserDelete.ValueMember = "id";
            cmbUserDelete.DisplayMember = "username";
            cmbUserDelete.DataSource = UserDAO.getListaUsers();
        }
        
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Equals("") || txtUsername.Text.Equals(""))
            {
                MessageBox.Show("No deje espacios vacios!", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bool exist = false, admin;
                    foreach (var u in UserDAO.getListaUsers())
                    {
                        if (u.Username.Equals(txtUsername))
                            exist = true;
                    }

                    if (exist)
                    {
                        MessageBox.Show("Alguien mas ya esta usando ese nombre de usuario!", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                   
                        if (radAdmin.Checked)
                            admin = true;
                        else
                            admin = false;
                        User newUser = new User(txtFullName.Text,txtUsername.Text,txtUsername.
                            Text,admin);
                    
                        UserDAO.AddUser(newUser);

                        MessageBox.Show("Usuario agregado");
                        
                        //se limpian los txt y se actualizan los users
                        txtFullName.Text = "";
                        txtUsername.Text = "";
                        FillComboBoxUsers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
                
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text.Equals(unUser.Username))
                {
                    MessageBox.Show("No puedes eliminarte tu mismo!", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Seguro desea eliminar el usuario?", "Atencion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(cmbUserDelete.SelectedValue);
                    UserDAO.DeleteUser(id);
                
                    MessageBox.Show("Usuario eliminado");
                    FillComboBoxUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
            
        }

        //actualizar usuarios
        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }
    }
}