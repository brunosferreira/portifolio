namespace _05Encapsulamento;

public sealed class Moto : Veiculo
{
    public Moto(string marca, string modelo, int anoModelo, int anoFabricacao, double valor, int quantidadeDePassageiros) :
        base(marca, modelo, anoModelo, anoFabricacao, valor, quantidadeDePassageiros) { }

    protected override double ObterValorParaFrotista()
    {
        return Valor - Valor * .08;
    }
}