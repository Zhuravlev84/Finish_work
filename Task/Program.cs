/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

string[] firstArray = new string[6] { "hello", "978", "yes", "world", "no", "finish" };
int limit = 3;
int count = 0;
string[] tempArray = new string[firstArray.Length];
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= limit)
    {
        tempArray[count] = firstArray[i];
        count++;
    }
}
string[] secondArray = new string[count];
for (int i = 0; i < secondArray.Length; i++)
{
    secondArray[i] = tempArray[i];
}

Console.Write($"[{String.Join(", ", firstArray)}] --> ");
Console.Write($"[{String.Join(", ", secondArray)}]");