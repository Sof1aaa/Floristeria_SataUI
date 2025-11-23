using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floristeria_SataUI.models
{
    public class Clients
    {
        public long Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Foto { get; set; }
    }
}
