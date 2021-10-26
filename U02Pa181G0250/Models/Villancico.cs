using System;
using System.Collections.Generic;

#nullable disable

namespace U02Pa181G0250.Models
{
    public partial class Villancico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Compositor { get; set; }
        public int? Anyo { get; set; }
        public string Idioma { get; set; }
        public string Información { get; set; }
        public string Letra { get; set; }
        public string VideoUrl { get; set; }
    }
}
