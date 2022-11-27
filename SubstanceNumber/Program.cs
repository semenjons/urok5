// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

double min = Int32.MaxValue;
double max = Int32.MinValue;
 
    for (int z = 0; z < randomArray.Length; z++)
    {
        if (randomArray[z] > max)
            {
                max = randomArray[z];
            }
        if (randomArray[z] < min)
            {
                min = randomArray[z];
            }
    }

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

