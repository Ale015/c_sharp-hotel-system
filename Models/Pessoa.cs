namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
// Construtor

    // Construtor Geral
    public Pessoa () {}

    // Construtor Completo
    public Pessoa (string name, string sobrenome){
        Nome = name;
        Sobrenome = sobrenome;
    }


// Propriedades
    public string Nome {get; set;}
    public string Sobrenome {get; set;}

    public string NomeCompleto {get {
        return Nome + " " + Sobrenome;
    }}                                                                                    
}