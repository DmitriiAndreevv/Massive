/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.Clear();

Console.WriteLine("задайте длину массива: ");
int numbers = int.Parse(Console.ReadLine());

int [] GetArray(int numbers){
    
    int [] array = new int [numbers];
    int min = 100;
    int max = 1;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,1000);  

        if(array[i] > max)
        {
         max = array[i];
        }
        else
        {
            if(array[i]< min)
            {
                min = array[i];
            }
        }
    }
Console.WriteLine($"всего {numbers} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine("Разница между макс и мин: {0}", max - min);
return array;  
}
void Num2(int [] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i] + " ");
    }
Num2(numbers);
}

GetArray(numbers);






