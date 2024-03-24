namespace _03Polimorfismo;

public class Carro : Veiculo
{
    protected override double ObterValorParaFrotista()
    {
        return Valor - Valor * .15;
    }
}