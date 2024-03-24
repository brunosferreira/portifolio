using _01Conceito;

var objeto = new Carro();
objeto.Marca = "Fiat";
objeto.Modelo = "Uno";
objeto.Cor = "branco";
objeto.AnoDeFabricacao = 2015;
objeto.AnoDoModelo = 2016;
objeto.Valor = 55000;
objeto.QuantidadeDePassageiros = 5;

Console.WriteLine($"carro: {objeto.Marca} {objeto.Modelo} {objeto.AnoDeFabricacao}/{objeto.AnoDoModelo}, {objeto.Cor} por {objeto.Valor} ou {objeto.ObterValorParaFrotista()} para frotistas.");

var objeto2 = new Moto();
objeto2.Marca = "Honda";
objeto2.Modelo = "Biz";
objeto2.Cor = "Preta";
objeto2.AnoFabricacao = 2019;
objeto2.AnoModelo = 2020;
objeto2.Valor = 18990;
objeto2.QuantidadeDePassageiros = 2;

Console.WriteLine($"moto: {objeto2.Marca} {objeto2.Modelo} {objeto2.AnoFabricacao}/{objeto2.AnoModelo}, {objeto2.Cor} por {objeto2.Valor} ou {objeto2.ObterValorParaFrotista()}");
