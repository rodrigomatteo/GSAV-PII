using GSAV.Data.Common;
using GSAV.Data.Oracle.Interface;
using GSAV.Entity.Objects;
using GSAV.Entity.Util;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAV.Data.Oracle.Implementation
{
    public class DAUsuario : IDAUsuario
    {
        public ReturnObject<Usuario> ValidarAcceso(Usuario usuario)
        {
            ReturnObject<Usuario> obj = new ReturnObject<Usuario>();
            obj.OneResult = new Usuario();

            try
            {
                using (var oCnn = Cn.OracleCn())
                {
                    OracleCommand oCmd = null;
                    oCnn.Open();
                    oCmd = new OracleCommand(SP.SP_VALIDARACCESO, oCnn);
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.Add(new OracleParameter("P_USUARIO", OracleDbType.Varchar2)).Value = usuario.NombreUsuario;
                    oCmd.Parameters.Add(new OracleParameter("P_CLAVE", OracleDbType.Varchar2)).Value = usuario.Clave;
                    oCmd.Parameters.Add(new OracleParameter("P_RC", OracleDbType.RefCursor)).Direction = ParameterDirection.Output;
                    OracleDataReader rd = oCmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        if (rd.Read())
                        {
                            obj.OneResult = new Usuario()
                            {
                                Id = rd.GetInt32(rd.GetOrdinal("IDUSUARIO")),
                                NombreUsuario = rd.GetString(rd.GetOrdinal("NOMBREUSUARIO")),
                                Alumno = new Alumno()
                                {
                                    Nombre = rd.GetString(rd.GetOrdinal("NOMBRE")),
                                    Unidad = rd.GetString(rd.GetOrdinal("UNIDAD"))
                                },
                            };
                            obj.Success = true;
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                obj.Success = false;
                obj.ErrorMessage = ex.Message;
            }

            return obj;
        }
    }
}
