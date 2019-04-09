using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tarea11_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotonAfuera_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("Boton de afuera clic");
        }

        private void BotonAdentro_Click(object sender, RoutedEventArgs e)
        {
          ///  this.Title = "Titulo otro";
        }

        private void BotonAfuera_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            label1.Content = label1.Content + "Boton de Afuera ";
        }

        private void BotonAdentro_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            label1.Content = label1.Content + "Boton de Adentro ";
        }
    }
}
