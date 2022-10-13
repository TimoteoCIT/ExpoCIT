namespace ExpoCIT.Models
{
    public class RPEJ : Auditable
    {
        public int Id { get; set; }

        public int I_1 { get; set; }
        public int I_2 { get; set; }
        public int I_3 { get; set; }
        public int I_4 { get; set; }
        public int I_5 { get; set; }
        public int I_subtotal { get; set; }

        public int II_6 { get; set; }
        public int II_7 { get; set; }
        public int II_8 { get; set; }
        public int II_9 { get; set; }
        public int II_10 { get; set; }
        public int II_11 { get; set; }
        public int II_subtotal { get; set; }

        public int III_12 { get; set; }
        public int III_13 { get; set; }
        public int III_14 { get; set; }
        public int III_15 { get; set; }
        public int III_16 { get; set; }
        public int III_subtotal { get; set; }

        public int IV_17 { get; set; }
        public int IV_18 { get; set; }
        public int IV_19 { get; set; }
        public int IV_20 { get; set; }
        public int IV_21 { get; set; }
        public int IV_22 { get; set; }
        public int IV_subtotal { get; set; }

        public int V_23 { get; set; }
        public int V_24 { get; set; }
        public int V_25 { get; set; }
        public int V_26 { get; set; }
        public int V_27 { get; set; }
        public int V_subtotal { get; set; }

        public int VI_28 { get; set; }
        public int VI_29 { get; set; }
        public int VI_30 { get; set; }
        public int VI_31 { get; set; }
        public int VI_subtotal { get; set; }

        public int VII_32 { get; set; }
        public int VII_33 { get; set; }
        public int VII_34 { get; set; }
        public int VII_35 { get; set; }
        public int VII_subtotal { get; set; }

        public double Total
        {
            get
            {
                return I_subtotal + II_subtotal + III_subtotal + IV_subtotal + V_subtotal + VI_subtotal + VII_subtotal;
            }
        }

        public string DG { get; set; }

        public byte[] FirmaDigital { get; set; }

        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }
    }
}
