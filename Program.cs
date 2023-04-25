Console.WriteLine("Введите элементы массива через пробел:");
string[] array = Console.ReadLine().Split(' ');
string[] newArray = new string[array.Length];
int index = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[index] = array[i];
        index++;
    }
}

Array.Resize(ref newArray, index);

Console.WriteLine("Исходный массив строк:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine("Новый массив строк:");
for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine(newArray[i]);
}

Console.ReadLine();
