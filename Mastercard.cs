using System;
namespace Aula07Encapsulamento {
    public class Mastercard : Cartao 
    {
        public int parcelas { get; set; }        
         //como e usado o void
         /// <summary>
         /// void
         /// </summary>
         /// <param name="desconto"></param>   
        public void ComprarComDescontoMastercard(float desconto){

            //Protected
            /// <summary>
            /// DESCONTO
            /// </summary>
            /// <value>MOSTRA O DESCONTO QUE SERA APLICADO</value>
            
            Console.WriteLine($"Aplicado desconto de {desconto}, no total de {parcelas} parcelas");
        }
    }
}
       