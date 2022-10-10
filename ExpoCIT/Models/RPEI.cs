namespace ExpoCIT.Models
{
    public class RPEI : Auditable
    {
        public int Id { get; set; }

        public int I_a { get; set; }
        public int I_b { get; set; }
        public int I_c { get; set; }
        public int I_d { get; set; }
        public int I_e { get; set; }
        public int I_subtotal { get; set; }

        public int II_a { get; set; }
        public int II_b { get; set; }
        public int II_c { get; set; }
        public int II_d { get; set; }
        public int II_e { get; set; }
        public int II_f { get; set; }
        public int II_subtotal { get; set; }

        public int III_a { get; set; }
        public int III_b { get; set; }
        public int III_c { get; set; }
        public int III_d { get; set; }
        public int III_e { get; set; }
        public int III_subtotal { get; set; }

        public int IV_a { get; set; }
        public int IV_b { get; set; }
        public int IV_c { get; set; }
        public int IV_d { get; set; }
        public int IV_e { get; set; }
        public int IV_f { get; set; }
        public int IV_subtotal { get; set; }

        public int V_a { get; set; }
        public int V_b { get; set; }
        public int V_c { get; set; }
        public int V_d { get; set; }
        public int V_e { get; set; }
        public int V_f { get; set; }
        public int V_subtotal { get; set; }

        public int VI_a { get; set; }
        public int VI_b { get; set; }
        public int VI_c { get; set; }
        public int VI_d { get; set; }
        public int VI_e { get; set; }
        public int VI_f { get; set; }
        public int VI_g { get; set; }
        public int VI_h { get; set; }
        public int VI_subtotal { get; set; }

        public int VII_a { get; set; }
        public int VII_b { get; set; }
        public int VII_c { get; set; }
        public int VII_d { get; set; }
        public int VII_e { get; set; }
        public int VII_f { get; set; }
        public int VII_subtotal { get; set; }

        public int VIII_a { get; set; }
        public int VIII_b { get; set; }
        public int VIII_c { get; set; }
        public int VIII_d { get; set; }
        public int VIII_subtotal { get; set; }

        public string DG { get; set; }

        public byte[] FirmaDigital { get; set; }
        public Proyecto Proyecto { get; set; }
    }
}
