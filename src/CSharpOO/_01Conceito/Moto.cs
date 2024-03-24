namespace _01Conceito;

public class Moto
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AnoModelo { get; set; }
    public int AnoFabricacao { get; set; }
    public double Valor { get; set; }
    public string Cor { get; set; }
    public int QuantidadeDePassageiros { get; set; }

    public double ObterValorParaFrotista()
    {
        return Valor - Valor * .08;
    }
}