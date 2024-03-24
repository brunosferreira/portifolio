namespace _01Conceito;

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AnoDoModelo { get; set; }
    public int AnoDeFabricacao { get; set; }
    public double Valor { get; set; }
    public string Cor { get; set; }
    public int QuantidadeDePassageiros { get; set; }

    public double ObterValorParaFrotista()
    {
        return Valor - (Valor * .25);
    }
}