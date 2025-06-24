using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando Nokia\n");

Nokia n = new Nokia("22987654321", "Aphla_01", "0000000000", 256);
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nTestando Iphone\n");

Iphone i = new Iphone("22123456789", "Iphone PRO MAX 18" , "1111111111", 1024);
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Telegram");