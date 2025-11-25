using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floristeria_SataUI.models
{
    public class ProductoRanking
    {
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public int TotalVendido { get; set; }
        public int CantidadVendida { get; set; }
        public decimal Ingresos { get; set; }
        public double PorcentajeVentas { get; set; }

    }
}
