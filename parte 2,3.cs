string s;
Console.WriteLine("ingrese el servicio que desea pagar");
Console.WriteLine(" 1)lavado de auto\n2)revision mecanica\n3)cambio de aceite");
s = Console.ReadLine().ToUpper();
switch (s)
{
    case "1" or "LAVADO DE AUTO":
        Console.WriteLine("el importe a pagar es de Q40");
        break;
    case "2" or "REVISION MECANICA":
        Console.WriteLine("el importe a pagar es de Q200");
        break;
    case "3" or "CAMBIO DE ACEITE":
        Console.WriteLine("el importe a pagar es de Q100");
        break; //no se cuanto valen estas cosas... no tengo carro :(
    default: 
        Console.WriteLine("COMANDO INVALIDO");
        break;
}