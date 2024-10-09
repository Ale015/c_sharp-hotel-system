namespace DesafioProjetoHospedagem.Models
{

    public class Suite{

        // Construtores

            // Construtor Geral
            public Suite(){}

            // Construtor Completo
            public Suite(string tiposuite, int capacidade, decimal valordiaria){
                TipoSuite = tiposuite;
                Capacidade = capacidade;
                ValorDiaria = valordiaria;

                ListaSuitesTotais.Add(this);
            }



        // Propriedades
        public string TipoSuite {get; set;}
        public int Capacidade {get; set;}
        public decimal ValorDiaria {get; set;}

        // Lista de Todas as Suítes Instanciadas
        public static List<Suite> ListaSuitesTotais = new List<Suite>();

        public static void ConferirListaSuitesTotais() {
            System.Console.WriteLine($"Lista de Suítes Disponíveis:");

            for (int i = 0; i < ListaSuitesTotais.Count; i++) {
                System.Console.WriteLine($"{i + 1} | Tipo da Suíte: {ListaSuitesTotais[i].TipoSuite} | Capacidade: {ListaSuitesTotais[i].Capacidade} | Valor Diária: {ListaSuitesTotais[i].ValorDiaria:C}");
            }
        }
    } 
}