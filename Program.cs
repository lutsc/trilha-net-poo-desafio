using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("\nSmartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "111-111-111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.Write("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "67890", modelo: "Modelo 2", imei: "222-222-222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.Write("\n");