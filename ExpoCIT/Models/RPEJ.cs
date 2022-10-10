namespace ExpoCIT.Models
{
    public class RPEJ : Auditable
    {
        public int Id { get; set; }

        public string I_1 { get; set; }
        public string I_2 { get; set; }
        public string I_3 { get; set; }
        public string I_4 { get; set; }
        public string I_5 { get; set; }
        public double I_subtotal { get; set; }

        public string II_6 { get; set; }
        public string II_7 { get; set; }
        public string II_8 { get; set; }
        public string II_9 { get; set; }
        public string II_10 { get; set; }
        public string II_11 { get; set; }
        public double II_subtotal { get; set; }

        public string III_12 { get; set; }
        public string III_13 { get; set; }
        public string III_14 { get; set; }
        public string III_15 { get; set; }
        public string III_16 { get; set; }
        public double III_subtotal { get; set; }

        public string IV_17 { get; set; }
        public string IV_18 { get; set; }
        public string IV_19 { get; set; }
        public string IV_20 { get; set; }
        public string IV_21 { get; set; }
        public string IV_22 { get; set; }
        public double IV_subtotal { get; set; }

        public string V_23 { get; set; }
        public string V_24 { get; set; }
        public string V_25 { get; set; }
        public string V_26 { get; set; }
        public string V_27 { get; set; }
        public double V_subtotal { get; set; }

        public string VI_28 { get; set; }
        public string VI_29 { get; set; }
        public string VI_30 { get; set; }
        public string VI_31 { get; set; }
        public double VI_subtotal { get; set; }

        public string VII_32 { get; set; }
        public string VII_33 { get; set; }
        public string VII_34 { get; set; }
        public string VII_35 { get; set; }
        public double VII_subtotal { get; set; }

        public double Total
        {
            get
            {
                return I_subtotal + II_subtotal + III_subtotal + IV_subtotal + V_subtotal + VI_subtotal + VII_subtotal;
            }
        }

        public string DG { get; set; }

        public byte[] FirmaDigital { get; set; }
        public Proyecto Proyecto { get; set; }
    }
}
