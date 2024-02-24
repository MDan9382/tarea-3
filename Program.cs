int dn;
Console.WriteLine("ingrese el dia de la semana en numeros (1-7)");
dn = Convert.ToInt16(Console.ReadLine());
switch (dn)
{
    case 1:
        Console.WriteLine("hoy es lunes");
        break;
    case 2:
        Console.WriteLine("hoy es martes");
        break;
    case 3:
        Console.WriteLine("hoy es miercoles");
        break;
    case 4:
        Console.WriteLine("hoy es jueves");
        break;
    case 5:
        Console.WriteLine("hoy es viernes");
        break;
    case 6:
        Console.WriteLine("hoy es sabado");
        break;
    case 7:
        Console.WriteLine("hoy es domingo");
        break;
    default:
        Console.WriteLine("COMANDO INVALIDO");
        break;
}