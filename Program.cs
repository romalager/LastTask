// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// string[] stringg = {"esc", "tab", "caps lock", "shift", "ctrl", "fn"};
string?[] stringg = new string[0];
string? temp = "trident";
Console.WriteLine("Enter strings (empty - '', to stop): ");
while (true)
{
    temp = Console.ReadLine();
    if (temp != "")
    {
        Array.Resize(ref stringg, stringg.Length + 1);
        stringg[stringg.Length - 1] = temp;
    }
    else break;
}


string[] outputStr = new string[0];

foreach (string? item in stringg)
{
    if (item?.Length < 4)
    {
        Array.Resize(ref outputStr, outputStr.Length + 1);
        outputStr[outputStr.Length - 1] = item;
    }
}

Console.WriteLine("[" + string.Join(", ", stringg) + "]");
Console.Write("=> [" + string.Join(", ", outputStr) + "]");