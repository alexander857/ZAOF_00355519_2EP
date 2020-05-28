using System;
using System.Windows.Forms;

namespace App_Delivery_HUGO
{
    public partial class Address : UserControl
    {
        private User unUser;
        public Address(User u)
        {
            InitializeComponent();
            unUser = u;
        }

        private void Address_Load(object sender, EventArgs e)
        {
            FillDataGrid();
            FillIDAddress();
            FillIDAddressModify();
        }
        
        //se llena el datagrid de las direcciones
        public void FillDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AddressDAO.getListAddress(unUser.Id);
        }
        
        //llenando combobox de idDirecciones
        public void FillIDAddress()
        {
            cmbIDAddress.DataSource = null;
            cmbIDAddress.ValueMember = "idAddress";
            cmbIDAddress.DisplayMember = "idAddress";
            cmbIDAddress.DataSource = AddressDAO.getListAddress(unUser.Id);
        }
        
        //llenando combobox de id direcciones a modificar
        public void FillIDAddressModify()
        {
            cmbIDAddressModify.DataSource = null;
            cmbIDAddressModify.ValueMember = "idAddress";
            cmbIDAddressModify.DisplayMember = "idAddress";
            cmbIDAddressModify.DataSource = AddressDAO.getListAddress(unUser.Id);
        }


        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddAdress.Text.Equals(""))
                {
                    MessageBox.Show("No deje espacios vacios!", "Error", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
                else
                {
                    //se agrega una nueva direccion
                    AddressClass newAddress = new AddressClass(unUser.Id,txtAddAdress.Text);
                    AddressDAO.AddAddress(newAddress);
                
                    MessageBox.Show("Direccion agregada con exito");
                    txtAddAdress.Text = "";
                    
                    //se actualizan todos los controles
                    FillDataGrid();
                    FillIDAddress();
                    FillIDAddressModify();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
            
        }

        //eliminar una direccion
        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro desea eliminar esta direccion?", "Atencion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //se manda a eliminar la direccion indicada con el id indicado
                    int id = Convert.ToInt32(cmbIDAddress.SelectedValue);
                
                    AddressDAO.DeleteAddress(id);
                    MessageBox.Show("Direccion eliminada con exito");
                    
                    //se actualizan los controles
                    FillDataGrid();
                    FillIDAddress();
                    FillIDAddressModify();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
           
        }

        private void btnModifyAddress_Click(object sender, EventArgs e)
        {
            if (txtNewAddress.Text.Equals(""))
            {
                MessageBox.Show("No deje espacios vacios!", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else
            {
                //se actualiza la direccion con id seleccionado
                int id = Convert.ToInt32(cmbIDAddressModify.SelectedValue);
                
                AddressDAO.UpdateAddress(id,txtNewAddress.Text);
                MessageBox.Show("Direccion modificada con exito");
                
                //se actualizan todos los controles
                FillDataGrid();
                FillIDAddress();
                FillIDAddressModify();
            }
        }
    }
}