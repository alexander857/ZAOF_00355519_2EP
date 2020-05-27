using System;

namespace App_Delivery_HUGO
{
    public class UsernameExistExeption : Exception
    {
        
        public UsernameExistExeption(string message) : base(message)
        {
        }
    }
}