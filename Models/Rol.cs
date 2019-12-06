using System;
using System.Collections.Generic;

namespace angular.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Usuariorol = new HashSet<Usuariorol>();
        }

        public int Id { get; set; }
        public string Nombrerol { get; set; }

        public virtual ICollection<Usuariorol> Usuariorol { get; set; }
    }
}
