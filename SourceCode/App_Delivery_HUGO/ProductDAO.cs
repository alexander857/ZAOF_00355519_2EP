using System;
using System.Collections.Generic;
using System.Data;

namespace App_Delivery_HUGO
{
    public static class ProductDAO
    {
        public static List<Product> getListProd()
        {
            string sql = "";

            sql = "SELECT * FROM PRODUCT";

            DataTable dt = ConnectionBDD.ExecuteQuery(sql);
            
            //lista de usuarios
            List<Product> products = new List<Product>();

            foreach (DataRow row in dt.Rows)
            {
                Product P = new Product();

                P.IdProd = Convert.ToInt32(row[0].ToString());
                P.IdBusiness = Convert.ToInt32(row[1].ToString());
                P.Name = row[2].ToString();

                products.Add(P);
            }

            return products;
        }
        
        public static void AddProduct(Product p)
        {
            string sql = String.Format(
                $"INSERT INTO PRODUCT(idbusiness,name) VALUES" +
                $"({p.IdBusiness},'{p.Name}')"
            );
            
            ConnectionBDD.ExecuteNonQuery(sql); 
        }

        public static void DeleteProduct(int id)
        {
            string sql = String.Format(
                $"DELETE FROM PRODUCT WHERE idproduct ={id}"
            );
            ConnectionBDD.ExecuteNonQuery(sql);
        }
        
    }
}