using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
var nokia = new Nokia("1234","nokia 01", "123456789", 4);

nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("jogo 1");

var iphone = new Iphone("4321","iphone teste", "987654321", 6);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");