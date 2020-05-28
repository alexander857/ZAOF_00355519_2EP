using System;
using System.Windows.Forms;

namespace App_Delivery_HUGO
{
    public partial class Business : UserControl
    {
        private User unUser;
        public Business(User u)
        {
            InitializeComponent();
            unUser = u;
        }
        
        //llenando datagrid
        public void UpdateDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BusinessDAO.getListaBusiness();
        }

        //se llena el combobox de negocios
        public void FillComboBoxBusiness()
        {
            cmbBusiness.DataSource = null;
            cmbBusiness.ValueMember = "id";
            cmbBusiness.DisplayMember = "name";
            cmbBusiness.DataSource = BusinessDAO.getListaBusiness();
        }

        private void Business_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
            FillComboBoxBusiness();
        }

        private void btnAddBusiness_Click(object sender, EventArgs e)
        {
            if (txtNameBusiness.Text.Equals("") || txtDescription.Text.Equals(""))
            {
                MessageBox.Show("No deje espacios vacios!", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bool exist = false;

                    foreach (var b in BusinessDAO.getListaBusiness())
                    {
                        if (b.Name.Equals(txtNameBusiness.Text))
                        {
                            exist = true;
                        }
                    }

                    if (exist)
                    {
                        MessageBox.Show("Ya existe un negocio llamado!" + txtNameBusiness.Text,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BusinessClass newBusiness = new BusinessClass(txtNameBusiness.Text,txtDescription.Text);
                        
                        BusinessDAO.AddBusiness(newBusiness);
                        
                        MessageBox.Show("Negocio agregado");
                        CleanTxtAddBussiness();
                        FillComboBoxBusiness();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
            }
        }


        private void btnUptadeBusiness_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void btnDeleteBusiness_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro desea eliminar el negocio?", "Atencion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(cmbBusiness.SelectedValue);
                
                    BusinessDAO.DeleteBusiness(id);
                
                    MessageBox.Show("Negocio eliminado");
                    FillComboBoxBusiness();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
            
        }

        public void CleanTxtAddBussiness()
        {
            txtDescription.Text = "";
            txtNameBusiness.Text = "";
        }
    }
}