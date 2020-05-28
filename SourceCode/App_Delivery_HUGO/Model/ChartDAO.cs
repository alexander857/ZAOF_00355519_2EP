using System;
using System.Collections.Generic;
using System.Data;

namespace App_Delivery_HUGO
{
    public static class ChartDAO
    {
        public static List<ChartsClass> getListChart()
        {
            string sql = "";

            sql = "SELECT b.name AS \"Negocio\", sum(cp.cant) AS \"Total pedidos\"\nFROM BUSINESS b, " + 
                  "(SELECT p.idBusiness, p.name, count(ap.idProduct) AS \"cant\"\nFROM PRODUCT p, APPORDER ap "+
                  "WHERE p.idProduct = ap.idProduct\nGROUP BY p.idProduct \nORDER BY p.name ASC) AS cp " +
                  "WHERE b.idBusiness = cp.idBusiness\nGROUP BY b.idBusiness";

            DataTable dt = ConnectionBDD.ExecuteQuery(sql);
            
            //lista de usuarios
            List<ChartsClass> dataChart = new List<ChartsClass>();

            foreach (DataRow row in dt.Rows)
            {
                ChartsClass c = new ChartsClass();

                c.Business = row[0].ToString();
                c.TotalOrders = Convert.ToInt32(row[1].ToString());
                
                dataChart.Add(c);
            }

            return dataChart;
        }
    }
}