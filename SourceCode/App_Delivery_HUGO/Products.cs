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
            
        }
    }
}