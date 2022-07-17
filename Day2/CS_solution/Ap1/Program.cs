//point 1 FOR 迴圈不須使用福點運算作為index 會有誤差

/*for (decimal i = 0; i < 10; i += 0.1m)
    Console.WriteLine(i);*/
/*
Console.WriteLine("建議用法");
for (int i = 0; i < 100; i++)
    Console.WriteLine(i * 0.1m);*/

//不要隨意動用i(INDEX)
/*
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i > 5)
        i += 2;
}*/

/*int n;
Console.WriteLine("輸入n");
n = int.Parse(Console.ReadLine());*/

//* 正三角
/*for(int i = 0; i < n; i++)
{
   for(int j=0;j<=i;j++)
       Console.Write("*");
   Console.WriteLine();
}
Console.WriteLine();*/

//*到三角
/*for(int i = n; i > 0; i--)
{
    for(int j = i; j > 0; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/

/*for(int i = 0; i <n; i++)
{
    for(int j = 1; j < n - i; j++)
    {
        Console.Write(" ");
    }
    for(int k = 0; k < 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/
//for(;;) 無窮迴圈    break 中斷迴圈 continue繼續執行下一次
for(; ; )
{
    Exchange();
    Console.WriteLine("是否在執行一次(Y/N) ?");
    String s=Console.ReadLine();
    if(s.Equals("n") || s.Equals("N")) 
        break;
    Console.Clear();
}

//靜態方法 
static void Exchange()
{
    Console.WriteLine("輸入所得稅");
    int income, tax;
    String s = Console.ReadLine();
    income = int.Parse(s);
    if (income <= 540000)
        tax = (int)((income * 0.05) + 0.5);
    else if (income <= 1210000)
        tax = (int)((income * 0.12) + 0.5);
    else if (income <= 2420000)
        tax = (int)((income * 0.2) + 0.5);
    else if (income <= 4530000)
        tax = (int)((income * 0.3) + 0.5);
    else
        tax = (int)((income * 0.4) + 0.5);
    Console.WriteLine("年所得 :{0:#,##0} 所得稅 :{1:#,##0}", income, tax);
}


