using _03Polimorfismo;

var carro = new Carro();
carro.Marca = "Hyundai";
carro.Modelo = "HB20";
carro.QuantidadeDePassageiros = 5;
carro.Valor = 82000;
carro.AnoFabricacao = 2024;
carro.AnoModelo = 2024;

var moto = new Moto();
moto.Marca = "Suzuki";
moto.Modelo = "B King";
moto.QuantidadeDePassageiros = 2;
moto.Valor = 120500;
moto.AnoFabricacao = 2024;
moto.AnoModelo = 2024;

Console.WriteLine($"carro {carro.Marca} {carro.Modelo} {carro.AnoFabricacao}/{carro.AnoModelo} por {carro.Valor} ou {carro.ObterValorParaFrotista()} para frotistas.");
Console.WriteLine($"moto {moto.Marca} {moto.Modelo} {moto.AnoFabricacao}/{moto.AnoModelo} por {moto.Valor} ou {moto.ObterValorParaFrotista()} para frotistas.");