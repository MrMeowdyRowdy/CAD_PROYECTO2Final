using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_PROYECTO2.Models
{
    public  class Usuario
    {
        public string name { get; set; }

        public string Passw { get; set; }

        public Usuario(string name, string password)
        {
            this.name = name;
            this.Passw = password;
        }


    }
    
    
    
}
