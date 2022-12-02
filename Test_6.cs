//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
 //является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

double numberA = new Random().Next(-1000, 1000);
Console.WriteLine(numberA);


if (numberA%2==0) Console.WriteLine("Число четное");
if (numberA%2==1) Console.WriteLine("Число нечетное");

    




