namespace exe3;
class PessoaFisica:Contrato
{
   public override double CalcularPrestacao(){
    if (Idade <= 30)
    {
        return ((base.CalcularPrestacao()/Prazo)+1);
    }
    else if (Idade <= 40) 
    {
        return ((base.CalcularPrestacao()/Prazo)+2);
    }
    else if (Idade <= 50) 
    {
        return ((base.CalcularPrestacao()/Prazo)+3);
    }
    else 
    {
        return ((base.CalcularPrestacao()/Prazo)+4);
    }
 }
}