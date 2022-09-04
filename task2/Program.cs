/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

Console.Clear();

Console.WriteLine("задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int count =0;
int [] array = GetArray(number,3,30);

Console.WriteLine(String.Join(" ",array));
int [] GetArray(int size,int min, int max){
    int[] number = new int[size];
   

for (int r = 0; r < size; r++)
{
    number[r] = new Random().Next(min,max +1);    
}
return number;
}
int FindNumber(int []array)
{
    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum += array[i];
        while(count >= sum)
        {
             if(array[i] % 2 == 0)
             {
                sum += array[i];
                 sum++;
             }
             else
             {
                count += array[i];
                 count++;
             }
        }

    }
    return sum;
}
Console.Write($"сумма элементов стоящих на нечётных позициях: ");
Console.WriteLine(FindNumber(array));

    