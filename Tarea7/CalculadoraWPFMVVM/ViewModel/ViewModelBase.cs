using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;

namespace CalculadoraWPFMVVM.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void CambiaLaPropiedad(string propiedad)
        {
            PropertyChangedEventHandler manejador = PropertyChanged;

            if (manejador != null)
            {
                manejador(this, new PropertyChangedEventArgs(propiedad));
            }
        }
    }
}
