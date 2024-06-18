// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] stringg = {"esc", "tab", "caps lock", "shift", "ctrl", "fn"};
string[] outputStr = new string[0];

foreach (string item in stringg)
{
    if (item.Length < 4)
    {
        Array.Resize(ref outputStr, outputStr.Length + 1);
        outputStr[outputStr.Length - 1] = item;
    }
}