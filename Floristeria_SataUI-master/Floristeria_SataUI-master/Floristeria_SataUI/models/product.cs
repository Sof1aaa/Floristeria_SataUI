using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floristeria_SataUI.models
{
    public class product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public decimal Precio { get; set; }
        public string Imagen { get; set; }

        public int Stock { get; set; }

        public string Categoria { get; set; }
    }
}
