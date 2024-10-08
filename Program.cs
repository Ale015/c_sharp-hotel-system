using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DesafioProjetoHospedagem.Models;


Suite suite1 = new Suite("Suíte Presidencial",6, 750.00M);
Suite suite2 = new Suite("Suíte Luxo",4, 450.00M);
Suite suite3 = new Suite("Suíte Advanced",3, 350.00M);
Suite suite4 = new Suite("Suíte Standart",2, 250.00M);
Suite suite5 = new Suite("Suíte Basic",2, 150.00M);

Suite.ConferirListaSuitesTotais();


List<Pessoa> ListaHospedes = new List<Pessoa>();

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
            System.Console.WriteLine($"Sobreome Cadastrado: {sobrenome}");
        }   
        catch {
            System.Console.WriteLine("Não foi possível registrar o Sobrenome, tente novamente ou cancele digitando 'exit'.");
            continue;
        }
    }
    try {
        System.Console.WriteLine($"Cadastro Realizado com Sucesso!");
        Pessoa pessoa = new Pessoa( name, sobrenome);
        Console.WriteLine(pessoa.NomeCompleto);

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
    }

}

System.Console.WriteLine($"Lista de Hospedes declarados:");
System.Console.WriteLine($"  Total de Hospedes: {ListaHospedes.Count()}");
foreach (var item in ListaHospedes){
    System.Console.WriteLine(item.NomeCompleto);
}














// Console.OutputEncoding = Encoding.UTF8;

// // Cria os modelos de hóspedes e cadastra na lista de hóspedes
// List<Pessoa> hospedes = new List<Pessoa>();

// Pessoa p1 = new Pessoa(nome: "Hóspede 1");
// Pessoa p2 = new Pessoa(nome: "Hóspede 2");

// hospedes.Add(p1);
// hospedes.Add(p2);

// // Cria a suíte
// Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// // Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva = new Reserva(diasReservados: 5);
// reserva.CadastrarSuite(suite);
// reserva.CadastrarHospedes(hospedes);

// // Exibe a quantidade de hóspedes e o valor da diária
// Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
// Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");