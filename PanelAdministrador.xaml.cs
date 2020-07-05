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

        bool data_grid_vacio;

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
            btnMostrarAdmin.IsEnabled = false;
            gridEleccionAlumnosMateria.Visibility = Visibility.Visible;
            gridOpcionesAlumno.Visibility = Visibility.Visible;
            gridEditorDatos.Visibility = Visibility.Visible;
            dataGridInfo.ItemsSource = null;
            data_grid_vacio = true;
            //Si es uno es porque ya se cargaron las carreras. Si es 0 es porque se acaba de cambiar el dpto
            if (controlCambiosCarrera == 1)
            {
                int numCarrera = comboBoxCarrerasAdmin.SelectedIndex;
                id_carrera = carreras[numCarrera].Id;
            }
            comboBoxEleccionAlumnosMateriasAdmin.SelectedItem = null;
            DesabilitarTodosLosBotones();
        }

        private void comboBoxDptosAdmin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            id_dpto = (comboBoxDptosAdmin.SelectedIndex) + 1;
            elemento_mostrar = 1;
            controlCambiosCarrera = 0;
            ComboBoxCarreras();
            gridCarrerasAdmin.Visibility = Visibility.Visible;
            gridEditorDatos.Visibility = Visibility.Visible;
            dataGridInfo.ItemsSource = null;
            data_grid_vacio = true;
            btnMostrarAdmin.IsEnabled = true;
            DesabilitarTodosLosBotones();
        }

        private void comboBoxEleccionAlumnosMateriasAdmin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataGridInfo.ItemsSource = null;
            btnMostrarAdmin.IsEnabled = true;
            data_grid_vacio = true;
            elemento_mostrar = (comboBoxEleccionAlumnosMateriasAdmin.SelectedIndex) + 2; // 2=si es alumnos 3=materia
            if (elemento_mostrar == 2) 
            {
                btnInscribirse.IsEnabled = true;
                alumnos = manejoDeDatos.GetAlumnos(id_carrera);
                gridEditorDatos.Visibility = Visibility.Hidden;
            }
            else
            {
                gridEditorDatos.Visibility = Visibility.Visible;
                materias = manejoDeDatos.GetMaterias(id_carrera);
                DesabilitarTodosLosBotones();
            }
                
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (data_grid_vacio) return;
            var row = dataGridInfo.SelectedItem;
            switch (elemento_mostrar)
            {
                case 1:
                    Carrera carrera = (Carrera)row;
                    if (carrera != null) 
                    { 
                        txtNombreAdmin.Text = carrera.Nombre;
                        btnAdminEliminar.IsEnabled = true;
                        btnAdminActualizar.IsEnabled = true;
                    }
                    
                    break;
                case 2:
                    btnEliminarAlumno.IsEnabled = true;
                    break;
                case 3: 
                    Materia materia = (Materia)row;
                    if (materia != null) 
                    {
                       txtNombreAdmin.Text = materia.Nombre; 
                       btnAdminEliminar.IsEnabled = true;
                       btnAdminActualizar.IsEnabled = true;
                    } 
                    break;
            }
            
        }

        private void btnMostrarAdmin_Click(object sender, RoutedEventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            data_grid_vacio = true;
            switch (elemento_mostrar)
            {
                case 1:
                    if (departamentos != null)
                    {
                        dataGridInfo.ItemsSource = carreras;
                        data_grid_vacio = false;
                    }
                    else
                        dataGridInfo.ItemsSource = null;
                    break;
                case 2:
                    if (carreras != null)
                    {
                        dataGridInfo.ItemsSource = alumnos;
                        data_grid_vacio = false;
                    }
                    else
                        dataGridInfo.ItemsSource = null;
                    break;
                case 3:
                    if (materias != null)
                    {
                        dataGridInfo.ItemsSource = materias;
                        data_grid_vacio = false;
                    }
                    else
                        dataGridInfo.ItemsSource = null;
                    break;

            }
        }
        private void btnAdminAgregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarDatoAlaBaseDeDatos();
            ActualizarDataGrid();
        }

        private void btnAdminActualizar_Click(object sender, RoutedEventArgs e)
        {
            var row = dataGridInfo.SelectedItem;
            switch (elemento_mostrar)
            {
                case 1:
                    Carrera carrera = (Carrera)row;
                    carrera.Nombre = txtNombreAdmin.Text;
                    manejoDeDatos.ActualizarCarrera(carrera);
                    break;
                case 3:
                    Materia materia = (Materia)row;
                    materia.Nombre = txtNombreAdmin.Text;
                    manejoDeDatos.ActualizarMateria(materia);
                    break;
            }
            txtNombreAdmin.Text = "";
            txtDondeAgrego.Text = "";
            ActualizarDataGrid();
        }

        private void btnAdminEliminar_Click(object sender, RoutedEventArgs e)
        {
            var row = dataGridInfo.SelectedItem;
            int id;
            switch (elemento_mostrar)
            {
                case 1:
                    Carrera carrera = (Carrera)row;
                    id = carrera.Id;
                    manejoDeDatos.EliminarCarrera(id);
                    break;
                case 3:
                    Materia materia = (Materia)row;
                    id = materia.Id;
                    manejoDeDatos.EliminarMateria(id);
                    break;
            }
            txtNombreAdmin.Text = "";
            txtDondeAgrego.Text = "";
            ActualizarDataGrid();
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

        private void btnEliminarAlumno_Click(object sender, RoutedEventArgs e)
        {
            var row = dataGridInfo.SelectedItem;
            if (row != null && elemento_mostrar == 2)
            { 
                Alumno alumno = (Alumno)row;
                int alumno_id = alumno.Dni;
                manejoDeDatos.EliminarAlumno(alumno_id);
            }
            ActualizarDataGrid();
        }

        private void DesabilitarTodosLosBotones()
        {
            btnAdminActualizar.IsEnabled = false;
            btnAdminEliminar.IsEnabled = false;
            btnEliminarAlumno.IsEnabled = false;
            btnInscribirse.IsEnabled = false;
            txtNombreAdmin.Text = "";
            txtDondeAgrego.Text = "";
        }
    }
}
