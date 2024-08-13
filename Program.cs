using System.Text;
using PROJETOSCSHARP;
using System.Collections.Generic;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new(nome: "Rony", sobrenome: "Pinheiro");
Pessoa p2 = new(nome: "Geo", sobrenome: "Goulart");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

Reserva reserva = new Reserva (diasReservados: 10);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor reservas: {reserva.CalcularValorDiaria()}");
