﻿namespace _03Polimorfismo;

public abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AnoModelo { get; set; }
    public int AnoFabricacao { get; set; } 
    public double Valor { get; set; }
    public int QuantidadeDePassageiros { get; set; }

    public abstract double ObterValorParaFrotista();
}