namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {

        public Reserva(Suite suiteEscolhida, List<Pessoa> ListaHospedes, DateTime diaInicial, DateTime diaFinal){
            SuiteEscolhida = suiteEscolhida;
            Hospedes = ListaHospedes;
            DataInicial = diaInicial;
            DataFinal = diaFinal;
        }

        public Suite SuiteEscolhida {get;set;}
        public List<Pessoa> Hospedes {get;set;}
        public DateTime DataInicial {get; set;}
        public DateTime DataFinal {get; set;}



        public int diasHospedados(){
            var dias = DataFinal -  DataInicial;
            return dias.Days;
        }

        public int ObterQuantidadeHospedes(){
            return Hospedes.Count();
        }


        public decimal CalcularValorDiaria(){
            decimal valorFinal = SuiteEscolhida.ValorDiaria * diasHospedados();
            if (diasHospedados() < 10){
                return valorFinal;
            } else {
                valorFinal = valorFinal * 0.9M;
            }

            return valorFinal;
        }
    }
}