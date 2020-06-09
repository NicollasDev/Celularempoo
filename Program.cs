using System;

namespace Aula_Celular
{
    class Program
    {
        static void Main(string[] args)
        {
        Celular xiomi = new Celular();
        xiomi.cor = "A cor do robozao tenebroso eh azul";
        xiomi.modelo = "Seu modelo é r1250";
        xiomi.tamanho = "Tamanho de nave";
        
        //while = enquanto
        // if =  se
        //case = caso
        //switch = conjunto  de if
        //int32.parse= consegue aceitar numero como resposta
        //switch sempre tem um default
        //else = se não
        
         System.Console.WriteLine(xiomi.cor);
         System.Console.WriteLine(xiomi.modelo);
         System.Console.WriteLine(xiomi.tamanho);


        xiomi.ligado = true;
        System.Console.WriteLine( "Voce quer ligar o robozao? Digite true ou false!!" );
        xiomi.ligado = Boolean.Parse( Console.ReadLine () );
        if( xiomi.ligado ){
            while (xiomi.ligado){
                System.Console.WriteLine("O que voce deseja fazer? \n 1 Desligar celular \n 2 Enviar mensagem \n 3 Fazer ligacao");
                int resposta = Int32.Parse(Console.ReadLine() );
                switch(resposta){

                case 1:
                System.Console.WriteLine(xiomi.Desligar());    
                break;

                case 2:
                System.Console.WriteLine(xiomi.EnviarMensagem());    
                break;
                
                case 3:
                System.Console.WriteLine(xiomi.Fazerligacao());    
                break;

                default : 
                System.Console.WriteLine(xiomi.ligar());
                break;
                }
            }

        }else{
            System.Console.WriteLine("O robozao esta desligado =/");
        }
        }
    }
}
