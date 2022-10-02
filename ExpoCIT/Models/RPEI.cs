namespace ExpoCIT.Models
{
    public class RPEI : Auditable
    {
        public int Id { get; set; }

        public string I_a { get; set; }
        public string I_b { get; set; }
        public string I_c { get; set; }
        public string I_d { get; set; }
        public string I_e { get; set; }
        public double I_subtotal { get; set; }

        public string II_a { get; set; }
        public string II_b { get; set; }
        public string II_c { get; set; }
        public string II_d { get; set; }
        public string II_e { get; set; }
        public string II_f { get; set; }
        public double II_subtotal { get; set; }

        public string III_a { get; set; }
        public string III_b { get; set; }
        public string III_c { get; set; }
        public string III_d { get; set; }
        public string III_e { get; set; }
        public double III_subtotal { get; set; }

        public string IV_a { get; set; }
        public string IV_b { get; set; }
        public string IV_c { get; set; }
        public string IV_d { get; set; }
        public string IV_e { get; set; }
        public string IV_f { get; set; }
        public double IV_subtotal { get; set; }

        public string V_a { get; set; }
        public string V_b { get; set; }
        public string V_c { get; set; }
        public string V_d { get; set; }
        public string V_e { get; set; }
        public string V_f { get; set; }
        public double V_subtotal { get; set; }

        public string VI_a { get; set; }
        public string VI_b { get; set; }
        public string VI_c { get; set; }
        public string VI_d { get; set; }
        public string VI_e { get; set; }
        public string VI_f { get; set; }
        public string VI_g { get; set; }
        public string VI_h { get; set; }
        public double VI_subtotal { get; set; }

        public string VII_a { get; set; }
        public string VII_b { get; set; }
        public string VII_c { get; set; }
        public string VII_d { get; set; }
        public string VII_e { get; set; }
        public string VII_f { get; set; }
        public double VII_subtotal { get; set; }

        public string VIII_a { get; set; }
        public string VIII_b { get; set; }
        public string VIII_c { get; set; }
        public string VIII_d { get; set; }
        public double VIII_subtotal { get; set; }

        public string DG { get; set; }

        public byte[] FirmaDigital { get; set; }
        public Proyecto Proyecto { get; set; }
    }
}
