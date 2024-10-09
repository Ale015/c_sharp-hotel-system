using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DesafioProjetoHospedagem.Models;
Console.OutputEncoding = Encoding.UTF8;

// SETUP - Inicialização de objetos instanciados 

Suite suite1 = new Suite("Magnum",6, 750.00M);
Suite suite2 = new Suite("Deluxe",4, 450.00M);
Suite suite3 = new Suite("Advanced",3, 350.00M);
Suite suite4 = new Suite("Standard",2, 250.00M);
Suite suite5 = new Suite("Basic",2, 150.00M);

Suite suiteEscolhida = null;

List<Pessoa> ListaHospedes = new List<Pessoa>();

// 1° PARTE - Registrar Hóspedes

//Loop de adição de Nome dos hóspedes
while (true) {
    System.Console.WriteLine($"\nQuem irá se hospedar?");
    System.Console.WriteLine($"\nPor favor informe o Nome:\n(Para Sair digite 'exit').");
    string name = Console.ReadLine();

    if ( name.ToUpper() == "EXIT"){
        break;
    } else {
        try{
            System.Console.WriteLine($"Nome Cadastrado: {name}");
        }   
        catch {
            System.Console.WriteLine("Não foi possível registrar o Nome, tente novamente ou cancele digitando 'exit'.");
            continue;
        }
    }

    System.Console.WriteLine($"\nPor favor informe o Sobrenome:\n(Para Sair digite 'exit').");
    string sobrenome = Console.ReadLine();

    if ( sobrenome.ToUpper() == "EXIT"){
        break;
    } else {
        try{
            System.Console.WriteLine($"Sobrenome Cadastrado: {sobrenome}");
        }   
        catch {
            System.Console.WriteLine("Não foi possível registrar o Sobrenome, tente novamente ou cancele digitando 'exit'.");
            continue;
        }
    }
    try {
        System.Console.WriteLine($"\nCadastro Realizado com Sucesso!");
        Pessoa pessoa = new Pessoa( name, sobrenome);
        Console.WriteLine($"{pessoa.NomeCompleto}\n");

        ListaHospedes.Add(pessoa);
    }
    catch {
        System.Console.WriteLine($"Não foi possível realizar o processo, tente novamente.");
        continue;
    }

    System.Console.WriteLine($"Gostaria de adicionar mais alguém à Hospedagem?\n(Sim/Não)");
    string addMaisHospedes = Console.ReadLine();
    if (addMaisHospedes.ToUpper() == "SIM" || addMaisHospedes.ToUpper() == "S"){
        continue;
    }
    else if (addMaisHospedes.ToUpper() == "NÃO" || addMaisHospedes.ToUpper() == "NAO" || addMaisHospedes.ToUpper() == "N") {
        break;
    } else {
        System.Console.WriteLine($"Por favor digite um valor válido.");
        continue;
    }

}


System.Console.WriteLine($"Lista de Hospedes declarados:");
System.Console.WriteLine($"  Total de Hospedes: {ListaHospedes.Count()}\n");
foreach (var item in ListaHospedes){
    System.Console.WriteLine($"- {item.NomeCompleto};");
}
System.Console.WriteLine("");

// 2° PARTE - Encontrar acomodações desejadas:


DateTime diaFinal;
DateTime diaInicial;

while (true)
{

    while (true)
    {
        Suite.ConferirListaSuitesTotais();
        System.Console.WriteLine($"\nPor favor informe o Nome da suíte desejada:\n(Digite 'exit' para sair.) ");
        
        string escolha = Console.ReadLine();

        if (escolha.ToUpper() == "EXIT"){
            break;

        } else {
            suiteEscolhida = Suite.ListaSuitesTotais.FirstOrDefault(s => s.TipoSuite.Equals(escolha));
            
            if (suiteEscolhida == null){
                System.Console.WriteLine("O nome informado não corresponde a nenhuma suíte disponibilizada.\nTente novamente.");
                continue;
            } else {

                 if (ListaHospedes.Count() > suiteEscolhida.Capacidade){
                    System.Console.WriteLine($"\nSinto muito mas a Capacidade da Suite não suporta o número de Hóspedes, por favor tente novamente\n");
                    continue;
                 }

                break;
            }
        }
    }
        

    

    while (true){
        System.Console.WriteLine("Informe a data de Chegada:\n(Informe no formato Dia/Mês)");
        string diainicial = Console.ReadLine();

        diaInicial = DateTime.ParseExact(diainicial, "d/M", null);

        try {
            System.Console.WriteLine($"Data de chegada: {diaInicial.ToString("dd/MM")}");

        } catch {
            System.Console.WriteLine("Formato de data inválido. Por favor, insira no formato correto (Dia/Mês).");

        }

        break;
    }

    while (true){
        System.Console.WriteLine("Informe a data de Saída:\n(Informe no formato Dia/Mês)");
        string diafinal = Console.ReadLine();

        diaFinal = DateTime.ParseExact(diafinal, "d/M", null);

        try {
            System.Console.WriteLine($"Data de chegada: {diaFinal.ToString("dd/MM")}");

        } catch {
            System.Console.WriteLine("Formato de data inválido. Por favor, insira no formato correto (Dia/Mês).");

        }

        break;
    }
    break;
}
    Reserva reservaFinalizada = new Reserva(suiteEscolhida, ListaHospedes, diaInicial, diaFinal);

Console.WriteLine("\nReserva criada com sucesso!");
Console.WriteLine($" Suite: {reservaFinalizada.SuiteEscolhida.TipoSuite}\n Data de Chegada: {reservaFinalizada.DataInicial.ToString("dd/MM")}\n Data de Saída: {reservaFinalizada.DataFinal.ToString("dd/MM")}\n Valor Diária: {reservaFinalizada.SuiteEscolhida.ValorDiaria}");

Console.WriteLine($" Número de Hóspedes: {reservaFinalizada.ObterQuantidadeHospedes()}");
Console.WriteLine($" Dias Hospedados: {reservaFinalizada.diasHospedados()}");
Console.WriteLine($" Valor Total: {reservaFinalizada.CalcularValorDiaria():C}");