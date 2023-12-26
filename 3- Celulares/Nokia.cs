using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetosEmC_.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public  Nokia(string numero, string imie, string modelo, int memoria) : base(numero, imie, modelo, memoria)
        {

        }           
        public override void InstalarAplicativo(string nomeApp) {
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no Nokia");
        }
    } 
}