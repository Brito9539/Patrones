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
using Tarea10.Model;

namespace Tarea10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Name = "Hola mundo";
        public MainWindow()
        {
            InitializeComponent();
            MyModelObject button1DataContext = new MyModelObject() { Name = "Soy el boton 1" };
            MyModelObject button2DataContext = new MyModelObject() { BadName = "Soy el boton 12" };

            boton1.DataContext = button1DataContext;
            boton2.DataContext = button2DataContext;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainGridPanel.Background = Brushes.Purple;
        }
    }
}
