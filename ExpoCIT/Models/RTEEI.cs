namespace ExpoCIT.Models
{
    public class RTEEI : Auditable
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
        public double III_subtotal { get; set; }

        public string IV_a { get; set; }
        public string IV_b { get; set; }
        public string IV_c { get; set; }
        public string IV_d { get; set; }
        public string IV_e { get; set; }
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
        public double VI_subtotal { get; set; }

        public string VII_a { get; set; }
        public string VII_b { get; set; }
        public string VII_c { get; set; }
        public string VII_d { get; set; }
        public string VII_e { get; set; }
        public double VII_subtotal { get; set; }

        public string VIII_a { get; set; }
        public string VIII_b { get; set; }
        public string VIII_c { get; set; }
        public string VIII_d { get; set; }
        public string VIII_e { get; set; }
        public double VIII_subtotal { get; set; }

        public string P_1 { get; set; }
        public string P_2 { get; set; }
        public string P_3 { get; set; }
        public string P_4 { get; set; }
        public string P_5 { get; set; }
        public string P_6 { get; set; }
        public string P_7 { get; set; }
        public string P_8 { get; set; }
        public string P_9 { get; set; }
        public string P_10 { get; set; }
        public string P_11 { get; set; }
        public string P_12 { get; set; }
        public string P_13 { get; set; }

        public string DG { get; set; }

        public byte[] FirmaDigital { get; set; }
        public Proyecto Proyecto { get; set; }
    }
}
