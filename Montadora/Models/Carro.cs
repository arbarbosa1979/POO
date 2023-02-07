namespace Models
{
    public class Carro
    {
        public string? Fabricante { get; set; } 
        public int Ano { get; set; }
        public string? Modelo { get; set; } 
        public string? Cor { get; set; }    
        public int Odometro { get; set; }   
        public string? Placa { get; set; }  
        public string? Combustivel { get; set; }    
        public string? Especie { get; set; }    
        public string? Tipo { get; set; }
        public int QtdPassageiros { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public int NivelCombustivel { get; set; }
        public bool Ligado { get; set; }
        public Pneus PneuDianteiroEsq { get; set; }
        public Pneus PneuDianteiroDir { get; set; }
        public Pneus PneuTraseiroEsq { get; set; }
        public Pneus PneuTraseiroDir { get; set; }
        public Pneus PneuEstepe { get; set; }

        public Carro(string _fabricante, int _ano, string _modelo, string _cor, string _placa, string _combustivel, string _especie, string _tipo, int _passageiros, int _velocidamaxima)
        {
            Fabricante = _fabricante;
            Ano = _ano;
            Modelo = _modelo;
            Cor = _cor;
            Placa = _placa;
            Combustivel = _combustivel; 
            Especie = _especie;
            Tipo = _tipo;   
            QtdPassageiros = _passageiros;
            VelocidadeMaxima = _velocidamaxima;
            VelocidadeAtual = 0;
            Odometro = 0;
            Ligado = false;
            NivelCombustivel = 0;

            PneuDianteiroEsq = new Pneus(16, 150, "Carro de Passeio");
            PneuDianteiroDir = new Pneus(16, 150, "Carro de Passeio");
            PneuTraseiroEsq = new Pneus(16, 150, "Carro de Passeio");
            PneuTraseiroDir = new Pneus(16, 150, "Carro de Passeio");
            PneuEstepe = new Pneus(16, 70, "Estepe", true);

        }

        public void Ligar()
        {
            if (NivelCombustivel > 0)
            {
                NivelCombustivel = NivelCombustivel - 3;    
                Ligado = true;

                if (NivelCombustivel <= 0)
                {
                    NivelCombustivel = 0;
                    Desligar();
                }
            }
        }

        public void Desligar()
        {
            Ligado = false;
            Parar();
        }

        public void Acelerar(int _impulso)
        {
            if (Ligado == true && _impulso > 0) 
            {
                Odometro += 18;
                NivelCombustivel = NivelCombustivel - 8;

                if (NivelCombustivel <= 0)
                {
                    NivelCombustivel = 0;
                    Desligar();
                    return;
                }

                VelocidadeAtual = VelocidadeAtual + _impulso;
                PneuDianteiroDir.Girar(_impulso);
                PneuDianteiroEsq.Girar(_impulso);
                PneuTraseiroDir.Girar(_impulso);
                PneuTraseiroEsq.Girar(_impulso);
                if (PneuDianteiroDir.Estourado || PneuDianteiroEsq.Estourado || PneuTraseiroDir.Estourado || PneuTraseiroEsq.Estourado)
                {
                    Parar();
                }
            }

        }

        public void Parar()
        {
            VelocidadeAtual = 0;
            PneuDianteiroDir.VelocidadeAtual = 0;
            PneuDianteiroEsq.VelocidadeAtual = 0;
            PneuTraseiroDir.VelocidadeAtual = 0;
            PneuTraseiroEsq.VelocidadeAtual = 0;
        }
        public void Frear(int _reduzir)
        {
            VelocidadeAtual = VelocidadeAtual - _reduzir;

            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0; 

            PneuDianteiroDir.Frear(_reduzir);
            PneuDianteiroEsq.Frear(_reduzir);
            PneuTraseiroDir.Frear(_reduzir); 
            PneuTraseiroEsq.Frear(_reduzir);
        }
        /// <summary>
        /// Este método vai abastecer o carro
        /// </summary>
        /// <param name="_quantidadeCombustivel">Informe o percentual de combustível que deseja abastecer, caso informe
        /// 0 o método irá completar o tanque. O valor não pode ser superior a 100</param>
        public void Abastecer(int _quantidadeCombustivel = 0)
        {
            if (_quantidadeCombustivel == 0)
                _quantidadeCombustivel = 100 - NivelCombustivel;

            if (NivelCombustivel + _quantidadeCombustivel > 100)
            {
                Console.WriteLine("A quantidade de combustível ultrapassa o limite do tanque");
                    return;
            }

            if (NivelCombustivel < 100)
                NivelCombustivel = NivelCombustivel + _quantidadeCombustivel;
        }

        public void Exibir()
        {
            Console.Clear();

            Console.WriteLine("Fabricante: " + Fabricante);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Odometro: " + Odometro);
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("Combustivel: " + Combustivel);
            Console.WriteLine("Especie: " + Especie);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("QtdPassageiros: " + QtdPassageiros);
            Console.WriteLine("VelocidadeMaxima: " + VelocidadeMaxima);
            Console.WriteLine("VelocidadeAtual: " + VelocidadeAtual);
            Console.WriteLine("NivelCombustivel: " + NivelCombustivel);
            Console.WriteLine("Ligado: " + Ligado);

            Console.WriteLine("\nPneuDianteiroEsq");
            PneuDianteiroEsq.Exibir();
            Console.WriteLine("\nPneuDianteiroDir");
            PneuDianteiroDir.Exibir();
            Console.WriteLine("\nPneuTraseiroEsq");
            PneuTraseiroEsq.Exibir();
            Console.WriteLine("\nPneuTraseiroDir");
            PneuTraseiroDir.Exibir();
            Console.WriteLine("\nPneuEstepe");
            PneuEstepe.Exibir();

        }

    }
}
