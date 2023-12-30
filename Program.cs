using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia celularNokia = new Nokia("(11) 90000-1234", "nokiaXS", "5106496060", 12000);
Iphone celularIphone = new Iphone("(11) 94321-0000", "Iphone10", "563698963214", 20000);


Console.WriteLine("\n---------------------- Aparelho Nokia ----------------------\n");

celularNokia.Ligar();
celularNokia.ReceberLigacao();
celularNokia.InstalarAplicativo("Discord");


Console.WriteLine("\n\n---------------------- Aparelho Nokia ----------------------\n");

celularIphone.Ligar();
celularIphone.ReceberLigacao();
celularIphone.InstalarAplicativo("Notion");

Console.WriteLine("\n------------------------------------------------------------");
