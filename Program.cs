/*
Задача 2. Напишите программу, которая на вход
принимает два числа и выдает, какое число большее, 
а какое меньшее
*/
//=============== task 2 ========================
/*Console.Clear();

Console.Write("Input first number: ");
int number1  = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int number2  = Convert.ToInt32(Console.ReadLine());

if(number1>number2) Console.Write("first number is maximus, second number is minimal.");
else Console.Write("first number is minimal, second number is maximus.");
*/

/*
Задача 4. Напишите программу, которая принимает
на вход три числа и выдает максимальное из этих чисел
*/
//=============== task 4 ========================
/*
Console.Clear();

Console.Write("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxNumber = number1;
if(number2 > maxNumber) maxNumber = number2;
if(number3 > maxNumber) maxNumber = number3;

Console.Write("\n");
Console.WriteLine($"The entered number {maxNumber}" + " is maximum \n");
*/

/*
Задача 6. Напишите программу, которая на вход принимает
число и выдает, является ли данное число четным
(делится без остатка).
*/
//=============== task 6 ========================
/*
Console.Clear();

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.Read());

if (number%2 == 0) Console.Write("The enterd number is even number.\n");
else Console.Write("The enterd number is odd number.\n");
*/

/*
Задача 8. Напишите программу, которая на вход принимает 
число (N), а на выходе показывает все четные числа от 1 до N.

*/

//=============== task 8 ========================
Console.Clear();

Console.Write("Enter a number: ");

int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count<=number){
    if (count%2==0){
        if(count<number-1)   Console.Write($"{count}, ");
        else Console.Write(count);
    }
    count+=2;
}
