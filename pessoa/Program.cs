namespace pessoa;
class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Stephanie" ,16);
        //p1.AlteraNome("Stephanie");
        //p1.AlteraSobrenome("Mota");
        //p1.AlteraIdade(16);
        p1.MostraDados();
    }
}
