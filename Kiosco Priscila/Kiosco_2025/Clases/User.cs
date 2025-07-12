using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosco_2025.Clases
{
    internal class User
    {
        public int id_usuario;
        public string username;
        public string password;
        public string rol;


        public User setUsuario(int id_usuario, string username, string password, string rol)
        {
            User user = new User();
            user.id_usuario = id_usuario;
            user.username = username;
            user.password = password;
            user.rol = rol;
            return user;
        }
    }
}