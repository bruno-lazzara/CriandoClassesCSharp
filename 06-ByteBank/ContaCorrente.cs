


namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100; // A visibilidade desse atributo foi modificada para private.

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value; // value é uma palavra reservada dentro de set.
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        // Esse método não tem retorno (void), não devolve nada após sua execução.
        public void Depositar(double valor)
        {
            _saldo += valor;
        }
        // É comum chamarmos de função quando há retorno na função, e de método quando não há retorno,
        // mas as duas formas estão corretas.

        // Essa função recebe como argumentos o valor a ser transferido, e a conta a ser depositado esse valor
        // (que é um objeto do tipo ContaCorrente).
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false; // O return para imediatamente a execução do código.
            }

            _saldo -= valor;
            // Podemos chamar o método Depositar para realizar essa operação, sem precisarmos escrever
            // mais código para somar o valor ao saldo da outra conta corrente.
            contaDestino.Depositar(valor);
            return true;
        }
    }
}

