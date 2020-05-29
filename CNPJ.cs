namespace AulaPOOCPF
{
    public class CNPJ : Pessoa
    {
        public string cnpj;

        public bool ValidarCNPJ (string cnpj) {
            if (cnpj != null) {
                return true;
            }
            return false;
        }
    }
}