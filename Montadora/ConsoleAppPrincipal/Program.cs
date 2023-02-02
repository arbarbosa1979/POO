using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneus Pneu1 = new Pneus(16, 150, "Carro de Passeio", false);
            Pneu1.Aro = 16;
            Pneu1.VelocidadeMaxima = 100;
            Pneu1.Estepe = false;
            Pneu1.Tipo = "Carro de passeio";


            Pneus Pneu2 = new Pneus();
            Pneu2.Aro = 16;
            Pneu1.VelocidadeMaxima = 70;
            Pneu1.Estepe = true;
            Pneu1.Tipo = "Pneu de Estepe";

            Pneu1.Girar(6);
            Pneu2.Girar(6);
            Pneu2.Girar(6);
            Pneu2.Girar(6);
            Pneu2.Frear(5);

            Pneu1.Exibir();

            Pneu2.Exibir();

        }
    }
}