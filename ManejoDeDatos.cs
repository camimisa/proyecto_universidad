using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace proyectUniversidad
{
    class ManejoDeDatos
    {
        private SqlConnection connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=Universidad;Data Source=CAMILA");

        #region TABLA DEPARTAMENTOS

        public List<Departamento> GetDepartamentos()
        {
            List<Departamento> listaDepartamentos = new List<Departamento>();
            try
            {
                connection.Open();
                string query = "SELECT id,nombre FROM DEPARTAMENTOS";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listaDepartamentos.Add(new Departamento
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        Nombre = reader["nombre"].ToString()
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            return listaDepartamentos;
        }

        #endregion

        #region TABLA CARRERAS

        public void InsertarCarrera(Carrera carrera)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO CARRERAS (id_dpto,nombre) VALUES (@id_dpto,@nombre)";

                SqlParameter idDpto = new SqlParameter("@id_dpto", carrera.Id_dpto);
                SqlParameter nombre = new SqlParameter("@nombre", carrera.Nombre);
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(idDpto);
                command.Parameters.Add(nombre);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Carrera> GetCarreras(int idDpto)
        {
            List<Carrera> listaCarreras = new List<Carrera>();
            string query;
            try
            {
                connection.Open();
                if(idDpto==0) query = "SELECT id,id_dpto,nombre FROM CARRERAS";
                else query = "SELECT * FROM CARRERAS INNER JOIN DEPARTAMENTOS ON DEPARTAMENTOS.id = CARRERAS.id_dpto where id_dpto=" + idDpto;
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listaCarreras.Add(new Carrera
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        Id_dpto = int.Parse(reader["id_dpto"].ToString()),
                        Nombre = reader["nombre"].ToString()
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            return listaCarreras;
        }


        #endregion

        #region TABLA MATERIAS

        public void InsertarMateria(Materia materia)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO MATERIAS (id_carrera,nombre) VALUES (@id_carrera,@nombre)";

                SqlParameter idCarrera = new SqlParameter("@id_carrera", materia.Id_carrera);
                SqlParameter nombre = new SqlParameter("@nombre", materia.Nombre);
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(idCarrera);
                command.Parameters.Add(nombre);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Materia> GetMaterias(int idCarrera)
        {
            List<Materia> listaMaterias = new List<Materia>();
            string query;
            try
            {
                connection.Open();
                //if (idCarrera == 0) query = "SELECT * FROM MATERIAS";
                //else 
                query = "SELECT * FROM MATERIAS INNER JOIN CARRERAS ON CARRERAS.id = MATERIAS.id_carrera where id_carrera=" + idCarrera;

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listaMaterias.Add(new Materia
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        Id_carrera = int.Parse(reader["id_carrera"].ToString()),
                        Nombre = reader["nombre"].ToString()
                    });
                }
      

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return listaMaterias;
        }

        #endregion

        #region TABLA ALUMNOS
        public void InsertarAlumno(Alumno alumno)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO ALUMNOS (dni,id_carrera,nombre,apellido,genero,fechaNacimiento) VALUES (@dni,@id_carrera,@nombre,@apellido,@genero,@fechaNacimiento)";

                SqlParameter idCarrera = new SqlParameter("@id_carrera", alumno.Id_carrera);
                SqlParameter dni = new SqlParameter("@dni", alumno.Dni);
                SqlParameter nombre = new SqlParameter("@nombre", alumno.Nombre);
                SqlParameter apellido = new SqlParameter("@apellido", alumno.Apellido);
                SqlParameter genero = new SqlParameter("@genero", alumno.Genero);
                SqlParameter fechaNacimiento = new SqlParameter("@fechaNacimiento", alumno.FechaNacimiento);
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(idCarrera);
                command.Parameters.Add(nombre);
                command.Parameters.Add(dni);
                command.Parameters.Add(apellido);
                command.Parameters.Add(genero);
                command.Parameters.Add(fechaNacimiento);
      
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Alumno> GetAlumnos(int idCarrera)
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            try
            {
                connection.Open();
                string query = "SELECT * FROM ALUMNOS INNER JOIN CARRERAS ON CARRERAS.id = ALUMNOS.id_carrera where id_carrera=" + idCarrera;

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listaAlumnos.Add(new Alumno
                    {
                        Dni = int.Parse(reader["dni"].ToString()),
                        Id_carrera = int.Parse(reader["id_carrera"].ToString()),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        Genero = reader["genero"].ToString(),
                        FechaNacimiento=DateTime.Parse(reader["fechaNacimiento"].ToString())
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            return listaAlumnos;
        }
        #endregion

        #region TABLA ALUMNOS MATERIAS
        #endregion
    }
}

