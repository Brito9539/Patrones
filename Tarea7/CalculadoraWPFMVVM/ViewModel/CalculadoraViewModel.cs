using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CalculadoraWPFMVVM.Model;


namespace CalculadoraWPFMVVM.ViewModel
{
    public class CalculadoraViewModel : ViewModelBase
    {
        private ModeloOperaciones obj = new ModeloOperaciones();

        public string operador1
        {
            get { return obj.Operador1; }
            set { obj.Operador1 = value; }
        }
        public string operador2
        {
            get { return obj.Operador2; }
            set { obj.Operador2 = value; }
        }
        public string operacion
        {
            get { return obj.Operacion; }
            set { obj.Operacion = value; }
        }
        public string resultado
        {
            get { return obj.Resultado; }
            set { obj.Resultado = value; }
        }
        public string display
        {
            get { return display; }
            set { display = value; }
        }
        public void apretarBoton(string boton)
        {
            switch(boton)
            {
                case "+":
                    display = operador1 + " + " + operador2;
                    break;
                case "-":
                    display = operador1 + " + " + operador2;
                    break;
                case "*":
                    display = operador1 + " + " + operador2;
                    break;
                case "=":
                    display = resultado;
                    break;


            }
        }
    }
}
