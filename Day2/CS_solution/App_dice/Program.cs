for(; ; )
{
    dice();
    Console.WriteLine("again ?");
    String s=Console.ReadLine();
    if (s == "N" || s == "n")
        break;
}

static void dice()
{
    int[] num = new int[4];
    Random random = new Random();
    for(int i= 0; i < num.Length;i++)
    {
        num[i] = random.Next(1, 7);
   
    }
    Array.Sort(num);  
    foreach(int i in num)
        Console.WriteLine(i);
    if (num[0] == num[3])
        Console.WriteLine("一色");
    else if (num[0] == num[2] || num[1] == num[3])
        Console.WriteLine("沒點，重擲");
    else if (num[0] == num[1] && num[2] == num[3])
        Console.WriteLine(num[2] + num[3]);
    else if (num[0] == num[1])
        Console.WriteLine(num[2] + num[3]);
    else if (num[2] == num[3])
        Console.WriteLine(num[0] + num[1]);
    else
        Console.WriteLine("沒點，重擲");
}