using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.IO.Ports;
using System.Threading;
using Demonio.proxyWsSensores;

namespace Demonio
{
    public class Program
    {
        static ServicioSensoresSoapClient wsSensores = new ServicioSensoresSoapClient();
        static SerialPort serialPort;

        static void Main(string[] args)
        {
            serialPort = new SerialPort();
            serialPort.PortName = "COM5";
            serialPort.BaudRate = 9600;
            serialPort.Open();

            RegistroSensoresEntidad registroSensoresEntidad = new RegistroSensoresEntidad();

            while (true)
            {
                string mensajeEntrada = serialPort.ReadLine();
                var tramaDatos = mensajeEntrada.Split(',');
                registroSensoresEntidad.Temperatura = Convert.ToSingle(tramaDatos[0]);
                registroSensoresEntidad.Humedad = Convert.ToSingle(tramaDatos[1]);
                registroSensoresEntidad.CO2 = Convert.ToSingle(tramaDatos[2]);
                registroSensoresEntidad.PresionAtmosferica = Convert.ToSingle(tramaDatos[3]);

                wsSensores.Guardar(registroSensoresEntidad);

                //Console.WriteLine(mensajeEntrada);
            }
        }
    }
}
