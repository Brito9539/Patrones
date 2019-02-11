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
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WPF_CRUD
{
    /// <summary>
    /// Lógica de interacción para Eliminar.xaml
    /// </summary>
    public partial class Eliminar : Window
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection cn;

        public Eliminar()
        {
            InitializeComponent();
            InitializeComponent();
            cn = Conexion.conectar();
            cmd.Connection = cn;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cmd.CommandText = "DELETE FROM alumno WHERE Matricula='" + txtMatricula.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alumno eliminado correctamente.");
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();  
            }
            catch (MySqlException x)
            {
                MessageBox.Show("Error: La matricula no existe.");
            }
        }
    }
}
