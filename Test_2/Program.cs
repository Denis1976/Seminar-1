Console.WriteLine("Привет! Введи любое целое число!");
int N = Convert.ToInt32(Console.ReadLine());
for(int P = -N; P <= N; P++)
{
    Console.WriteLine(P);
}
Console.WriteLine("Повторим еще раз?");