// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string[] CreateArray()
{
    Console.Write("Введите количество элементов массива: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[num];

    for(int i=0; i<array.Length; i++)
    {
        System.Console.Write($"Введите значение {i+1}-го элемента массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] array = CreateArray();

void PrintArray(string[] array)
{
    string str = string.Join(", ", array);
    System.Console.WriteLine("Введенные Вами значения: " + "[" + str + "]");
}

PrintArray(array);

void ModifyArray(string[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] array2 = new string[count];
    int j = 0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i].Length <= 3)
            {
            array2[j] = array[i];
            j += 1;
            }
    }
    string str2 = string.Join(", ", array2);
    System.Console.WriteLine("Значения нового массива: " + "[" + str2 + "]");
}

ModifyArray(array);


