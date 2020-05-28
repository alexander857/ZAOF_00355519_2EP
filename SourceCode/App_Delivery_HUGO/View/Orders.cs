using System;
using System.Windows.Forms;

namespace App_Delivery_HUGO
{
    public partial class Orders : UserControl
    {
        private User unUser;
        public Orders(User u)
        {
            InitializeComponent();
            unUser = u;
        }

        public void FillDataGrid()
        {
            dataGridView1.DataSource = null;
            if(unUser.Type)
                dataGridView1.DataSource = OrderDAO.getListaOrder(0,unUser.Id);
            else 
                dataGridView1.DataSource = OrderDAO.getListaOrder(1,unUser.Id);
        }
        
        //llenar combobox de producto
        public void FillComboboxProduct()
        {
            cmbProduct.DataSource = null;
            cmbProduct.ValueMember = "idProd";
            cmbProduct.DisplayMember = "name";
            cmbProduct.DataSource = ProductDAO.getListProd();
        }
        
        //llenar combobox de direccion
        public void FillComboboxAddresst()
        {
            cmbAddress.DataSource = null;
            cmbAddress.ValueMember = "idAddress";
            cmbAddress.DisplayMember = "pAddress";
            cmbAddress.DataSource = AddressDAO.getListAddress(unUser.Id);
        }
        
        private void Orders_Load(object sender, EventArgs e)
        {
            FillDataGrid();
            FillComboboxProduct();
            FillComboboxAddresst();
            DeactiveOptions();
        }


        private void btnUptadeOrders_Click(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        //enviar orden
        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now;

                int idProd = Convert.ToInt32(cmbProduct.SelectedValue);
                int idAddress = Convert.ToInt32(cmbAddress.SelectedValue);
            
                OrderClass newOrder = new OrderClass(date,idProd,idAddress);
            
                OrderDAO.AddOrder(newOrder);

                MessageBox.Show("Su orden ha sido enviada con exito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal!");
            }
            
        }

        //eliminar orden
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdOrderDelete.Text.Equals(""))
                {
                    MessageBox.Show("No deje espacios vacios!", "Error", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
                else
                {
                    bool exist = false;
                    int idOrder = Convert.ToInt32(txtIdOrderDelete.Text);

                    //se verifica si esta la direccion con el id que se ingreso
                    foreach (var ord in OrderDAO.getListaOrder(1,unUser.Id))
                    {
                        if (ord.IdOrder == idOrder)
                            exist = true;
                    }

                    if (exist)
                    {
                        if (MessageBox.Show("Seguro quiere eliminar la orden?", "Aviso",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //se manda a eliminr la orden
                            OrderDAO.DeleteUser(idOrder);
                    
                            MessageBox.Show("Orden eliminada con exito!");
                            txtIdOrderDelete.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("No exite una orden con ese id!", "Error", MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                    }
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal!");
            }
            
        }
        
        //desactivar opciones
        public void DeactiveOptions()
        {
            if (unUser.Type)
            {
                tabPage2.Parent = null;
                tabPage3.Parent = null;
            }
        }
    }
}