using BusinessEntities.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataAccessLayer
{
    public class PacienteDAL
    {
        // se agregaron los Paquetes Nuget
        // aqui se conecta la base de datos nurcon con la tabla pacientes
        public static NURCONDbContext db = new NURCONDbContext();

       
        // Metodo para insertar un paciente por LinQ
        public static bool insertar(Paciente p)

        {
            db.Pacientes.Add(p);
            return db.SaveChanges() > 0;
        }

        //Metodo para insertar un paciente por Command
        public static string insertarPorCommand(Paciente p) {
            string cadena = "server=localhost;user=root;database=nurcon;port=3306;password=estadosunidos123";
            string mensaje;
            MySqlConnection conn = new MySqlConnection(cadena);
            try {
                conn.Open();
                string query = "insert into paciente(Nombre_Paciente,Matricula,Sexo,Edad)values('" + p.Nombre_Paciente + "'," + p.Matricula + ",'" + p.Sexo + "'," + p.Edad + ");";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                mensaje = "";
            }
            catch(Exception ex) {
                mensaje = ex.ToString();
            }
            conn.Close();
            return mensaje;
        }



        //  este metodo sirve para consultar
        public static List<Paciente> consulta()
        {
            return db.Pacientes.ToList();
        }

       
        // consultar por matricula 

        public static List<Paciente> consultaPormatricula(int mat)
        {
            return db.Pacientes.Where(m => m.Matricula == mat).ToList();
        }

        //metodo de consulta por Id
        public static List<Paciente> consultaPorID(int ma)
        {
            return db.Pacientes.Where(m => m.Id == ma).ToList();
        }

        // metodo para eliminar por medio de la matricula por LinQ
        public static bool eliminar_Pacientes(int ma)
        {
            var query =db.Pacientes.Where(p => p.Matricula == ma).Single();//el single trae la entidad completa con su informacion

            db.Pacientes.Remove(query);
            return db.SaveChanges() > 0;
        }

        //metodo para eliminar por command como parametro la matricula
        public static bool eliminarPorCommand(int m)
        {
            string cadena = "server=localhost;user=root;database=nurcon;port=3306;password=estadosunidos123";
            bool conf;
            MySqlConnection conn = new MySqlConnection(cadena);
            try
            {
                conn.Open();
                string query = "delete from paciente where Matricula="+m+";";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conf = true;
            }
            catch 
            {
                conf = false;
            }
            conn.Close();
            return conf;
        }


        public static bool matRepetida(int mat) {
            return db.Pacientes.Where(m => m.Matricula == mat).Count()>0;
        }

       // metodo para actualizar 
        public static bool actualizar(Paciente p) {
            var pacienteed = db.Pacientes.FirstOrDefault(x => x.Id == p.Id);
            pacienteed.Id = p.Id;
            pacienteed.Matricula = p.Matricula;
            pacienteed.Nombre_Paciente = p.Nombre_Paciente;
            pacienteed.Edad = p.Edad;
            pacienteed.Sexo = p.Sexo;
            return db.SaveChanges() > 0;
        }
        // actualizacion
    }
}
