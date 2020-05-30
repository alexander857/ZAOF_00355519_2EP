using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparcial.Modelo
{
    public class Pedido
    {
       
        public int idPedido { get; set; }
        public int idUsuario { get; set; }
        public int idArticulo { get; set;}
        public int cantidad { get; set; }

        public Pedido(int idPedido, int idUsuario, int idArticulo, int cantidad)
        {
            this.idPedido = idPedido;
            this.idUsuario = idUsuario;
            this.idArticulo = idArticulo;
            this.cantidad = cantidad;
        }
    }
}
