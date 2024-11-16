using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero:"123456",modelo:"Modelo1",imei:"11111111",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Clash Royale");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero:"78910",modelo:"Modelo2",imei:"2222222",memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");