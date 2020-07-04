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
    /// Interaction logic for PanelAdministrador.xaml
    /// </summary>
    public partial class PanelAdministrador : Window
    {
        private ManejoDeDatos manejoDeDatos;

        private int id_dpto;

        private int id_carrera;

        int controlCambiosCarrera = 0;

        int elemento_mostrar = 0; // Data Grid 1=Muestro carrera 2=Alumnos 3=Materias

        List<Carrera> carreras; //Necesito hacerla global porque necesito obtener su id constantemente

        List<Departamento> departamentos;

        List<Alumno> alumnos;
        List<Materia> materias;
        public PanelAdministrador()
        {
            InitializeComponent();
            ComboBoxDepartamentos();
        }

        private void AgregarDatoAlaBaseDeDatos()
        {

            switch (elemento_mostrar)
            {
                case 1:
                    Carrera carrera = new Carrera {
                        Id_dpto = id_dpto,
                        Nombre = txtNombreAdmin.Text,
                    };
                    manejoDeDatos.InsertarCarrera(carrera);
                    break;
                case 3:
                    Materia materia = new Materia
                    {
                        Id_carrera = id_carrera,
                        Nombre = txtNombreAdmin.Text,
                    };
                    manejoDeDatos.InsertarMateria(materia);
                    break;

            }
            txtDondeAgrego.Text = "";
            txtNombreAdmin.Text = "";
        }

        private void ComboBoxDepartamentos()
        {
            manejoDeDatos = new ManejoDeDatos();
            departamentos = manejoDeDatos.GetDepartamentos();
            comboBoxDptosAdmin.ItemsSource = departamentos;
        }

        private void ComboBoxCarreras()
        {
            manejoDeDatos = new ManejoDeDatos();
            carreras = manejoDeDatos.GetCarreras(id_dpto);
            comboBoxCarrerasAdmin.ItemsSource = carreras;
            controlCambiosCarrera = 1;

        }

        private void comboBoxCarrerasAdmin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridEleccionAlumnosMateria.Visibility = Visibility.Visible;
            gridOpcionesAlumno.Visibility = Visibility.Visible;
            //Si es uno es porque ya se cargaron las carreras. Si es 0 es porque se acaba de cambiar el dpto
            if (controlCambiosCarrera == 1)
            {
                int numCarrera = comboBoxCarrerasAdmin.SelectedIndex;
                id_carrera = carreras[numCarrera].Id;
            }
            comboBoxEleccionAlumnosMateriasAdmin.SelectedItem = null;
            btnInscribirse.IsEnabled = false;
        }

        private void comboBoxDptosAdmin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            id_dpto = (comboBoxDptosAdmin.SelectedIndex) + 1;
            elemento_mostrar = 1;
            controlCambiosCarrera = 0;
            ComboBoxCarreras();
            gridCarrerasAdmin.Visibility = Visibility.Visible;
            gridEditorDatos.Visibility = Visibility.Visible;
            btnInscribirse.IsEnabled = false;
        }

        private void comboBoxEleccionAlumnosMateriasAdmin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            elemento_mostrar = (comboBoxEleccionAlumnosMateriasAdmin.SelectedIndex) + 2; // 3=si es alumnos 4=materia
            if (elemento_mostrar == 2) 
            {
                btnInscribirse.IsEnabled = true;
                alumnos = manejoDeDatos.GetAlumnos(id_carrera);
            }
            else
                materias = manejoDeDatos.GetMaterias(id_carrera);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnMostrarAdmin_Click(object sender, RoutedEventArgs e)
        {   
            switch (elemento_mostrar)
            {
                case 1:
                    if (departamentos != null)
                        dataGridInfo.ItemsSource = carreras;
                    else
                        dataGridInfo.ItemsSource = null;
                    break;
                case 2:
                    if (carreras != null)
                        dataGridInfo.ItemsSource = alumnos;
                    else
                        dataGridInfo.ItemsSource = null;
                    break;
                case 3:
                    if (alumnos != null)
                        dataGridInfo.ItemsSource = materias;
                    else
                        dataGridInfo.ItemsSource = null;
                    break;

            }
        }

        private void btnAdminAgregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarDatoAlaBaseDeDatos();
        }

        private void btnAdminActualizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdminEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnInscribirse_Click(object sender, RoutedEventArgs e)
        { 
            AgregarAlumno agregarAlumno = new AgregarAlumno();
            agregarAlumno.Id_carrera_windowAlumno = id_carrera;
            var row = dataGridInfo.SelectedItem;
            if (row!=null && elemento_mostrar==2) { //HAY QUE EDITAR O ELIMINAR EL ALUMNO
                Alumno alumno = (Alumno)row;
                agregarAlumno.Actualizar = true;
                agregarAlumno.MiAlumno = alumno;
            }
            else //HAY QUE CREAR EL ALUMNO DE CERO
            {
                agregarAlumno.Actualizar = false;
            }
            agregarAlumno.Show();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtNombreAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (elemento_mostrar)
            {
                case 1:
                    txtDondeAgrego.Text = "Departamento " + departamentos[comboBoxDptosAdmin.SelectedIndex].Nombre;
                    break;
                case 3:
                    txtDondeAgrego.Text = "Carrera " + carreras[comboBoxCarrerasAdmin.SelectedIndex].Nombre;
                    break;
            }
        }
    }
}
