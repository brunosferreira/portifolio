namespace _03Polimorfismo;

public class Moto : Veiculo
{
    public override double ObterValorParaFrotista()
    {
        return Valor - Valor * .08;
    }
}