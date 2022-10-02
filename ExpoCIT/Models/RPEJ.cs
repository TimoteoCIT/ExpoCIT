namespace ExpoCIT.Models
{
    public class RPEJ : Auditable
    {
        string I_1 { get; set; }
        string I_2 { get; set; }
        string I_3 { get; set; }
        string I_4 { get; set; }
        string I_5 { get; set; }
        double I_subtotal { get; set; }

        string II_6 { get; set; }
        string II_7 { get; set; }
        string II_8 { get; set; }
        string II_9 { get; set; }
        string II_10 { get; set; }
        string II_11 { get; set; }
        double II_subtotal { get; set; }

        string III_12 { get; set; }
        string III_13 { get; set; }
        string III_14 { get; set; }
        string III_15 { get; set; }
        string III_16 { get; set; }
        double III_subtotal { get; set; }

        string IV_17 { get; set; }
        string IV_18 { get; set; }
        string IV_19 { get; set; }
        string IV_20 { get; set; }
        string IV_21 { get; set; }
        string IV_22 { get; set; }
        double IV_subtotal { get; set; }

        string V_23 { get; set; }
        string V_24 { get; set; }
        string V_25 { get; set; }
        string V_26 { get; set; }
        string V_27 { get; set; }
        double V_subtotal { get; set; }

        string VI_28 { get; set; }
        string VI_29 { get; set; }
        string VI_30 { get; set; }
        string VI_31 { get; set; }
        double VI_subtotal { get; set; }

        string VII_32 { get; set; }
        string VII_33 { get; set; }
        string VII_34 { get; set; }
        string VII_35 { get; set; }
        double VII_subtotal { get; set; }

        string DG { get; set; }

        byte[] FirmaDigital { get; set; }
        Proyecto Proyecto { get; set; }
    }
}
