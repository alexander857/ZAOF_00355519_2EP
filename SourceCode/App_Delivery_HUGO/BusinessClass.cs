namespace App_Delivery_HUGO
{
    public class BusinessClass
    {
        private int id;
        private string name, description;

        public BusinessClass(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public BusinessClass(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public BusinessClass(){}

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }
    }
}