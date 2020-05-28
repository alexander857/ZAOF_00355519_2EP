using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace App_Delivery_HUGO
{
    public static class BusinessDAO
    {
        public static List<BusinessClass> getListaBusiness()
        {
            string sql = "";

            sql = "SELECT * FROM BUSINESS";

            DataTable dt = ConnectionBDD.ExecuteQuery(sql);
            
            //lista de usuarios
            List<BusinessClass> businesses = new List<BusinessClass>();

            foreach (DataRow row in dt.Rows)
            {
                BusinessClass b = new BusinessClass();

                b.Id = Convert.ToInt32(row[0].ToString());
                b.Name = row[1].ToString();
                b.Description = row[2].ToString();
                
                
                businesses.Add(b);
            }

            return businesses;
        }
        
        public static void AddBusiness(BusinessClass b)
        {
            string sql = String.Format(
                $"INSERT INTO BUSINESS(name,description) VALUES" +
                $"('{b.Name}','{b.Description}')"
            );
            
            ConnectionBDD.ExecuteNonQuery(sql); 
            
        }
        
        public static void DeleteBusiness(int id)
        {
            string sql = String.Format(
                $"DELETE FROM BUSINESS WHERE idbusiness ={id}"
            );
            ConnectionBDD.ExecuteNonQuery(sql);
        }
    }
}