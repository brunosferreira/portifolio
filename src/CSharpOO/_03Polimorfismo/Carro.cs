namespace _03Polimorfismo;

public class Carro : Veiculo
{
    public override double ObterValorParaFrotista()
    {
        return Valor - Valor * .15;
    }
}