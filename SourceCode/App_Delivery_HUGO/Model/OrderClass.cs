using System;

namespace App_Delivery_HUGO
{
    public class OrderClass
    {
        private int idOrder;
        private string user, address, product, business;
        private DateTime date;
        private int idProd, idAddress;

        public OrderClass(DateTime date, int idProd, int idAddress)
        {
            this.date = date;
            this.idProd = idProd;
            this.idAddress = idAddress;
        }

        //sobrecarga de constructor
        public OrderClass(){}

        public int IdOrder
        {
            get => idOrder;
            set => idOrder = value;
        }
        

        public string User
        {
            get => user;
            set => user = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string Product
        {
            get => product;
            set => product = value;
        }

        public string Business
        {
            get => business;
            set => business = value;
        }

        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        public int IdProd
        {
            get => idProd;
            set => idProd = value;
        }

        public int IdAddress
        {
            get => idAddress;
            set => idAddress = value;
        }
    }
}