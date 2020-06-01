using System;

namespace Aula07Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao card = new Cartao();
            
            Mastercard master = new Mastercard();
            master.titular = "gustavo";
            master.parcelas = 5;
            master.ComprarComDescontoMastercard(45f);
        }
        
    }
}
