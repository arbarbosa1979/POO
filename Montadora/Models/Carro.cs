using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Carro(string _fabricante, int _ano, string _modelo, string _cor, string _placa, string _combustivel, string _especie, string _tipo, int _passageiros)
        {
            Odometro = 0;
            Ligado = false;
            NivelCombustivel = 0;

            PneuDianteiroEsq = new Pneus(16, 150, "Carro de Passeio");
            PneuDianteiroDir = new Pneus(16, 150, "Carro de Passeio");
            PneuTraseiroEsq = new Pneus(16, 150, "Carro de Passeio");
            PneuTraseiroDir = new Pneus(16, 150, "Carro de Passeio");
            PneuEstepe = new Pneus(16, 70, "Estepe", true);

        }
        

        

    }
}
