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

        public void FillDataGrid()
        {
            
        }
    }
}