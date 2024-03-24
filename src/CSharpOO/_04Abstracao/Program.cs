using _04Abstracao;

var carro = new Carro();
carro.Marca = "VolksWagen";
carro.Modelo = "Polo";
carro.QuantidadeDePassageiros = 5;
carro.Valor = 106800;
carro.AnoFabricacao = 2024;
carro.AnoModelo = 2024;

var moto = new Moto();
moto.Marca = "Honda";
moto.Modelo = "CB300";
moto.QuantidadeDePassageiros = 2;
moto.Valor = 36500;
moto.AnoFabricacao = 2024;
moto.AnoModelo = 2024;

Console.WriteLine($"carro {carro.Marca} {carro.Modelo} {carro.AnoFabricacao}/{carro.AnoModelo} por {carro.Valor} ou {carro.ValorParaFrotista} para frotistas.");
Console.WriteLine($"moto {moto.Marca} {moto.Modelo} {moto.AnoFabricacao}/{moto.AnoModelo} por {moto.Valor} ou {moto.ValorParaFrotista} para frotistas.");