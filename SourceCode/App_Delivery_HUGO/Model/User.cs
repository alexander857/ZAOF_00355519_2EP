namespace App_Delivery_HUGO
{
    public class User
    {
        private int id;
        private string fullname, username, password;
        private bool type;
        

        //sobrecarga contructor que no recibe id
        public User(string fullname, string username, string password, bool type)
        {
            this.fullname = fullname;
            this.username = username;
            this.password = password;
            this.type = type;
        }
        
        //sobrecarga donde no recibe ningun parametro
        public User(){}

        //propiedades
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Fullname
        {
            get => fullname;
            set => fullname = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public bool Type
        {
            get => type;
            set => type = value;
        }
    }
}