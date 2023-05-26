namespace exe3;
class PessoaJuridica:Contrato
{
    public override double CalcularPrestacao(){
    return ((base.CalcularPrestacao()/Prazo)+3);
   }
}