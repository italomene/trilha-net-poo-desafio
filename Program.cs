using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Resolução:
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1234", modelo: "01", imei: "1111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPHONE: ");
Smartphone iphone = new Iphone(numero: "1234", modelo: "01", imei: "1111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");