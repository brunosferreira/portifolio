namespace _05Encapsulamento;

public sealed class Carro : Veiculo
{
    public int CapacidadeDoPortaMalas { get; private set; }

    public Carro(string marca, string modelo, int anoModelo, int anoFabricacao, double valor,
        int quantidadeDePassageiros, int capacidadeDoPortaMalas) :
        base(marca, modelo, anoModelo, anoFabricacao, valor, quantidadeDePassageiros)
    {
        CapacidadeDoPortaMalas = capacidadeDoPortaMalas;
    }

    protected override double ObterValorParaFrotista()
    {
        return Valor - Valor * .15;
    }

    public override string ToString()
    {
        return $"{base.ToString()} com portamalas de {CapacidadeDoPortaMalas}L";
    }
}