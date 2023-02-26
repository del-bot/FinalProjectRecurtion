int AkkermanFunction (int m, int n)
{
    if (m == 0) return n+1;
    if (n == 0) return AkkermanFunction(m-1,1);
    else return AkkermanFunction((m-1), AkkermanFunction(m, n-1));
}
Console.WriteLine("input number M: ");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number N: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());
int res = AkkermanFunction (userNumberM, userNumberN);
Console.Write(res);
