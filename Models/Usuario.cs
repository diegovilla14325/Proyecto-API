using System;
using System.Collections.Generic;

namespace angular.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Post = new HashSet<Post>();
            Usuariorol = new HashSet<Usuariorol>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string UsuarioId { get; set; }
        public string Contraseña { get; set; }

        public virtual ICollection<Post> Post { get; set; }
        public virtual ICollection<Usuariorol> Usuariorol { get; set; }
    }
}
