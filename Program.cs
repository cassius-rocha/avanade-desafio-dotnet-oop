using DesafioPOO.Models;

/*** TESTES NOKIA ***/

//Instância de Nokia atendendo aos parâmetros dos construtores
Nokia n1 = new("11933171537", "nokia", "111111111111111", 64);

//Testes dos métodos
n1.Ligar("11111111111");
n1.ReceberLigacao("11111111111");
n1.InstalarAplicativo("DIO Learn");

//Instância de Nokia sem atender aos parâmetros dos construtores
Nokia n2 = new("11865412321", "samsumg", "1111111111", -1);

/*** TESTES IPHONE ***/

//Instância de Iphone atendendo aos parâmetros dos construtores
Iphone i1 = new("11933171537", "iphOnE", "111111111111111", 64);

//Testes dos métodos
i1.Ligar("11111111111");
i1.ReceberLigacao("11111111111");
i1.InstalarAplicativo("DIO Learn");

//Instância de Iphone sem atender aos parâmetros dos construtores
Nokia i2 = new("11865412321", "samsumg", "1111111111", -1);