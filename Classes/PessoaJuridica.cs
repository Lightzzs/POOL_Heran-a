  namespace Codigo.Classes
{
    public class PessoaJuidica : Pessoa // : --> Herdar de uma classe
    {
        public string cnpj;
        public string inscriçãoestadual;

        public bool validarcnpj(string documento){
            if(documento != " "){
                return true;
            }
            return false;
        }
    }
}