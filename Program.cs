using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Felipe", sobrenome:"Rodrigues");
Pessoa p2 = new Pessoa(nome: "Thays", sobrenome: "Ferreira");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30.00M);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspede 1: {p1.NomeCompleto}");
Console.WriteLine($"Hóspede 2: {p2.NomeCompleto}\n");
Console.WriteLine($"Total de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Dias hospedado: {reserva.DiasReservados}");
Console.WriteLine($"Valor da diário: {suite.ValorDiaria}");
Console.WriteLine($"Valor bruto da diária: {reserva.DiasReservados * suite.ValorDiaria}");
Console.WriteLine($"Valor líquido diária: {reserva.CalcularValorDiaria()}");