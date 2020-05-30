using Preparcial.Modelo;
using Preparcial.Controlador;
using System.Windows.Forms;
using System.Linq;
using System;

namespace Preparcial.Vista
{
    public partial class FrmMain : Form
    {
        private Usuario u;

        public FrmMain(Usuario u)
        {
            InitializeComponent();
            this.u = u;
        }
        
        //AL TABCONTROL SE LE PUSO LA PROPIEDAD FILL PARA QUE SE AJUSTE A LA VENTANA
        //AL GROUPBOX_3 SE LE CAMBIO EL TEXTO, YA QUE LO QUE SE HACE ES ACTUALIZAR O MODIFICAR UN PRODUCTO,
        //NO ELIMINARLO

        private void bttnCreateUser_Click(object sender, EventArgs e)
        {
            //SE AGREGO UN MENSAJE AL USUARIO DE QUE DEBE LLENAR EL CAMPO Y SE AGREGO UN TRYCATCH, PARA MANEJAR
            //AQUI LAS EXCEPCIONES MEJOR
            try
            {
                if (!txtNewUser.Text.Equals(""))
                {
                    ControladorUsuario.CrearUsuario(txtNewUser.Text);
                    ActualizarCrearUsuario();
                }
                else
                {
                    MessageBox.Show("No puede dejar campos vacios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            
        }

        private void ActualizarCrearUsuario()
        {
            dgvCreateUser.DataSource = ControladorUsuario.GetUsuariosTable();
        }

        private void ActualizarInventario()
        {
            dgvInventary.DataSource = ControladorInventario.GetProductosTable();
        }

        private void ActualizarOrdenes()
        {
            dgvAllOrders.DataSource = ControladorPedido.GetPedidosTable();
        }

        private void ActualizarOrdenesUsuario()
        {
            dgvMyOrders.DataSource = ControladorPedido.GetPedidosUsuarioTable(u.IdUsuario);
            cmbProductMakeOrder.DataSource = null;
            cmbProductMakeOrder.ValueMember = "idArticulo";
            cmbProductMakeOrder.DisplayMember = "producto";
            cmbProductMakeOrder.DataSource = ControladorInventario.GetProductos();
        }

        //SE AGREGAN TRYCHATCH YA QUE ES MAS CONVENIENTE MAJENAR AQUI LAS EXCEPCIONES
        private void bttnAddInventary_Click(object sender, EventArgs e)
        {
            try
            {
                //SE CAMBIO EL && A || YA QUE ASI SE AVISA AL USUARIO QUE NO DEJE CAMPOS VACIOS SIN IMPORTAR CUAL
                //HAYA DEJADO VACIO
                if (txtProductNameInventary.Text.Equals("") ||
                    txtDescriptionInventary.Text.Equals("") ||
                    txtPriceInventary.Text.Equals("") ||
                    txtStockInventary.Text.Equals(""))
                    MessageBox.Show("No puede dejar campos vacios");
                else
                {
                    //el codigo no puede cruzar el limite, ya que es mala practica
                
                    //precio y stock no son tipo string
                    double precio = 0;
                    int stock = 0;

                    precio = Convert.ToDouble(txtPriceInventary.Text);
                    stock = Convert.ToInt32(txtStockInventary.Text);
                
                    ControladorInventario.AnadirProducto(txtProductNameInventary.Text, 
                        txtDescriptionInventary.Text,precio,stock);

                    ActualizarInventario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
          
        }

        private void bttnDeleteInventary_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDeleteInventary.Text.Equals(""))
                    MessageBox.Show("No puede dejar campos vacios");
                else
                {
                    ControladorInventario.EliminarProducto(txtDeleteInventary.Text);
                    ActualizarInventario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            
        }

        private void bttnUpdateStockInventary_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUpdateStockIdInventary.Text.Equals("") && txtUpdateStockInventary.Text.Equals(""))
                    MessageBox.Show("No puede dejar campos vacios");
                else
                {
                    //SE LE DA UN SALDO DE LINEA YA QUE SE PASABA DEL LIMITE DONDE TIENE QUE LLEGAR EL CODIGO
                    ControladorInventario.ActualizarProducto(txtUpdateStockIdInventary.Text, 
                        txtUpdateStockInventary.Text);
                    ActualizarInventario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
           
        }

        private void bttnMakeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMakeOrderQuantity.Text.Equals(""))
                    MessageBox.Show("No puede dejar campos vacios");
                else
                {
                    //el codigo no puede cruzar el limite, ya que es mala practica
                    ControladorPedido.HacerPedido(u.IdUsuario, cmbProductMakeOrder.SelectedValue.ToString(), 
                        txtMakeOrderQuantity.Text);
                    ActualizarOrdenesUsuario();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SE MODIFICO DE TAL MANERA QUE NO MUESTRE EL MENSAJE DE "NO TIENE PERMISO" CADA QUE SE SELECCIONE
            //EL TAB GENERAL
            
            if (!tabControl1.SelectedTab.Name.Equals("generalTab"))
            {
                if (tabControl1.SelectedTab.Name.Equals("createNewUserTab") && u.Admin)
                    ActualizarCrearUsuario();

                else if (tabControl1.SelectedTab.Name.Equals("inventaryTab") && u.Admin)
                    ActualizarInventario();

                else if (tabControl1.SelectedTab.Name.Equals("createOrderTab") && !u.Admin)
                    ActualizarOrdenesUsuario();

                else if (tabControl1.SelectedTab.Name.Equals("viewOrdersTab") && u.Admin)
                    ActualizarOrdenes();
            
                else
                {
                    MessageBox.Show("No tiene permisos para ver esta pestana");
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                }
            }

        }

        //el codigo debe estar ordenado
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        
    }
}
