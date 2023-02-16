// Задача 41: Пользователь вводит с клавиатуры 
// M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();


Console.Write("Enter the elements number of your massive:\t");
int index = int.Parse(Console.ReadLine()!);
int[] newArray = new int[index];
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write($"Enter the number for element {i} of your massive:\t");
    newArray[i] = int.Parse(Console.ReadLine()!);
}
Console.WriteLine("Your massive is: ");
for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine(newArray[i]);
}

int result = 0;
for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i] < 0) result++;
}

Console.WriteLine($"The quantity of positive numbers is {result}");


