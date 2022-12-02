//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

int numberA = new Random().Next(1, 30);    // 1  2 ... 30
Console.WriteLine("четные числа от 1 до "  +numberA);

int counter = 1 ;


while (counter<=numberA)
{
   if (counter%2==0) Console.WriteLine(counter);
   counter = counter + 1 ;
}





