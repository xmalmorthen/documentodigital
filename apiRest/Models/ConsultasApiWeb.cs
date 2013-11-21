using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiRest.data_members;
using System.Drawing;

namespace apiRest.ModelsApiWeb
{
    public class ConsultasApiWeb
    {
        private Bd_Expedientes_DigitalesDataContext bd = new Bd_Expedientes_DigitalesDataContext();

        public IEnumerable<pa_ConsultaTramitesporValorTrazableResult> ConsultaTramitesporValorTrazable(string valor_trazable) {
            try
            {
                List<pa_ConsultaTramitesporValorTrazableResult> response = bd.pa_ConsultaTramitesporValorTrazable(valor_trazable).ToList();

                //datos aleatorios de prueba                
                string[] expedientes = new string[] { "Expediente 1", "Expediente 2", "Expediente 3" };

                Random bucle = new Random();
                for (int i = 0; i <= bucle.Next(10000); i++)
                {
                    DateTime start = new DateTime(1995, 1, 1);
                    Random gen = new Random();
                    int range = (DateTime.Today - start).Days;
                    response.Add(new pa_ConsultaTramitesporValorTrazableResult() { expediente = expedientes[ new Random().Next(0,3) ], id_estatus = i, id_ma_digital = i, nota = "prueba " + i.ToString(), id_tramite = i, tramite = "prueba " + i.ToString(), fecha_hora_creacion = start.AddDays(gen.Next(range)) });
                }
                //*******************************

                return response;
            }
            catch (Exception)
            {                
                throw;
            }        
        }

        public IEnumerable<pa_ConsultaTramitesporExpedienteyValorTrazableResult> ConsultaTramitesporExpedienteyValorTrazable(int id_Expediente,string valor_trazable)
        {
            try
            {
                List<pa_ConsultaTramitesporExpedienteyValorTrazableResult> response = bd.pa_ConsultaTramitesporExpedienteyValorTrazable(id_Expediente,valor_trazable).ToList();
                
                //datos aleatorios de prueba
                Random bucle = new Random();
                for (int i = 0; i <= bucle.Next(10000); i++)
                {
                    DateTime start = new DateTime(1995, 1, 1);
                    Random gen = new Random();
                    int range = (DateTime.Today - start).Days;
                    response.Add(new pa_ConsultaTramitesporExpedienteyValorTrazableResult() { expediente = "Expediente Prueba", id_estatus = i, id_ma_digital = i, nota = "prueba " + i.ToString(), id_tramite = i, tramite = "prueba " + i.ToString(), fecha_hora_creacion = start.AddDays(gen.Next(range)) });
                }
                //*******************************

                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<pa_CampostrazablesRegistradosporId_ma_digitalResult> CamposTrazables(int id_ma_digital)
        {
            try
            {
                List<pa_CampostrazablesRegistradosporId_ma_digitalResult> response = bd.pa_CampostrazablesRegistradosporId_ma_digital(id_ma_digital).ToList();

                //datos aleatorios de prueba
                Random bucle = new Random();
                for (int i = 0; i <= bucle.Next(15); i++)
                {
                    DateTime start = new DateTime(1995, 1, 1);
                    Random gen = new Random();
                    int range = (DateTime.Today - start).Days;
                    response.Add(new pa_CampostrazablesRegistradosporId_ma_digitalResult() { 
                                                                                            es_principal = Convert.ToBoolean(new Random().Next(0,1)),
                                                                                            id_campotrazable = new Random().Next(1,100),
                                                                                            id_estatus = new Random().Next(0, 1),
                                                                                            id_re_expediente_campotrazable = new Random().Next(1, 100),
                                                                                            Mascara = "Mascara",
                                                                                            Nombre = "Nombre trazabilidad",
                                                                                            Tamanio_Caracteres = new Random().Next(1, 50),
                                                                                            valor_trazable = "Valor trazable " + i
                                                                                           });
                }
                //*******************************

                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<pa_RegistrosDigitalesRegistradosporId_ma_digitalResult> RegistroDigital(int id_ma_digital)
        {
            try
            {
                List<pa_RegistrosDigitalesRegistradosporId_ma_digitalResult> response = bd.pa_RegistrosDigitalesRegistradosporId_ma_digital(id_ma_digital).ToList();

                //datos aleatorios de prueba
                Random bucle = new Random();
                Image img = Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Koala.jpg");
                string[] clasificaciondocumento = new string[] { "Identificacion oficial", "CURP", "Clasificacion 1", "Clasificacion 2" };
                string[] origen = new string[] { "Interno", "Externo", "CUsuario", "Proveedor" };

                for (int i = 0; i <= bucle.Next(50); i++)
                {
                    DateTime start = new DateTime(1995, 1, 1);
                    Random gen = new Random();
                    int range = (DateTime.Today - start).Days;
                    int rnd = new Random().Next(0,3);
                    response.Add(new pa_RegistrosDigitalesRegistradosporId_ma_digitalResult()
                    {                        
                        id_re_clasificaciondocumento_documento = rnd,
                        clasificaciondocumento = clasificaciondocumento[rnd],
                        Documento = "Documento",
                        fecha_hora_creacion = new DateTime().AddDays(new Random().Next( (DateTime.Today - new DateTime(1995,1,1)).Days)),
                        id = i,
                        id_origen = new Random().Next(1, 100),
                        Origen = origen[rnd],
                        thumbnail = classes.procesa_imagen.toByteArray(img),
                        valor_trazable = "Valor Trazable " + i
                    });
                }
                //*******************************

                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public pa_ImagenDigitalporId_de_digitalResult ImagenDigital(int id_de_digital)
        {
            try
            {
                pa_ImagenDigitalporId_de_digitalResult response = bd.pa_ImagenDigitalporId_de_digital(id_de_digital).SingleOrDefault();               

                //datos aleatorios de prueba
                if (response == null)
                {
                    response = new pa_ImagenDigitalporId_de_digitalResult();
                    Random bucle = new Random();
                    Image img = Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Koala.jpg");
                    string[] clasificaciondocumento = new string[] { "Identificacion oficial", "CURP", "Clasificacion 1", "Clasificacion 2" };
                    string[] origen = new string[] { "Interno", "Externo", "CUsuario", "Proveedor" };

                    DateTime start = new DateTime(1995, 1, 1);
                    Random gen = new Random();
                    int range = (DateTime.Today - start).Days;
                    int rnd = new Random().Next(0, 3);
                    response.id_re_clasificaciondocumento_documento = rnd;
                    response.clasificaciondocumento = clasificaciondocumento[rnd];
                    response.Documento = "Documento";
                    response.fecha_hora_creacion = new DateTime().AddDays(new Random().Next((DateTime.Today - new DateTime(1995, 1, 1)).Days));
                    response.id_origen = new Random().Next(1, 100);
                    response.Origen = origen[rnd];
                    response.imagen = classes.procesa_imagen.toByteArray(img);
                    response.valor_trazable = "Valor Trazable " + new Random().Next(1, 100);
                }
                //*******************************

                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}