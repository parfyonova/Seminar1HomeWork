// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2){
    int max = num1;
    Console.WriteLine($"{num1} больше, чем {num2}");
}
else {
    Console.WriteLine($"{num2} больше, чем {num1}");
}
*/



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine()!);
int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine($"{max} является максимальным числом");
*/


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num % 2 == 0){
    Console.WriteLine($"{num} является чётным числом");
}
else {
    Console.WriteLine($"{num} является нечётным числом");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = 2;
while (result <= num){
    Console.WriteLine(result);
    result += 2;
}
*/
