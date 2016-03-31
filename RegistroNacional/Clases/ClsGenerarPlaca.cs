using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroNacional.Clases
{
    class ClsGenerarPlaca
    {
        public String NombreCompleto;
        public string cedula;
        private String Nombre;
        private String Apellido1;
        private String Apellido2;
        private String ResultadoGenerado;

        /// <summary>
        /// Genera la placa a base del Nombre Completo y los últimos 3 digitos de la cédula.
        /// </summary>
        /// <returns></returns>

        public string GenerarPlaca()
        {
            int posicion;

            posicion = NombreCompleto.IndexOf(" ");
            Nombre = NombreCompleto.Substring(0, posicion);

            NombreCompleto = NombreCompleto.Substring(posicion + 1);
            posicion = NombreCompleto.IndexOf(" ");
            Apellido1 = NombreCompleto.Substring(0, posicion);

            Apellido2 = NombreCompleto.Substring(posicion + 1);

            ResultadoGenerado = Nombre[0].ToString() + Apellido1[0].ToString() + Apellido2[0].ToString() + cedula.Substring(7, 3);

            return ResultadoGenerado;
        }

    }



    
}
