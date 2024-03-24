namespace _02Heranca;

public class Carro : Veiculo
{
    public int CapacidadeDoPortaMalas { get; set; }
    
    public double ObterValorParaFrotista()
    {
        return Valor - Valor * .15;
    }
}