namespace funcionario;
class Program
{
    static void Main(string[] args)
    {
        FuncionarioN1 n1 = new FuncionarioN1();
        FuncionarioN2 n2 = new FuncionarioN2();
        FuncionarioN3 n3 = new FuncionarioN3();

        n1.Nome = "Anderson";
        n1.Idade = 48;
        n2.Nome = "Stephanie";
        n2.Idade = 16;
        n3.Nome = "Maria Rita";
        n3.Idade = 18;
        n3.Cargo = "Gerente";

        Console.WriteLine("Nome: " + n1.Nome + "--Idade: " + n1.Idade + "--Lucro: " + n1.Lucro());
        Console.WriteLine("Nome: " + n2.Nome + "--Idade: " + n2.Idade + "--Lucro: " + n2.Lucro());
        Console.WriteLine("Nome: " + n3.Nome + "--Idade: " + n3.Idade + "--Lucro: " + n3.Lucro() + "--Cargo: " + n3.Cargo);
    }
}
