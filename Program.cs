using DesafioPOO.Models;

Console.WriteLine("Smatphone - Nokia:");
Smartphone nokia = new Nokia();
nokia.numero = "1111-2222";
nokia.Modelo = "M1";
nokia.IMEI = "145236";
nokia.Memoria = "128GB";
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Uber");

Console.WriteLine("\nSmatphone - Iphone:");
Smartphone iphone = new Iphone();
iphone.numero = "5555-6666";
iphone.Modelo = "I1";
iphone.IMEI = "745896";
iphone.Memoria = "64GB";
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");