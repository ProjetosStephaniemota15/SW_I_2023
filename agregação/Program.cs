namespace agregação;
class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com Agregação!");
        
        //instanciando os objetos de cada classe
        CartaoDeCredito cdc = new CartaoDeCredito();
        Cliente cli = new Cliente();

        //Adicionando um nome para um cliente
        cli.Nome = "Stephanie Mota";

        //Adicionando número e validade do Cartão de Crédito
        cdc.Numero = "14112006";
        cdc.DataValidade = "11/2026";

        //Associando o cliente ao atributo de agregação em Cartão de Credito
        cdc.Cliente = cli;

        //Visualizando as informações
        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente AGREGADO é: " + cdc.Cliente.Nome);

    }
}
