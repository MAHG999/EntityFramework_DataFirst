using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleDataFirst.Models
{
    public partial class GestoresDb
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Lanzamiento { get; set; }
        public string Desarrollador { get; set; }
    }
}
