using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone NOKIA:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111122223333", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPHONE:");
Smartphone iphone = new Iphone(numero: "7890123", modelo: "Modelo h", imei: "666677778888", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
