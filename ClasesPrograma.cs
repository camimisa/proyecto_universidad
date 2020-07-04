using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectUniversidad
{
    public class Carrera
    {
        public int Id { get; set; }
        public int Id_dpto { get; set; }
        public string Nombre { get; set; }
    }

    public class Departamento
    {
       public int Id { get; set; }
       public string Nombre { get; set; }
    }

    public class Materia
    {
        public int Id { get; set; }
        public int Id_carrera { get; set; }
        public string Nombre { get; set; }
    }

    public class Alumno
    {
        public int Dni { get; set; }
        public int Id_carrera { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}
