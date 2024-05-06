using System.Text;
using System.Globalization;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(numeroRegistro: 1, nome: "Italo", sobrenome: "Alves");
Pessoa p2 = new Pessoa(numeroRegistro: 2,nome: "Hamid", sobrenome: "Manoukian");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 350);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 11);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes na Suite Premium: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");

// Exibe o nome dos hóspedes
foreach (Pessoa hospede in hospedes)
{
    Console.WriteLine($"Nº Registro: {hospede.NumeroRegistro} - Nome do hóspede: {hospede.Nome} {hospede.Sobrenome}");
}
