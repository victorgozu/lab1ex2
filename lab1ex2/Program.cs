/*
 * Ex2
Scrieti un program care va calcula media aritmetica a trei numere citite de la
tastatura
*/

Console.WriteLine("Va rugam introduceti valoarea primului numar:");
int numar1 = int.Parse(Console.ReadLine());

Console.WriteLine("Va rugam introduceti valoarea celui de-al doilea numar:");
int numar2 = int.Parse(Console.ReadLine());

Console.WriteLine("Va rugam introduceti valoarea celui de-al treilea numar:");
int numar3 = int.Parse(Console.ReadLine());

int medieAritmetica = (numar1 + numar2 + numar3) / 3;

Console.WriteLine("Media aritmetica a celor 3 numere este: " + medieAritmetica);