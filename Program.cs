using DesafioPOO.Models;

Smartphone nokia = new Nokia("+5511998765432", "LG", "353917092827493", 2000);

Console.WriteLine($"Número: {nokia.Numero}");
Console.WriteLine($"Modelo: {nokia.Modelo}");
Console.WriteLine($"IMEI: {nokia.IMEI}");
Console.WriteLine($"Memória: {nokia.Memoria}");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Skype");

Console.WriteLine("============================================================");

Smartphone iphone = new Iphone("+5521987654321", "LG", "356923048521470", 3000);

Console.WriteLine($"Número: {iphone.Numero}");
Console.WriteLine($"Modelo: {iphone.Modelo}");
Console.WriteLine($"IMEI: {iphone.IMEI}");
Console.WriteLine($"Memória: {iphone.Memoria}");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Skype");