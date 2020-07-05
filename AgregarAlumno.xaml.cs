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
    /// Interaction logic for AgregarAlumno.xaml
    /// </summary>
    public partial class AgregarAlumno : Window
    {
        public int Id_carrera_windowAlumno { get; set; }
        public Alumno MiAlumno { get; set; }
        public bool Actualizar { get; set; }//Esta variable se utilizara para saber si es necesario actualizar o agregar al alumno

        public AgregarAlumno()
        { 
            InitializeComponent();
        }
        private void ActualizarAlumno()
        {
            if (!Actualizar) return;
            txtDniAlumno.Text = MiAlumno.Dni.ToString();
            txtNombreAlumno.Text = MiAlumno.Nombre;
            txtApellidoAlumno.Text = MiAlumno.Apellido;
            comboBoxGenero.SelectedItem = MiAlumno.Genero;
            fechaNacimientoCalendario.SelectedDate = MiAlumno.FechaNacimiento;

        }
        private void CargarNuevoAlumno()
        {
            Alumno alumno = new Alumno
            {
                Dni = int.Parse(txtDniAlumno.Text),
                Apellido = txtApellidoAlumno.Text,
                Nombre = txtNombreAlumno.Text,
                Genero = Convert.ToString(comboBoxGenero.Text),
                FechaNacimiento = (DateTime)fechaNacimientoCalendario.SelectedDate,
                Id_carrera = Id_carrera_windowAlumno,
            };
            ManejoDeDatos manejoDeDatos = new ManejoDeDatos();
            if (!Actualizar)
                manejoDeDatos.InsertarAlumno(alumno);
            else
               manejoDeDatos.ActualizarAlumno(alumno);
        }

        private void btnAgregarAlumno_Click(object sender, RoutedEventArgs e)
        {
            CargarNuevoAlumno();
            this.Close();
        }

        private void btnCancelarAlumno_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            ActualizarAlumno();
        }
    }
}
