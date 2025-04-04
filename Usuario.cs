using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggin
{
    internal class Usuario
    {
        private static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario{NombreUsuario = "Admin", Contraseña = "1234" },
            new Usuario{NombreUsuario = "Isaac", Contraseña = "Guppy1" },
            new Usuario{NombreUsuario = "Siffrin", Contraseña = "Isabeau" },
            new Usuario{NombreUsuario = "Erin", Contraseña = "Mrsha" }
        };

        public Usuario(string nombreUsuario, string contraseña)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
        }

        public List<Usuario> Obtenerusuarios()
        {
            return usuarios;
        }

        public Usuario() { }

        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
    }
}
