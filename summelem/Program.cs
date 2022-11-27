// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



int lenArray = ReadInt("Введите число которое будет означать длинну массива: ");
int[] randomArray = new int[lenArray];

for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(0,100);
        Console.Write(randomArray[i] + " ");
    }

int ReadInt(string mass)
{
    Console.Write(mass);
    return Convert.ToInt32(Console.ReadLine());
}

int sum = 0;

for (int z = 0; z < randomArray.Length; z+=2)
    sum = sum + randomArray[z];

    Console.WriteLine($"всего {randomArray.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");
