namespace _05Encapsulamento;

public abstract class Veiculo
{
    public string Marca { get; protected set; }
    public string Modelo { get; protected set; }
    public int AnoModelo { get; protected set; }
    public int AnoFabricacao { get; protected set; } 
    public double Valor { get; protected set; }
    public int QuantidadeDePassageiros { get; protected set; }
    public double ValorParaFrotista => ObterValorParaFrotista();

    public Veiculo(string marca, string modelo, int anoModelo, int anoFabricacao, double valor, int quantidadeDePassageiros)
    {
        Marca = marca;
        Modelo = modelo;
        AnoModelo = anoModelo;
        AnoFabricacao = anoFabricacao;
        Valor = valor;
        QuantidadeDePassageiros = quantidadeDePassageiros;
    }

    public override string ToString()
    {
        return $"{GetType().Name} {Marca} {Modelo} {AnoModelo}/{AnoFabricacao} por {Valor} ou {ValorParaFrotista} para frotistas.";
    }

    protected abstract double ObterValorParaFrotista();
}