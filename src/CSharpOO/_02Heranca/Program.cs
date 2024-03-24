using _02Heranca;

var carro = new Carro();
carro.Marca = "Chevrolet";
carro.Modelo = "Onix";
carro.QuantidadeDePassageiros = 5;
carro.AnoFabricacao = 2021;
carro.AnoModelo = 2022;
carro.Valor = 87500;
carro.CapacidadeDoPortaMalas = 160;

var moto = new Moto();
moto.Marca = "Yamaha";
moto.Modelo = "YBR";
moto.QuantidadeDePassageiros = 2;
moto.AnoFabricacao = 2023;
moto.AnoModelo = 2023;
moto.Valor = 18980.88;

Console.WriteLine($"carro {carro.Marca} {carro.Modelo} {carro.AnoFabricacao}/{carro.AnoModelo} com portamalas de {carro.CapacidadeDoPortaMalas}L por: {carro.Valor} ou {carro.ObterValorParaFrotista()}");
Console.WriteLine($"moto {moto.Marca} {moto.Modelo} {moto.AnoFabricacao}/{moto.AnoModelo} por: {moto.Valor} ou {moto.ObterValorParaFrotista()}");