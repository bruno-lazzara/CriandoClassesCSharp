


namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }



        // "static" - isso é uma propriedade que pertense à classe.
        // Não é uma propriedade de cada objeto criado por essa classe.
        // Essa propriedade é pública para obter o seu valor (get),
        // mas não para definir o seu valor (set). Seu valor é definido
        // (modificado) no construtor da classe.
        public static int TotalDeContasCriadas { get; private set; }



        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
                // value é uma palavra reservada dentro de set, e se refere ao valor inserido
                // no momento da atribuição, por exemplo conta.Agencia = 867; -> value = 867.
            }
        }

        public int Numero { get; set; }

        private double _saldo = 100;
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


        // Isto é um construtor. Ele define como que o objeto desta classe deve ser construído
        // e o que deve acontecer nesse momento de construção.
        // O objeto só pode ser construído passando os atributos de número de agência e conta.
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia; 
            Numero = numero;

            TotalDeContasCriadas++;
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

