// See https://aka.ms/new-console-template for more information
int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

PrintNumbers("Numbers", Numbers);
PrintNumbers("Even No", Numbers.Where(X=>IsEven(X)));
PrintNumbers("Odd No", Numbers.Where(X=>IsOdd(X)));

void PrintNumbers(string Title, IEnumerable<int>Numbers)
{
    System.Console.WriteLine();
    System.Console.Write(Title + "[");
    foreach (var item in Numbers)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.Write("]\n");
}




bool IsEven(int Number) => Number % 2 == 0;


bool IsOdd(int Number) => !IsEven(Number);