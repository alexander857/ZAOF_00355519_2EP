namespace App_Delivery_HUGO
{
    public class ChartsClass
    {
        private string business;
        private int totalOrders;
        

        public string Business
        {
            get => business;
            set => business = value;
        }

        public int TotalOrders
        {
            get => totalOrders;
            set => totalOrders = value;
        }
    }
}