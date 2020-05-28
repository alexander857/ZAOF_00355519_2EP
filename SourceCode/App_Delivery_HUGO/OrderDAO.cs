using System;
using System.Collections.Generic;
using System.Data;

namespace App_Delivery_HUGO
{
    public class OrderDAO
    {
        public static List<OrderClass> getListaOrder(int a, int iduser)
        {
            string sql = "";
            bool admin;

            if (a == 0)
            {
                sql =
                    $"SELECT ord.idorder, us.fullname, ad.address, pro.name, bu.name, ord.createDate, " +
                    $"ord.idProduct, ord.idAddress " + 
                    "FROM APPORDER ord, APPUSER us, ADDRESS ad, BUSINESS bu, PRODUCT pro " + 
                    $"WHERE ord.idAddress = ad.IdAddress AND ad.IdUser = us.IdUser " + 
                    "AND ord.IdProduct = pro.IdProduct AND pro.idBusiness = bu.IdBusiness";
                
            }
            else
            {
                sql =
                    $"SELECT ord.idorder, us.username, ad.address, pro.name, bu.name, ord.createDate, " +
                    $"ord.idProduct, ord.idAddress " + 
                    "FROM APPORDER ord, APPUSER us, ADDRESS ad, BUSINESS bu, PRODUCT pro " + 
                    $"WHERE ord.idAddress = ad.IdAddress AND us.idUser = {iduser} " + 
                    "AND ord.IdProduct = pro.IdProduct AND pro.idBusiness = bu.IdBusiness";
                
            }

            DataTable dt = ConnectionBDD.ExecuteQuery(sql);
            
            //lista de usuarios
            List<OrderClass> order = new List<OrderClass>();

            foreach (DataRow row in dt.Rows)
            {
                OrderClass o = new OrderClass();

                o.IdOrder = Convert.ToInt32(row[0].ToString());
                o.User = row[1].ToString();
                o.Address = row[2].ToString();
                o.Product = row[3].ToString();
                o.Business = row[4].ToString();
                o.Date = DateTime.Parse(row[5].ToString());
                o.IdProd = Convert.ToInt32(row[6].ToString());
                o.IdAddress = Convert.ToInt32(row[7].ToString());
                
                order.Add(o);
            }

            return order;
        }
        
        //agregar orden
        public static void AddOrder(OrderClass o)
        {
            string pdate = o.Date.ToString("yyy,MM,dd");
            
            string sql = String.Format(
                $"INSERT INTO APPORDER(createdate,idproduct,idaddress) VALUES" +
                $"('{pdate}',{o.IdProd},{o.IdAddress})"
            );
            
            ConnectionBDD.ExecuteNonQuery(sql); 
        }
        
        //eliminar orden
        public static void DeleteUser(int id)
        {
            string sql = String.Format(
                $"DELETE FROM APPORDER WHERE idorder ={id}"
            );
            ConnectionBDD.ExecuteNonQuery(sql);
        }
    }
}