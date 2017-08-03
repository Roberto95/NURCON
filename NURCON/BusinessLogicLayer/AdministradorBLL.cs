using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class AdministradorBLL
    {
        public static bool iniciarSesionUs(string us) {
            return DataAccessLayer.AdministradorDAL.iniciarSesionUs(us);
        }
        public static bool iniciarSesionPass(string pass) {
            return DataAccessLayer.AdministradorDAL.iniciarSesionPass(pass);
        }
    }
}
