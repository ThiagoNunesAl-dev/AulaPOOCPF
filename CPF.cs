namespace AulaPOOCPF
{
    public class CPF : Pessoa
    {
        public string cpf;
        public string rg;

        public bool ValidarCPF (string cpf) {
            if (cpf != null) {
                return true;
            }
            return false;
        }

        public bool ValidarRG (string rg) {
            if (rg != null) {
                return true;
            }
            return false;
        }
    }
}