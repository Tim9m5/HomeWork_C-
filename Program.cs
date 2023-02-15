// First task
// Console.Write("Введите первое число: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondValue = Convert.ToInt32(Console.ReadLine());

// if (firstValue < secondValue)
// {
//     Console.WriteLine("Второе число больше первого: " + secondValue + " > " + firstValue);
// }
// else
// {
//     Console.WriteLine("Первое число больше второго: " + firstValue + " > " + secondValue);
// }



// Second task
// Console.Write("Введите первое число: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int thirdValue = Convert.ToInt32(Console.ReadLine());

// if (firstValue > secondValue)
// {
//     if (firstValue > thirdValue)
//     {
//         Console.Write("Первое число максимальное");
//     }
//     else
//     {
//         if (secondValue > thirdValue)
//         {
//             Console.Write("Второе число максимальное");
//         }
//         else
//         {
//             Console.Write("Третье число максимальное");
//         }
//     }
// }
// else
// {
//     if (secondValue > thirdValue)
//         {
//             Console.Write("Второе число максимальное");
//         }
//         else
//         {
//             Console.Write("Третье число максимальное");
//         }
// }



// Third task
// Console.Write("Введите число для проверки на четность: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// {
//     Console.WriteLine("Число " + number + " является четным ");
// }
// else
// {
//     Console.WriteLine("Число " + number + " является нечетным ");
// }



// Fourth task
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N == 2)
{
    Console.WriteLine(N);
}
else
{
    int number = 2;
    while (number <= N)
    {
        Console.WriteLine(number);
        number = number + 2;
    }

}
