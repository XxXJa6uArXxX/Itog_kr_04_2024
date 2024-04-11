using System;

class Prog
{
    static void Main()
   
 {

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

Console.WriteLine("Количество строк меньше или равных 3 символам =" + " " + count);

int index = 0;

string[] res = new string[count];

for (int l = 0; l < N; l++)

if (arr[l].Length <= 3)

{

res[index++] = Convert.ToString(arr[l]);

}

Console.WriteLine("Итоговый массив:" + " " + res);

}

}