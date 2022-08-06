string[] arrayString = new string[] { "привет", "как", "дела", "?", ";-)" };

int amountOfSymbols = 0;
int count = 0;

for (int i = 0; i < arrayString.Length; i++)                 //Найдем количество ячеек с длиной строки <=3
{
    amountOfSymbols = arrayString[i].Length;
    if (amountOfSymbols <= 3)
    {
        count++;
    }
}

string[] arrayTreeSymbols = new string[count];               //Создадим массив с длинной равной count

count = 0;

for (int i = 0; i < arrayString.Length; i++)                 //Подставим нужные значения в новый массив
{
    amountOfSymbols = arrayString[i].Length;
    if (amountOfSymbols <= 3)
    {
        arrayTreeSymbols[count] = arrayString[i];
        count++;
    }
}

var str = string.Join(", ", arrayTreeSymbols);
Console.WriteLine($"[{str}]");