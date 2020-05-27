using System;
using System.Collections.Generic;
using System.Data;

namespace App_Delivery_HUGO
{
    public static class UserDAO
    {
        public static List<User> getListaUsers()
        {
            string sql = "";

            sql = "SELECT * FROM APPUSER";

            DataTable dt = ConnectionBDD.ExecuteQuery(sql);
            
            //lista de usuarios
            List<User> users = new List<User>();

            foreach (DataRow row in dt.Rows)
            {
                User u = new User();

                u.Id = Convert.ToInt32(row[0].ToString());
                u.Fullname = row[1].ToString();
                u.Username = row[2].ToString();
                u.Password = row[3].ToString();
                u.Type = Convert.ToBoolean(row[4].ToString());
                
                users.Add(u);
            }

            return users;
        }
  
        public static void AddUser(User u)
        {
            string sql = String.Format(
                $"INSERT INTO APPUSER(fullname,username,password,userType) VALUES" +
                $"('{u.Fullname}','{u.Username}','{u.Password}',{u.Type})"
            );
            
            ConnectionBDD.ExecuteNonQuery(sql); 
        }

        public static void DeleteUser(int id)
        {
            string sql = String.Format(
                $"DELETE FROM APPUSER WHERE idUser ={id}"
                );
            ConnectionBDD.ExecuteNonQuery(sql);
        }
    }
}