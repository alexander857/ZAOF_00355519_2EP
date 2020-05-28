using System;
using System.Windows.Forms;

namespace App_Delivery_HUGO
{
    public partial class Products : UserControl
    {
        private User unUser;
        public Products(User u)
        {
            InitializeComponent();
            unUser = u;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            FillDataGridProd();
            FillcmbBusiness();
            FillcmbProductDelete();
        }

        //llenando datagrid
        public void FillDataGridProd()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProductDAO.getListProd();
        }
        
        //llenando el combobox de negocios
        public void FillcmbBusiness()
        {
            cmbBusiness.DataSource = null;
            cmbBusiness.ValueMember = "id";
            cmbBusiness.DisplayMember = "name";
            cmbBusiness.DataSource = BusinessDAO.getListaBusiness();
        }

        //llenando el combobox de productos a eliminar
        public void FillcmbProductDelete()
        {
            cmbProductDelete.DataSource = null;
            cmbProductDelete.ValueMember = "idProd";
            cmbProductDelete.DisplayMember = "name";
            cmbProductDelete.DataSource = ProductDAO.getListProd();
        }

        //agegar producto
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtNameProduct.Text.Equals(""))
            {
                MessageBox.Show("No deje espacios vacios!", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bool exist = false;
                    int idBusiness = 0;

                    //se compara a ver si no hay otro producto que se llama igual
                    foreach (var p in ProductDAO.getListProd())
                    {
                        if (p.Name.Equals(txtNameProduct))
                            exist = true;
                    }

                    if (exist)
                    {
                        MessageBox.Show("Ya hay un producto con ese mismo nombre!", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        idBusiness = Convert.ToInt32(cmbBusiness.SelectedValue);
                    
                        Product newProduct = new Product(idBusiness,txtNameProduct.Text);
                    
                        ProductDAO.AddProduct(newProduct);
                    
                        MessageBox.Show("Producto agregado");
                        FillcmbProductDelete();
                        txtNameProduct.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
                
            }
        }

        //actualizar productos
        private void btnUpdateProducts_Click(object sender, EventArgs e)
        {
            FillDataGridProd();
        }

        //eliminar producto
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro desea eliminar el producto?", "Atencion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(cmbProductDelete.SelectedValue);
                    
                    ProductDAO.DeleteProduct(id);
                    
                    MessageBox.Show("Producto eliminado");
                    FillcmbProductDelete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
            
        }
    }
}