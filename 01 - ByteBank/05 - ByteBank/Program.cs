using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvoledora C#";
            //gabriela.cpf = "458.265.154.23";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;
            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "121.246.266-12";
            conta.titular.profissao = "Desenvoledora C#";


            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;


            conta.titular.nome = "Gabriela Costa";

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
                        
        }
    }
}
