using Preparcial.Controlador;
using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preparcial.Vista
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        //SE REACOMODO EL CODIGO YA QUE ESTABA DESORDENADO
        private void FrmPassword_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("../../Recursos/UCA.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            ActualizarControlers();
        }

        private void ActualizarControlers()
        {
            comboBox1.ValueMember = "Contrasena";
            comboBox1.DisplayMember = "NombreUsuario";
            comboBox1.DataSource = ControladorUsuario.GetUsuarios();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //se pone un trycatch ya que es mejor manejarlos aqui
            try
            {
                //SE PUSO UNA VERIFICACION DE QUE NO PODIA DEJAR CAMPOS VACIOS,YA QUE PERMITIA QUE EL ESPACIO
                //DE CONTRASEÑA EN LA BASE QUEDARA VACIO
                
                if (txtNewPassword.Text.Equals("") || txtOldPassword.Text.Equals(""))
                {
                    MessageBox.Show("No deje campos vacios");
                }
                else if (txtOldPassword.Text.Equals(comboBox1.SelectedValue.ToString()))
                {       
                    var obtenerUsuario = (Usuario)comboBox1.SelectedItem;

                    ActualizarControlers();
                
                    ControladorUsuario.ActualizarContrasena(obtenerUsuario.IdUsuario,
                        txtNewPassword.Text);
                   
                    //SE AGREGO QUE SE OCULTE ESTE FORM Y SALGA DE NUEVO EL LOGIN PARA QUE SE ACTUALICEN LOS DATOS
                    //DE LOS USUARIOS EN LA BASE, Y DE UNA VEZ PUEDA USAR SU NUEVA CONTRA ANTES DE ENTRAR, YA QUE
                    //NO OCURRIA PORQUE NO SE ACTUALIZABAN AL MOMENTO
                    
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            
        }
        
    }
}
