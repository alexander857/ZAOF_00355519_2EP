using System;
using System.Collections.Generic;
using System.Data;

namespace App_Delivery_HUGO
{
    public static class AddressDAO
    {
        public static List<AddressClass> getListAddress(int id)
        {
            string sql = "";

            sql = $"SELECT * FROM ADDRESS WHERE iduser={id}";

            DataTable dt = ConnectionBDD.ExecuteQuery(sql);
            
            //lista de usuarios
            List<AddressClass> listAddress = new List<AddressClass>();

            foreach (DataRow row in dt.Rows)
            {
                AddressClass a = new AddressClass();

                a.IdAddress = Convert.ToInt32(row[0].ToString());
                a.Iduser = Convert.ToInt32(row[1].ToString());
                a.PAddress = row[2].ToString();

                listAddress.Add(a);
            }

            return listAddress;
        }

        //agregar una direccion
        public static void AddAddress(AddressClass a)
        {
            string sql = String.Format(
                $"INSERT INTO ADDRESS(iduser,address) VALUES" +
                $"('{a.Iduser}','{a.PAddress}')"
            );
            
            ConnectionBDD.ExecuteNonQuery(sql); 
        }
        
        //eliminar direccion
        public static void DeleteAddress(int id)
        {
            string sql = String.Format(
                $"DELETE FROM ADDRESS WHERE idaddress ={id}"
            );
            ConnectionBDD.ExecuteNonQuery(sql);
        }
        
        //actualizar o modificar direccion
        public static void UpdateAddress(int id, string newAddress)
        {
            string sql = String.Format(
                "UPDATE ADDRESS SET address='{0}' WHERE idaddress='{1}';",
                newAddress,id);
            
            
            ConnectionBDD.ExecuteNonQuery(sql);
        }
    }
}