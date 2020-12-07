  namespace Codigo.Classes
{
    public class PessoaFisica : Pessoa 
    {
        public string cpf;
        public string rg;

        public bool validarcpf(string documento){
            if(documento != ""){
                return true;
            }
            return false;
        }
    }
}