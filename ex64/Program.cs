void ShowNumberMN (int m, int n)
{ 
    
    if (n<0)  Console.WriteLine("wrong number");
    else if (Math.Min(m,n) != Math.Max(m,n)) ShowNumberMN (Math.Min(m,n)+1, Math.Max(m,n));
    Console.Write($"{Math.Min(m,n)} ");
    
}
Console.WriteLine("input number N: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
ShowNumberMN(1, userNumber);
