using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123","Nk026","0123456789",1234);
nokia.Ligar();
nokia.InstalarAplicativo("GOOGLE");
nokia.ReceberLigacao();

Console.WriteLine();
Console.WriteLine();

Iphone iphone = new Iphone("123","12","0123456789",1234);
iphone.Ligar();
iphone.InstalarAplicativo("Apple Music");
nokia.ReceberLigacao();
