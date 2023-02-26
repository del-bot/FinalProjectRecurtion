int SumDigits(int m, int n)
{
    if (m > n) return (m + n)*(m - n + 1)/2;
    if (n > m) return (n + m)*(n - m + 1)/2;
    return 1;
}
Console.WriteLine("input number M: ");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number N: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());
int res = SumDigits(userNumberM, userNumberN);
Console.Write(res);