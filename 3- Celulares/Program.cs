using ProjetosEmC_.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("123", "111111111", "Modelo X", 8);
nokia.Ligar();
nokia.InstalarAplicativo("ChatGPT");
Console.WriteLine("\n");
Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone("456", "222222222", "Modelo Y", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("BingAI");
