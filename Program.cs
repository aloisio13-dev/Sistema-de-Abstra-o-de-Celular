// See https://aka.ms/new-console-template for more information
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia (numero: "1222222233", modelo:  "01", imei: "1111110000000111122", memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("Tictoc");

Console.WriteLine("Smartfhone Ifhone");
Smartphone ifhone = new Iphone (numero: "22258888888", modelo: "02", imei: "111122333331111111122", memoria:254 );
ifhone.Ligar();
ifhone.InstalarAplicativo("Tictoc");
