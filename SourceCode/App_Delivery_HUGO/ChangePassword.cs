using System;
using System.Windows.Forms;

namespace App_Delivery_HUGO
{
    public partial class ChangePassword : UserControl
    {
        private User unUser;
        public ChangePassword(User u)
        {
            InitializeComponent();
            unUser = u;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            
        }
    }
}