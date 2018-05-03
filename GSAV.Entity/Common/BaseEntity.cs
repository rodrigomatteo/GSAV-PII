using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAV.Entity.Common
{
    public class BaseEntity
    {
        public string Codigo { get; set; }
        public bool Estado { get; set; }
        public string UsuarioRegistro { get; set; }
        public string UsuarioModificacion { get; set; }
        public string FechaRegistro { get; set; }
        public string FechaModificacion { get; set; }
    }
}
