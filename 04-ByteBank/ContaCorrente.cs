


public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100; // Atribuído um valor padrão para uma variável dentro da classe.

    // Função Sacar. Esta função precisa retornar um bool (se o saque foi possível ou não)
    // e precisa receber um argumento, que é o valor que o usuário deseja sacar.
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }
}


