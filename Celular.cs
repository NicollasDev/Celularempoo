namespace Aula_Celular
{
    public class Celular
    {

    //public = tipo de assinatura Usuario pode mexer no código
    // string = tipo de atributo com int, float, string = texto
    //bool eh necessario pra if else e switch, usa se boolean no program
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado; 

            public string ligar(){
            ligado = true;
            return "ligando celular";
            
        }
            public string Desligar(){
            ligado = false;
            return "Desligando celular";
            
        }
            public string Fazerligacao(){
            return "Fazendo ligacao";
            
        }
            public string EnviarMensagem(){
            return "Enviando mensagem";
            
        }
        
        
    }
}