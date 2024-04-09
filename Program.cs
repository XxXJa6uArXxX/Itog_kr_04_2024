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

}

}