namespace _02Heranca;

public class Carro : Veiculo
{
    public double ObterValorParaFrotista()
    {
        return Valor - Valor * .15;
    }
}