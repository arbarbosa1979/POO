using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneus Pneu1 = new Pneus();
            Pneu1.Aro = 16;
            Pneu1.PercentualBorracha = 100;
            Pneu1.Cor = "Preto";
            Pneu1.VelocidadeMaxima = 100;
            Pneu1.Estepe = false;
            Pneu1.Estourado = false;
            Pneu1.Tipo = "Carro de passeio";
            Pneu1.TWI = false;
            Pneu1.VelocidadeAtual = 0;

            Pneu1.Exibir();

        }
    }
}