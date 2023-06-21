// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = GetThirdDigit(number);

        if (result != -1)
        {
            Console.WriteLine($"Третья цифра числа {number} равна {result}");
        }
        else
        {
            Console.WriteLine($"У числа {number} нет третьей цифры");
        }

        Console.ReadLine();

    int GetThirdDigit(int number)
    {
        if (number < 100)
        {
            return -1; // числа меньше 100 не имеют третьей цифры
        }

        number /= 100; // удаляем первые две цифры
       
        int thirdDigit = number % 10; // находим третью цифру

        return thirdDigit;
    }