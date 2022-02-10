using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo); // 100 (valor padrão atribuído na classe)

            bool resultadoSaque = contaDoBruno.Sacar(500); // Guarda em uma variável o retorno da função Sacar

            Console.WriteLine(contaDoBruno.saldo); // 100
            Console.WriteLine(resultadoSaque); // False. O saque não foi permitido

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo); // 600

            // Criando um novo objeto e atribuindo o nome do titular de uma maneira diferente.
            ContaCorrente contaDaGabriela = new ContaCorrente
            {
                titular = "Gabriela"
            };

            Console.WriteLine("Saldo do Bruno :" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela :" + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno :" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela :" + contaDaGabriela.saldo);

            Console.WriteLine("Resultado da transferência: " + resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo do Bruno :" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela :" + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
