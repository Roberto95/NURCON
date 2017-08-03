using BusinessEntities.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AdministradorDAL
    {
        public static NURCONDbContext db = new NURCONDbContext();

        public static bool iniciarSesionUs(string us)
        {
            return db.Administradores.Where(a => a.NombreUsuario== us).Count() > 0;
        }

        public static bool iniciarSesionPass(string pass)
        {
            return db.Administradores.Where(a => a.Password_ == pass).Count() > 0;
        }

    }
}
