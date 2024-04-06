// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// declaracion de variables
string nombres;
int edad;
float sueldo;
bool escasado;

// asignando valores

 nombres =  "Marlon san Juan Huaringa";
 edad = 31 ;
 sueldo = 10000;
 escasado =  false;

// imprimiendo variables

//Console.WriteLine("=============================================");
//Console.WriteLine(" ");
//Console.WriteLine("Nombres: "+nombres);
//Console.WriteLine("Mi edad: "+edad);
//Console.WriteLine("Mi sueldo: "+sueldo);
//Console.WriteLine("Soy casado: "+escasado);
//Console.WriteLine(" ");
//Console.WriteLine("=============================================");

//// Manejo de fechas
//DateTime fechaDeHoy  = DateTime.Now;
//Console.WriteLine(fechaDeHoy);
//Console.WriteLine(fechaDeHoy.ToLongDateString());
//Console.WriteLine(fechaDeHoy.ToShortDateString());


// condicionales


if (edad >= 18 )
{
    Console.WriteLine("Es Mayor de edad");
}
else
{
    Console.WriteLine("Es menos de edad");
}

if (sueldo > 1000)
{
    Console.WriteLine("Eres millonario");
}
else
{
    Console.WriteLine("Ponte lkas pilas y ganaras mas dinero");
}
