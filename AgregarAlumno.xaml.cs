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
        public AgregarAlumno()
        {
            InitializeComponent();
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
            manejoDeDatos.InsertarAlumno(alumno);
        }

        private void btnAgregarAlumno_Click(object sender, RoutedEventArgs e)
        {
            CargarNuevoAlumno();
            MessageBox.Show("Agregado Correctamente");
            this.Close();
        }

        private void btnCancelarAlumno_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
