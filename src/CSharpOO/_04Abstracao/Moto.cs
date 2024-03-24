namespace _04Abstracao;

public class Moto : Veiculo
{
    protected override double ObterValorParaFrotista()
    {
        return Valor - Valor * .08;
    }
}