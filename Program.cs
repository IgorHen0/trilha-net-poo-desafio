using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("(31) 98716-0074", "Iphone 12", "123456789", 128);
Nokia nokia = new Nokia("(31) 98716-0074", "Nokia 3310", "987654321", 64);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");