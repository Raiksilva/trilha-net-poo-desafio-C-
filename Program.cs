using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(numero: "3541", modelo: "Modelo1", imei: "111112222", memoria: 32);
Nokia.InstalarAplicativo("Whatsapp");
Nokia.Ligar();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone(numero: "5555", modelo: "Iphone 11 pro max", imei: "755228922", memoria: 256);
Iphone.InstalarAplicativo("Whatsapp");
Iphone.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Iphone.LigaçaoRecebida();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Nokia.LigaçaoAtendida();