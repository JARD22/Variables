// See https://aka.ms/new-console-template for more information

//NUMBERS
int edad = 10;
int distance = 150_000_000;

uint uintNumber = 3_000_000_000; // 0 to 4 billions
int largestNumber = int.MaxValue;

byte smallNumber = 14; // 0 to 255;
sbyte smallNumber2 = 100; // -128 to 127;

short shortNumber = 30_000; // -32,768 to 32,767;
ushort ushortNumber = 65_000; // 0 to 65,535;

long longNumber = 8_000_000_000_000;
ulong ulongNumber = 16_000_000_000_000;


float floatNumber = 180.24f; // ocupa 4 bytes; precisión de 6 a 9 dígitos;
double doubleNumber = 45.99; // ocupa 8 bytes; precisión de 15 a 17 dígitos;
decimal decimalNumber = 9.99m; // ocupa 16 bytes; Precision de 28 a 29 d[igitos (recomendados para temas financieros);


bool booleanNumber = false;


//STRINGS

char charExmple = 'A';

string text = "Mi amigo me dijo un vez: \"me caes bien \"";
string scape = "En C3 podemos usar \\ para escapar strings";

string email = @"Los string verbatim
                 nos permiten escibir en varias lineas incluidos caracteres especiales #$!";

//DATE TIME

DateTime now = DateTime.Now;
DateTime firstDayOfYear = new DateTime(2023, 1, 1);
DateTime tomorrow = DateTime.Now.AddDays(1);

/*Console.WriteLine(now.ToString());
Console.WriteLine(firstDayOfYear);   
Console.WriteLine("Mañana es día:"+ tomorrow.DayOfWeek);
*/
//valores por defecto:

int number = default;
string name = default;


// Los tipos de dato de valor pueden comportarse como null cuando se coloca un "?" al final del tipo de dato 
int? no = null;
string letter = null;

/*Console.WriteLine(email);
Console.WriteLine(edad);
Console.WriteLine(distance);
Console.WriteLine(largestNumber);*/


var cantidad1 = 5.4;
var cantidad2 = 15.5;
var resultadoSuma = cantidad1 + cantidad2;
var resultadoResta = cantidad1 - cantidad2;
var resultadoMultiplicacion = cantidad1 * cantidad2;
var resultadoDivision = cantidad1 / cantidad2;
var resultadoResiduo = cantidad1 % cantidad2;


Console.WriteLine($"La suma de {cantidad1} y {cantidad2} es " + resultadoSuma);
Console.WriteLine($"La resta de {cantidad1} y {cantidad2} es " + resultadoMultiplicacion);
Console.WriteLine($"La multiplicacion de {cantidad1} y {cantidad2} es " + resultadoDivision);
Console.WriteLine($"La division de {cantidad1} y {cantidad2} es " + resultadoResiduo);
Console.WriteLine($"El residuo de {cantidad1} y {cantidad2} es " + resultadoSuma);


