// See https://aka.ms/new-console-template for more information
// 1. Объявление переменных
string[] myArray; // ссылка на массив строк
int count; // текущее количество строк в массиве
string s;
string[] myArray2; // дополнительная переменная-ссылка - сохраняет старый массив строк

// 2. Цикл ввода строк
Console.WriteLine("введите элемнты массива:");
Console.WriteLine("Для прекращения ввода введите пустую строку");

count = 0; // обнулить количество строк
myArray = new string[count]; // выделить память для 0 строк

do
{
    // Ввести строку
    s = Console.ReadLine();

    // Проверка, пустая ли строка
    if (s != "")
    {
        // если строка не пустая, то добавить строку в массив
        count++;

        // предварительно выделить память для нового массива
        // в котором на 1 элемент больше
        myArray2 = new string[count];

        // скопировать старый массив в новый
        for (int i = 0; i < myArray2.Length - 1; i++)
            myArray2[i] = myArray[i];

        // добавить последнюю введенную строку в массив AS2
        myArray2[count - 1] = s;

        // Освобождать память, предварительно выделенную под AS не нужно,
        // этим занимается сборщик мусора

        // перенаправить ссылку AS на AS2
        myArray = myArray2;
    }
} while (s != "");

// 3. Вывод массива строк AS в цикле
Console.Write("[");
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length <= 3)
    {

        if (i != 0) Console.Write(", ");
        else Console.Write("");
        Console.Write(myArray[i]);
    }
}
Console.Write("]");



