Console.WriteLine("Введите A, B");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int S = 0;
int uslovie (int M)
{
    for (int i = A; i <= M; i++)
    {
        if ((i % 5 == 0) && (i % 7 == 0))
        {
            S += i;
        }
    }
    return S;
}
Console.WriteLine(uslovie(B));