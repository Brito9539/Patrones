using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace WPF_CRUD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private void CargarDatos()
        {
            MySqlConnection cn;
            cn = Conexion.conectar();
            MySqlCommand cmd = new MySqlCommand("Select * From alumno ", cn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cn.Close();
            dtGrid.DataContext = dt;
        }

        public MainWindow()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            Window1 AgregarWindow = new Window1();            
            AgregarWindow.Show();
            this.Close();
        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            Editar EditarWindows = new Editar();
            EditarWindows.Show();
            this.Close();
        }

        private void DtGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            Eliminar EliminarWindow = new Eliminar();
            EliminarWindow.Show();
            this.Close();
        }
    }
}
