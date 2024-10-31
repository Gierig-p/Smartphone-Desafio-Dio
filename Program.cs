
using SmartphoneDesafioPOO.Models;

Smartphone meuAndroid = new Android("81987654321", "Samsung Galaxy", "123456789012345", 128);

Console.WriteLine("Smartphone Android:");

meuAndroid.Liga();
meuAndroid.InstalarApp("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");

Smartphone meuIphone = new Iphone("81912345678", "iPhone 13", "987654321098765", 64);

meuIphone.ReceberLigacao();
meuIphone.InstalarApp("Telegram");