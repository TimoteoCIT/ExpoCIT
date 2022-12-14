namespace ExpoCIT.Models
{
    public enum TipoProyecto
    {
        ExpoIngenieria,
        ExpoJovem
    }

    public class Proyecto : Auditable
    {
        public int Id { get; set; }

        public string NumStand { get; set; }
        public string Nombre { get; set; }
        public string Integrantes { get; set; }
        public TipoProyecto TipoProyecto { get; set; }
        public Juez? Juez { get; set; }
    }
}
