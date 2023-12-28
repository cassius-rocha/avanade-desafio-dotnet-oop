using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        //Invocando construtores da classe base
        public Iphone(string numero, string modelo, string imei, int memoria) :
               base(numero, modelo, imei, memoria) 
        {
        }

        //Sobrescrevendo método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando aplicativo {nomeApp}.");
        }
    }    
}