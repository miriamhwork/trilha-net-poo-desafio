using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "987654321", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");