using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*         Pneus Pneu1 = new Pneus(16, 150, "Carro de Passeio", false);

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
           */

            Carro fusca = new Carro("Volkswagen", 1994, "Itamar Franco", "Azul", "", "Alcool", "Passageiro", "Automóvel", 5, 150);

            fusca.Abastecer(80);
            fusca.Ligar();
            fusca.Acelerar(15);
            fusca.Acelerar(5);
            fusca.Acelerar(22);
            fusca.Frear(8);
            fusca.Acelerar(3);
            fusca.Frear(4);
            fusca.Desligar();
            fusca.PneuDianteiroEsq = fusca.PneuEstepe;
            fusca.Ligar();
            fusca.Acelerar(15);
            fusca.Acelerar(5);
            fusca.Acelerar(22);
            fusca.Frear(8);
            fusca.Acelerar(3);
            fusca.Frear(4);
            fusca.Acelerar(3);
            fusca.Acelerar(3);
            fusca.Acelerar(3);
            fusca.Abastecer(80);
            fusca.Ligar();
            fusca.Acelerar(40);
            fusca.Acelerar(29);
            fusca.Acelerar(1);
            fusca.Acelerar(1);
            fusca.Exibir();
        }
    }
}