using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Teste do Smartphone nokia");
Smartphone nokia = new Nokia(numero: "95555-6666", modelo: "model", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("telegram");


Console.WriteLine("Teste do Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "88888-0101", modelo: "model", imei: "123456789", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("kwai");
