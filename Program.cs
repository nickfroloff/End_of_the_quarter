Console.WriteLine("*************************************************************");
Console.WriteLine("Введите количество строк массива: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = new string[num];
int arrayLength = 0;
for (int i = 0; i < num; i++)
{
    Console.WriteLine($"Введите содержимое {i + 1} строки массива: ");
    array[i] = Console.ReadLine(6);
    if (array[i].Length <= 3)
        arrayLength++;
}
if (arrayLength > 0)
{
    string[] arrayNew = new string[arrayLength];
    Console.WriteLine("Массив из элементов, длина которых меньше или равна 3 символам: ");
    int indexNew = 0;
    for (int i = 0; i < num; i++)
    {
         if (array[i].Length <= 3)
        {
            arrayNew[indexNew]=array[i];
            Console.WriteLine($"Это {indexNew+1} элемент массива: {arrayNew[indexNew]}");
            indexNew++;
        }
    }
}
else
    Console.WriteLine("Не было ни одного элемента меньше 3х символов длиной.");
Console.WriteLine("****************************************************************");