using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RegistroSensoresEntidad
    {
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public float Temperatura { get; set; }
        public float Humedad { get; set; }
        public float CO2 { get; set; }
        public float PresionAtmosferica { get; set; }

        public RegistroSensoresEntidad()
        {

        }

        public RegistroSensoresEntidad(int id, DateTime fechaRegistro, float temperatura, float humedad, float cO2, float presionAtmosferica)
        {
            Id = id;
            FechaRegistro = fechaRegistro;
            Temperatura = temperatura;
            Humedad = humedad;
            CO2 = cO2;
            PresionAtmosferica = presionAtmosferica;
        }
    }
}
