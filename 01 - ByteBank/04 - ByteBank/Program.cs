using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            bool resutaldoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(resutaldoSaque);
            Console.WriteLine(contaDoBruno.saldo);


            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine($"Saldo do Bruno: R${contaDoBruno.saldo}");
            Console.WriteLine($"Saldo da Gabriela: R${contaDaGabriela.saldo}");

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine($"Saldo do Bruno: R${contaDoBruno.saldo}");
            Console.WriteLine($"Saldo da Gabriela: R${contaDaGabriela.saldo}");

            Console.WriteLine($"Resoltado transferência: {resultadoTransferencia}");

            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine($"Saldo do Bruno: R${contaDoBruno.saldo}");
            Console.WriteLine($"Saldo da Gabriela: R${contaDaGabriela.saldo}");

            Console.ReadLine();

        }

        
    }

}
