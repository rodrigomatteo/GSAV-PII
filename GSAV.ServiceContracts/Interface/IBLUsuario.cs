using GSAV.Entity.Objects;
using GSAV.Entity.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAV.ServiceContracts.Interface
{
    public interface IBLUsuario
    {
        ReturnObject<Usuario> ValidarAcceso(Usuario usuario);
    }
}
