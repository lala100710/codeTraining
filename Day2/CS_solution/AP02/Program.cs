
for(; ; )
{
    calRate();
    Console.WriteLine("是否想繼續執行(y/n)");
    String s = Console.ReadLine();
    if (s== "N" ||s == "n")
        break;
    Console.Clear();
}


static void calRate()
{
    int n, principal; double rate;
    Console.WriteLine("期數 = ");
    String s = Console.ReadLine();
    n = int.Parse(s);
    Console.WriteLine("本金 = ");
    s = Console.ReadLine();
    principal = int.Parse(s);
    Console.WriteLine("利率 = ");
    s = Console.ReadLine();
    rate = double.Parse(s);
    Console.WriteLine("期數  本      金  利      率  合      計");
    Console.WriteLine("====  ==========  ==========  ==========");
    for (int i = 1; i <= n; i++)
    {
        int interest = (int)(principal * rate / 100 + 0.5);
        Console.WriteLine("{0,4}{1,12}{2,12}{3,12}", i, principal, interest, principal + interest);
        principal += interest;

    }
    Console.WriteLine("====  ==========  ==========  ==========");
}