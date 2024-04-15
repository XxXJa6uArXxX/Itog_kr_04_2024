using System;
using System.Diagnostics.CodeAnalysis;

class Prog
{
    static void Main()
   
 {

Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.WriteLine("Введите количество строк в массиве:");
int N = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[N];

for (int i = 0; i < N; i++)

 {
            Console.WriteLine($"Введите элементы для {i+1} строки:");
            arr[i] = Console.ReadLine();
 }


int count = 0;

for (int j = 0; j < N; j ++)

if (arr[j].Length <= 3)

    {
        count++;
        
    }

Console.WriteLine("Количество строк, меньше или равных 3 символам =" + " " + count);

int index = 0;

string[] res = new string[count];

foreach (var qual in arr)

if (qual.Length <= 3)

{

res[index++] = qual;

}

Console.WriteLine("Итоговый массив:" + " " );

foreach (var qual in res)

{

Console.Write(qual + " ");

}

Console.WriteLine("");

}

}