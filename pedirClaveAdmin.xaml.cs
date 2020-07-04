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

namespace proyectUniversidad
{
    /// <summary>
    /// Interaction logic for pedirClaveAdmin.xaml
    /// </summary>
    public partial class pedirClaveAdmin : Window
    {
        private string miClave;
        public pedirClaveAdmin()
        {
            InitializeComponent();
            miClave = "admin1234";
        }

        private void btnClaveAceptar_Click(object sender, RoutedEventArgs e)
        {
            string claveIngresada = claveAdminTxt.Password.ToString();
            MessageBox.Show(claveIngresada);

            if(claveIngresada == miClave)
            {
                PanelAdministrador panelAdministrador = new PanelAdministrador();
                panelAdministrador.Show();
            }
            else MessageBox.Show("Clave incorrecta\nIntentelo de nuevo o pulse cancelar.");
        }

        private void btnClaveCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
