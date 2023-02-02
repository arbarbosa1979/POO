using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneus Pneu1 = new Pneus(16, 150, "Carro de Passeio", false);

            Pneus Pneu2 = new Pneus(16, 70, "Pneu de Estepe", true);

            Pneu1.Girar(6);
            Pneu2.Girar(6);
            Pneu2.Girar(15);
            Pneu2.Girar(10);
            Pneu2.Frear(5);
            Pneu2.Girar(20);
            Pneu2.Girar(20);
            Pneu2.Girar(5);
            Pneu1.Exibir();
            Console.WriteLine();
            Pneu2.Exibir();

        }
    }
}