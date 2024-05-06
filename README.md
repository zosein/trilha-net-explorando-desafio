## Desafio de projeto - Trilha .NET - DIO
Para este desafio, apliquei os conhecimentos adquiridos no módulo "Explorando a linguagem C#", da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.
O seu programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.


![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

## Solução

Métodos implementados:

CadastrarHospedes():
- Verifica se a capacidade da suíte é maior ou igual ao número de hóspedes adicionados.
- Se sim, atribui a lista de hospedes à propriedade Hospedes.
- Caso contrário, lança uma exceção indicando que a capacidade da suíte é insuficiente.

ObterQuantidadeHospedes():
- Retorna o número total de hóspedes acessando a contagem da propriedade Hospedes.

CalcularValorDiaria():
- Calcula a diária multiplicando o número de dias reservados (DiasReservados) pela diária da suíte (Suite.ValorDiaria).
- Verifica se o número de dias reservados é maior ou igual a 10.
- Em caso afirmativo, aplica-se um desconto de 10%.
- Retorna o valor final da diária.

Este código implementa todas as funcionalidades necessárias para a classe Reserva, incluindo regras de validação e cálculo de descontos.
