namespace _02Heranca;

public class Moto : Veiculo
{
    public double ObterValorParaFrotista()
    {
        return Valor - Valor * .08;
    }
}