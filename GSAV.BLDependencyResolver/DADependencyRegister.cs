using GSAV.Data.Oracle.Implementation;
using GSAV.Data.Oracle.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace GSAV.BLDependencyResolver
{
    public class DADependencyRegister
    {
        public static void RegisterTypes(IUnityContainer oIUnityContainer)
        {
            oIUnityContainer.RegisterType<IDAUsuario, DAUsuario>();
        }
    }
}
