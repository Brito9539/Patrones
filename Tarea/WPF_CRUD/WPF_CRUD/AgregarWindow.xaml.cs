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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
       
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection cn;
        
        public Window1()
        {
            InitializeComponent();
            cn = Conexion.conectar();
            cmd.Connection = cn;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cmd.CommandText = "INSERT INTO alumno(Matricula, Nombre, Ap_Materno, Ap_Paterno) VALUES('" + txtMatricula.Text + "','" + txtNombre.Text + "','" + txtApMaterno.Text + "','" + txtApPaterno.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Alumno registrado correctamente");
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
          
        }
    }
}
