namespace CRUD_SegurosMVC.Models
{
    public class Poliza
    {
        public int Id { get; set; }
        public string NumeroPoliza { get; set; }
        public string Cliente { get; set; }
        public string TipoSeguro { get; set; }
        public decimal MontoAsegurado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
