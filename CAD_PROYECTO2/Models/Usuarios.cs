
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_PROYECTO2.Models
{
   
     public static class Usuarios
    {

        public static List<Usuario> Users  = new List<Usuario>();

        public static void Loadsuarios(Usuario usuario) => Users.Add(usuario);
        
        public  static bool SearchUsers(Usuario usuarioP)
        {
            
            foreach (Usuario usuario in Users)
            {   
                if(usuarioP.name == usuario.name && usuarioP.Passw==usuario.Passw)
                {
                    return true;
                }
            }
                return false;
         }
           
     }

  
    
}
