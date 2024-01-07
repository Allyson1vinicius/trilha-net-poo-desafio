using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "0912", modelo: "Modelo 1", imei: "123456", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "3456", modelo: "Modelo 2", imei: "232323", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");
// TODO: Realizar os testes com as classes Nokia e Iphone