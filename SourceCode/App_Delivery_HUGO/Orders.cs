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

        private void Orders_Load(object sender, EventArgs e)
        {
            
        }
    }
}