using System.ComponentModel.DataAnnotations.Schema;

namespace ActualizacionTablas.Padron
{
    [Table("PadronAFIP-OCT")]

    public class RegistroPadron
    {
        public int Id { get; set; }
        public string NroIdentificacion { get; set; }
        public string Denominacion { get; set; }
        public string Actividad { get; set; }
        public string MarcaDeBaja { get; set; }
        public string NumIdentificacionDeReemplazo { get; set; }
        public string Fallecimiento { get; set; }
    }
}