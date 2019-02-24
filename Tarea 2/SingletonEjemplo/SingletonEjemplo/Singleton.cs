using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonEjemplo
{
    public partial class Singleton : Form
    {
        private static Singleton instance = null;
        public Singleton()
        {
            InitializeComponent();
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        private void Singleton_Load(object sender, EventArgs e)
        {

        }

      
    }
}


