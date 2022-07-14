using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using Entidades;

namespace ServicioWeb
{
    /// <summary>
    /// Descripción breve de ServicioSensores
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioSensores : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public double PotenciaNumeros(double _base, double _exponente)
        {
            return Math.Pow(_base, _exponente);
        }

        [WebMethod]
        public RegistroSensoresEntidad Guardar(RegistroSensoresEntidad registroSensoresEntidad)
        {
            try
            {
                RegistroSensores registroSensoresLinq = new RegistroSensores();
                registroSensoresLinq.fechaRegistro = DateTime.Now;
                registroSensoresLinq.temperatura = registroSensoresEntidad.Temperatura;
                registroSensoresLinq.humedad = registroSensoresEntidad.Humedad;
                registroSensoresLinq.CO2 = registroSensoresEntidad.CO2;
                registroSensoresLinq.presionAtmosferica = registroSensoresEntidad.PresionAtmosferica;

                using (MonitoreoArduinoDataContext contexto = new MonitoreoArduinoDataContext())
                {
                    contexto.RegistroSensores.InsertOnSubmit(registroSensoresLinq);
                    contexto.SubmitChanges();
                }
                registroSensoresEntidad.Id = registroSensoresLinq.id;
                return registroSensoresEntidad;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }
    }
}
