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

namespace proyectUniversidad
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

        private void btnAdministrador_Click(object sender, RoutedEventArgs e)
        {
            pedirClaveAdmin pedirClaveAdmin = new pedirClaveAdmin();
            pedirClaveAdmin.Show();
        }

        private void btnVisitante_Click(object sender, RoutedEventArgs e)
        {
            PanelVisitante panelVisitante = new PanelVisitante();
            panelVisitante.Show();
        }
    }
}
