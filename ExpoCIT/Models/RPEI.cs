namespace ExpoCIT.Models
{
    public class RPEI : Auditable
    {
        public int Id { get; set; }

        public int I_a { get; set; }
        public string? I_a_descripcion { get; set; }
        public int I_b { get; set; }
        public string? I_b_descripcion { get; set; }
        public int I_c { get; set; }
        public string? I_c_descripcion { get; set; }
        public int I_d { get; set; }
        public string? I_d_descripcion { get; set; }
        public int I_e { get; set; }
        public string? I_e_descripcion { get; set; }
        public int I_subtotal { get; set; }

        public int II_a { get; set; }
        public string? II_a_descripcion { get; set; }
        public int II_b { get; set; }
        public string? II_b_descripcion { get; set; }
        public int II_c { get; set; }
        public string? II_c_descripcion { get; set; }
        public int II_d { get; set; }
        public string? II_d_descripcion { get; set; }
        public int II_e { get; set; }
        public string? II_e_descripcion { get; set; }
        public int II_f { get; set; }
        public string? II_f_descripcion { get; set; }
        public int II_subtotal { get; set; }

        public int III_a { get; set; }
        public string? III_a_descripcion { get; set; }
        public int III_b { get; set; }
        public string? III_b_descripcion { get; set; }
        public int III_c { get; set; }
        public string? III_c_descripcion { get; set; }
        public int III_d { get; set; }
        public string? III_d_descripcion { get; set; }
        public int III_e { get; set; }
        public string? III_e_descripcion { get; set; }
        public int III_subtotal { get; set; }

        public int IV_a { get; set; }
        public string? IV_a_descripcion { get; set; }
        public int IV_b { get; set; }
        public string? IV_b_descripcion { get; set; }
        public int IV_c { get; set; }
        public string? IV_c_descripcion { get; set; }
        public int IV_d { get; set; }
        public string? IV_d_descripcion { get; set; }
        public int IV_e { get; set; }
        public string? IV_e_descripcion { get; set; }
        public int IV_f { get; set; }
        public string? IV_f_descripcion { get; set; }
        public int IV_subtotal { get; set; }

        public int V_a { get; set; }
        public string? V_a_descripcion { get; set; }
        public int V_b { get; set; }
        public string? V_b_descripcion { get; set; }
        public int V_c { get; set; }
        public string? V_c_descripcion { get; set; }
        public int V_d { get; set; }
        public string? V_d_descripcion { get; set; }
        public int V_e { get; set; }
        public string? V_e_descripcion { get; set; }
        public int V_f { get; set; }
        public string? V_f_descripcion { get; set; }
        public int V_subtotal { get; set; }

        public int VI_a { get; set; }
        public string? VI_a_descripcion { get; set; }
        public int VI_b { get; set; }
        public string? VI_b_descripcion { get; set; }
        public int VI_c { get; set; }
        public string? VI_c_descripcion { get; set; }
        public int VI_d { get; set; }
        public string? VI_d_descripcion { get; set; }
        public int VI_e { get; set; }
        public string? VI_e_descripcion { get; set; }
        public int VI_f { get; set; }
        public string? VI_f_descripcion { get; set; }
        public int VI_g { get; set; }
        public string? VI_g_descripcion { get; set; }
        public int VI_h { get; set; }
        public string? VI_h_descripcion { get; set; }
        public int VI_subtotal { get; set; }

        public int VII_a { get; set; }
        public string? VII_a_descripcion { get; set; }
        public int VII_b { get; set; }
        public string? VII_b_descripcion { get; set; }
        public int VII_c { get; set; }
        public string? VII_c_descripcion { get; set; }
        public int VII_d { get; set; }
        public string? VII_d_descripcion { get; set; }
        public int VII_e { get; set; }
        public string? VII_e_descripcion { get; set; }
        public int VII_f { get; set; }
        public string? VII_f_descripcion { get; set; }
        public int VII_subtotal { get; set; }

        public int VIII_a { get; set; }
        public string? VIII_a_descripcion { get; set; }
        public int VIII_b { get; set; }
        public string? VIII_b_descripcion { get; set; }
        public int VIII_c { get; set; }
        public string? VIII_c_descripcion { get; set; }
        public int VIII_d { get; set; }
        public string? VIII_d_descripcion { get; set; }
        public int VIII_subtotal { get; set; }

        public int Total {
            get {
                return I_subtotal + II_subtotal + III_subtotal + IV_subtotal + V_subtotal + VI_subtotal + VII_subtotal + VIII_subtotal;
            }
        }

        public string? DG { get; set; }

        public byte[] FirmaDigital { get; set; }
        public Proyecto Proyecto { get; set; }
    }
}
