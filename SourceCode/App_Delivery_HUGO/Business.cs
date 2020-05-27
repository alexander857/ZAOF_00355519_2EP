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

        private void Business_Load(object sender, EventArgs e)
        {
            
        }
    }
}