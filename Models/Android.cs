using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartphoneDesafioPOO.Models
{
    public class Android : Smartphone
    {
        public Android(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }
        public override void InstalarApp(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Android via Google Play...");
        }
    }
}