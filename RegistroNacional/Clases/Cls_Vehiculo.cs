using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroNacional.Clases
{
    class Cls_Vehiculo
    {
        public string nombre;
        public string apellido;
        public string cedula;
        public int annio;
        public double valorFiscal;
        private double ResultadoAntiguedad;
        private double ResultadoMarchamo;

        /// <summary>
        /// Muestra la diferencia del año actual entre el año del vehículo.
        /// </summary>
        /// <param name="Calcular Antiguedad del Vehiculo"></param>
        /// <returns></returns>
        /// 
        public double calcularAntiguedad(int año)
        {
            
            int anno = (System.DateTime.Today.Year);
            int Antiguedad = anno - año;

            if (Antiguedad < 1)
            {
                ResultadoAntiguedad = 0.05;
            } else if (Antiguedad >= 1 && Antiguedad < 3)
            {
                ResultadoAntiguedad = 0.04;
            } else if (Antiguedad >= 3 && Antiguedad < 5)
            {
                ResultadoAntiguedad = 0.03;
            } else if (Antiguedad > 5)
            {
                ResultadoAntiguedad = 0.02;
            }

            return ResultadoAntiguedad;
        }

        /// <summary>
        /// Calcula con base a la Antiguedad del Vehiculo, el Marchamo a pagar a final de año.
        /// </summary>
        /// <returns></returns>

        public double calculoMarchamo()
        {

            ResultadoMarchamo = valorFiscal * this.ResultadoAntiguedad;

            return ResultadoMarchamo;
        }



    }
}
