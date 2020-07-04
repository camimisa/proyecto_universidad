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
    /// Interaction logic for PanelVisitante.xaml
    /// </summary>
    public partial class PanelVisitante : Window
    {
        private int id_dpto;

        private int id_carrera;

        int controlCambiosCarrera = 0; 

        List<Carrera> carreras; //Necesito hacerla global porque necesito obtener su id constantemente

        private ManejoDeDatos manejoDeDatos;
        public PanelVisitante()
        {
            InitializeComponent();
            ComboBoxDepartamentos();
        }

        private void ComboBoxDepartamentos()
        {
            manejoDeDatos = new ManejoDeDatos();
            List <Departamento> departamentos = manejoDeDatos.GetDepartamentos();
            comboBoxDptos.ItemsSource = departamentos;
        }

        private void ComboBoxCarreras()
        {
            manejoDeDatos = new ManejoDeDatos();
            carreras = manejoDeDatos.GetCarreras(id_dpto);
            comboBoxCarreras.ItemsSource = carreras;
            controlCambiosCarrera = 1;
            
        }

        private void ComboBoxMaterias()
        {
            manejoDeDatos = new ManejoDeDatos();
            List<Materia> materias = manejoDeDatos.GetMaterias(id_carrera);
            comboBoxMaterias.ItemsSource = materias;
        }

        private void comboBoxDptos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   
            id_dpto = (comboBoxDptos.SelectedIndex)+1;
            controlCambiosCarrera = 0;
            ComboBoxCarreras();
            gridCarreras.Visibility = Visibility.Visible;
            
        }

        private void comboBoxCarreras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridMaterias.Visibility = Visibility.Visible;
            gridOpcion.Visibility = Visibility.Visible;
            //Obtener id y llamar a comboBoxMaterias
            //Necesito obtener el id de la carrera para poder pasarselo a la materia pero no me sale:(
            //Si es uno es porque ya se cargaron las carreras. Si es 0 es porque se acaba de cambiar el dpto
            if (controlCambiosCarrera == 1) { 
            int numCarrera = comboBoxCarreras.SelectedIndex;
            id_carrera = carreras[numCarrera].Id;
            ComboBoxMaterias();
            }
        }
        private void btnInscribirse_Click(object sender, RoutedEventArgs e)
        {
            AgregarAlumno agregarAlumno = new AgregarAlumno();
            agregarAlumno.Id_carrera_windowAlumno = id_carrera;
            agregarAlumno.Show();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
