using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraWPFMVVM.Model
{
    public class ModeloOperaciones
    {
        public string Operador1 { get; set; }
        public string Operador2 { get; set; }
        public string Resultado { get; set; }
        public string Operacion { get; set; }

        public ModeloOperaciones(string operador1, string operador2, string operacion)
        {
            Operador1 = operador1;
            Operador2 = operador2;
            Operacion = operacion;
        }
        public ModeloOperaciones()
        {

        }

        public void Calcular()
        {
            try
            {
                switch(Operacion)
                {
                    case "+":
                        Resultado = (Convert.ToInt32(Operador1) + Convert.ToInt32(Operador2)).ToString();
                        break;
                    case "-":
                        Resultado = (Convert.ToInt32(Operador1) - Convert.ToInt32(Operador2)).ToString();
                        break;
                    case "*":
                        Resultado = (Convert.ToInt32(Operador1) * Convert.ToInt32(Operador2)).ToString();
                        break;
                }
            }
            catch
            {
                Resultado = "No hay";
            }
        }

    }
}
