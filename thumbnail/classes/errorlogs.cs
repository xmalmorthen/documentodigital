using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using scanndoc.models;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;

namespace scanndoc.classes
{
    public static class errorlogs
    {
        public static string seterror(Exception e) {
            Boolean guardatrace = true;
            string errorcode = "";

            string errorstring = e.Message;           

            Type tipo = e.GetType();
            switch (tipo.FullName)
            {
                case "System.Data.SqlClient.SqlException":
                    switch ((e as System.Data.SqlClient.SqlException).Number)
	                {
                        case 53: //al no alcanzar el servidor
                            errorstring = "Error al intentar conectar con la base de datos, favor de verificar su conexión de red e intentarlo de nuevo." + Environment.NewLine +
                                          "Si persiste el problema favor de notificarlo al administrador del sistema";
                            guardatrace = false;
                        break;
                        case 547: // error de eliminado en cascadaa
                            errorstring = "Se encontraron referencias al registro, imposible eliminar";
                        break;
                        case 4060: // error de base de datos fuera de linea, renombrada o eliminada
                            errorstring = "Error al intentar conectar con la base de datos, favor de intentarlo de nuevo." + Environment.NewLine +
                                          "Si persiste el problema favor de notificarlo al administrador del sistema";
                            guardatrace = false;
                        break;
                        case 18456: // error al sesionar con usuario de bd
                            errorstring = "Usuario y/o contraseña no válidos";
                        break;
	                }
                    MessageBox.Show(errorstring,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorcode = (e as System.Data.SqlClient.SqlException).Number.ToString();
                    break;
                case "System.InvalidCastException":
                    guardatrace = false;
                    break;
                default:
                    try
                    {
                        errorcode = (e as Win32Exception).ErrorCode.ToString();
                    }
                    catch (Exception)
                    {                        
                        throw;
                    }                    
                    break;
            }

            if (guardatrace) {
                data_members.tbl_errorlogs errlog = new data_members.tbl_errorlogs();
                errlog.id_usuario = Usuario.Logeado.id;
                errlog.code = 
                errlog.message = e.Message;
                errlog.trace = e.StackTrace;
                
                string strHostName = string.Empty;
                strHostName = Dns.GetHostName();
                
                errlog.host = Dns.GetHostName();

                IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);
                errlog.ip = "";
                for (int i = 0; i < hostIPs.Length; i++)
                {
                    if (hostIPs[i].AddressFamily == AddressFamily.InterNetwork) { 
                        errlog.ip += hostIPs[i].ToString() + ( (i < hostIPs.Length - 1 ) ? "~" :"" );
                    }
                }
                
                try
                {
                    scanndoc.data_members.Bd_Expedientes_DigitalesDataContext Bd = new data_members.Bd_Expedientes_DigitalesDataContext();
                    Bd.tbl_errorlogs.InsertOnSubmit(errlog);
                    Bd.SubmitChanges();
                    Bd.Dispose();
                }
                catch (Exception)
                {/*no debe llevar nada*/}
                errlog = null;
            }

            return errorstring;
        }
    }
}
