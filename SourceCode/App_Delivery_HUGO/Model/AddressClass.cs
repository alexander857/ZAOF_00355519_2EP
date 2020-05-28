namespace App_Delivery_HUGO
{
    public class AddressClass
    {
        private int idAddress, iduser;
        private string pAddress;

        public AddressClass(int iduser, string address)
        {
            this.iduser = iduser;
            pAddress = address;
        }

        public AddressClass(){}

        public int IdAddress
        {
            get => idAddress;
            set => idAddress = value;
        }

        public int Iduser
        {
            get => iduser;
            set => iduser = value;
        }

        public string PAddress
        {
            get => pAddress;
            set => pAddress = value;
        }
    }
}