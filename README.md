# Sistema Simulado de Hospedagem (C#)

# Projeto de Hospedagem de Hotel

Este é um projeto simples de hospedagem em hotel, criado como parte de um desafio de programação. O sistema permite o cadastro de hóspedes, seleção de suítes, cálculo de diárias, e exibe informações detalhadas da reserva.

## Como Executar o Projeto

1. Clone este repositório.
2. Abra o projeto em sua IDE de preferência.
3. Compile e execute o programa.

## Estrutura do Projeto

O projeto consiste em quatro classes principais:

1. **Pessoa.cs**: Representa os hóspedes que irão se hospedar.
2. **Suite.cs**: Representa as suítes disponíveis no hotel.
3. **Reserva.cs**: Lida com as informações de reservas e cálculos relacionados à hospedagem.
4. **Program.cs**: O ponto de entrada do programa, onde ocorre a interação com o usuário.

### Funcionalidades do Sistema

- **Cadastro de Hóspedes**: O usuário pode adicionar vários hóspedes à reserva.
- **Seleção de Suíte**: O usuário escolhe uma suíte dentre as disponíveis no hotel.
- **Calcular Diárias**: O sistema calcula o valor total com base no número de dias de estadia.
- **Descontos**: Desconto de 10% aplicado para estadias com mais de 10 dias.

## Exemplo de Uso

```bash
Quem irá se hospedar?
Por favor informe o Nome:
> João

Por favor informe o Sobrenome:
> Silva

Cadastro Realizado com Sucesso!
Gostaria de adicionar mais alguém à Hospedagem?
(Sim/Não)
> Não

Lista de Suítes Disponíveis:
1 | Tipo da Suíte: Magnum | Capacidade: 6 | Valor Diária: R$ 750,00
2 | Tipo da Suíte: Deluxe | Capacidade: 4 | Valor Diária: R$ 450,00
3 | Tipo da Suíte: Advanced | Capacidade: 3 | Valor Diária: R$ 350,00
4 | Tipo da Suíte: Standard | Capacidade: 2 | Valor Diária: R$ 250,00
5 | Tipo da Suíte: Basic | Capacidade: 2 | Valor Diária: R$ 150,00

Por favor informe o Nome da suíte desejada:
> Magnum

Informe a data de Chegada:
> 10/10

Informe a data de Saída:
> 20/10

Reserva criada com sucesso!
 Suite: Magnum
 Data de Chegada: 10/10
 Data de Saída: 20/10
 Valor Diária: 750,00
 Número de Hóspedes: 1
 Dias Hospedados: 10
 Valor Total: R$ 6.750,00
