using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));
            // False. O que fica salvo dentro destas variáveis não são os seus valores,
            // mas sim o endereço para os seus respectivos objetos, que estes sim contém
            // os valores. Portanto, estamos comparando dois endereços diferentes, e não
            // duas variáveis com valores iguais.

            int idade = 27;
            int idade2 = 27;
            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idade2));


            contaDaGabriela = contaDaGabrielaCosta;
            // Agora temos duas variáveis que estão apontando para o mesmo objeto na memória.
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);
            // True

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);
            // As duas variáveis apontam para o mesmo objeto, por isso imprimem o mesmo saldo.


            Console.ReadLine();
        }
    }
}
