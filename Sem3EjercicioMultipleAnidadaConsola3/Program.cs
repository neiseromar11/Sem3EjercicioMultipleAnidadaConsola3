// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese categoria (A , B , C , D )");
string cat=Console.ReadLine();
Console.WriteLine("Ingrese su sueldo ");
float sueldoAc=float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese numero de hijos ");
int numHijos=int.Parse(Console.ReadLine());

float imcremento = 0.0f;
switch (cat)
{
    case "A":
        // imcremento en 25 %
        imcremento = 0.25f;
        break;

    case "B":
        //incremento en 20 % 
        imcremento = 0.20f;
        break;
    case "C":
        //incremento en 15 %
        imcremento = 0.15f;
        break;
    case "D":
        //incremento en 10 % 
        imcremento = 0.10f;
        break;
    default:
        //categoria no valida
        Console.WriteLine("Categoria no valida");
        break;

}

float aumento = (sueldoAc * imcremento) + sueldoAc;

//Console.WriteLine(aumento);
float imcrementohijos = numHijos * 0.025f;
float nuevoSueldo = (aumento * imcrementohijos) + aumento;

float impuesto = 0.0f;
float totalNeto=0.0f;
Console.WriteLine(nuevoSueldo);
if (nuevoSueldo > 2000)
{
    impuesto = nuevoSueldo * 0.03f;
    totalNeto = nuevoSueldo - impuesto;

}
Console.WriteLine("El imcremento de sueldo es: "+ aumento 
    +"\nEl aumento por hijos es: "+ nuevoSueldo
    +"\nEl descuento es: "+impuesto);
Console.WriteLine("El sueldo neto es: "+totalNeto);

