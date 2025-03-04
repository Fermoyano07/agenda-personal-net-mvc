using System.ComponentModel.DataAnnotations;

namespace Agenda.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public int Numero { get; set;}
        public string Email { get; set;}
        public string Web { get; set; }
    }
}
