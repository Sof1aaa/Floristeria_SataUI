using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floristeria_SataUI.models
{
    public class ItemCarrito
    {
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => Cantidad * PrecioUnitario;
       
        public string foto { get; set; }
        public int StockDisponible { get; set; }

    }
}
