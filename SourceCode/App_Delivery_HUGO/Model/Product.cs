namespace App_Delivery_HUGO
{
    public class Product
    {
        private int idProd, idBusiness;
        private string name;
        

        //sobrecarga no recibe id
        public Product(int idBusiness, string name)
        {
            this.idBusiness = idBusiness;
            this.name = name;
        }

        //sobrecarga no recibe parametros
        public Product() {}

        public int IdProd
        {
            get => idProd;
            set => idProd = value;
        }

        public int IdBusiness
        {
            get => idBusiness;
            set => idBusiness = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}