using System.Dynamic;
using System.Text.RegularExpressions;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string numero;
        
        public string Numero
        {            
            get { return numero; }
            set 
            {
                // Variáveis para validação do número
                var padraoNumero = new Regex(@"^\d{2}[9]\d{8}$");
                bool verificaPadraoNumero = padraoNumero.IsMatch(value);

                //Validação do número
                if(string.IsNullOrWhiteSpace(value) ||
                   !verificaPadraoNumero) 
                {
                    throw new ArgumentException("Número inválido.");
                }
                else 
                {
                    numero = value;
                }
            }
        }

        private string modelo; 
        private string Modelo
        {            
            get { return modelo; }
            set
            {
                //Variáveis para validação do modelo
                string modelo1 = "NOKIA", modelo2 = "IPHONE";

                //Validação do modelo
                if(value.ToUpper() != modelo1 && value.ToUpper() != modelo2)
                {
                    throw new ArgumentException("Modelo inválido.");
                }
                else modelo = value;
            }            
        }
        
        private string imei;
        private string IMEI 
        { 
            get { return imei; }            
            set
            {
                //Variáveis para validação do imei
                var padraoImei = new Regex(@"^\d{15}$");
                bool verificaPadraoImei = padraoImei.IsMatch(value);

                //Validação do imei
                if(string.IsNullOrWhiteSpace(value) || 
                   !verificaPadraoImei) 
                {
                    throw new ArgumentException("IMEI inválido.");
                }
                else imei = value;              
            }
        }

        private int memoria;
        private int Memoria 
        { 
            get { return memoria; }
            set
            {
                if(value > 0)
                {
                    memoria = value;
                }
                else
                {
                    throw new ArgumentException("Valor de memória inválido.");
                }
            }
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }   

        /***Métodos da classe***/

        //Função para validar os parâmetros dos métodos Ligar e Receber        
        private bool verificarNumeroDeTel(string numeroTel)
        {
            var padraoNumero = new Regex(@"^\d{11}$");
            bool verificaPadraoNumero = padraoNumero.IsMatch(numeroTel);

            if(string.IsNullOrWhiteSpace(numeroTel) ||
               !verificaPadraoNumero) 
            {
                System.Console.WriteLine("Número inválido. Inserir apenas números, incluind DDD.");
                return false;
            }
            else return true;
        }
            
        public void Ligar(string numeroTel)
        {
            if(verificarNumeroDeTel(numeroTel))
            {
                Console.WriteLine($"Ligando para {numeroTel}.");
            }            
        }

        public void ReceberLigacao(string numeroTel)
        {
            if(verificarNumeroDeTel(numeroTel))
            {
                Console.WriteLine($"Recebendo ligação de {numeroTel}.");
            }            
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}