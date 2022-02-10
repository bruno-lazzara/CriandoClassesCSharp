// using _05_ByteBank;


namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100; // Atribuído um valor padrão para um atributo dentro da classe.

        // Função (Método) Sacar. Esta função precisa retornar um bool (se o saque foi possível ou não)
        // e precisa receber um argumento, que é o valor que o usuário deseja sacar.
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        // Esse método não tem retorno (void), não devolve nada após sua execução.
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
        // É comum chamarmos de função quando há retorno na função, e de método quando não há retorno,
        // mas as duas formas estão corretas.

        // Essa função recebe como argumentos o valor a ser transferido, e a conta a ser depositado esse valor
        // (que é um objeto do tipo ContaCorrente).
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false; // O return para imediatamente a execução do código.
            }

            this.saldo -= valor;
            // Podemos chamar o método Depositar para realizar essa operação, sem precisarmos escrever
            // mais código para somar o valor ao saldo da outra conta corrente.
            contaDestino.Depositar(valor); // contaDestino.saldo += valor
            return true;
        }
    }
}

