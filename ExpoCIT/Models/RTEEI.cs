namespace ExpoCIT.Models
{
    public class RTEEI : Auditable
    {
        string I_a { get; set; }
        string I_b { get; set; }
        string I_c { get; set; }
        string I_d { get; set; }
        string I_e { get; set; }
        double I_subtotal { get; set; }

        string II_a { get; set; }
        string II_b { get; set; }
        string II_c { get; set; }
        string II_d { get; set; }
        string II_e { get; set; }
        string II_f { get; set; }
        double II_subtotal { get; set; }

        string III_a { get; set; }
        string III_b { get; set; }
        string III_c { get; set; }
        string III_d { get; set; }
        double III_subtotal { get; set; }

        string IV_a { get; set; }
        string IV_b { get; set; }
        string IV_c { get; set; }
        string IV_d { get; set; }
        string IV_e { get; set; }
        double IV_subtotal { get; set; }

        string V_a { get; set; }
        string V_b { get; set; }
        string V_c { get; set; }
        string V_d { get; set; }
        string V_e { get; set; }
        string V_f { get; set; }
        double V_subtotal { get; set; }

        string VI_a { get; set; }
        string VI_b { get; set; }
        string VI_c { get; set; }
        string VI_d { get; set; }
        string VI_e { get; set; }
        string VI_f { get; set; }
        double VI_subtotal { get; set; }

        string VII_a { get; set; }
        string VII_b { get; set; }
        string VII_c { get; set; }
        string VII_d { get; set; }
        string VII_e { get; set; }
        double VII_subtotal { get; set; }

        string VIII_a { get; set; }
        string VIII_b { get; set; }
        string VIII_c { get; set; }
        string VIII_d { get; set; }
        string VIII_e { get; set; }
        double VIII_subtotal { get; set; }

        string P_1 { get; set; }
        string P_2 { get; set; }
        string P_3 { get; set; }
        string P_4 { get; set; }
        string P_5 { get; set; }
        string P_6 { get; set; }
        string P_7 { get; set; }
        string P_8 { get; set; }
        string P_9 { get; set; }
        string P_10 { get; set; }
        string P_11 { get; set; }
        string P_12 { get; set; }
        string P_13 { get; set; }

        string DG { get; set; }

        byte[] FirmaDigital { get; set; }
        Proyecto Proyecto { get; set; }
    }
}
