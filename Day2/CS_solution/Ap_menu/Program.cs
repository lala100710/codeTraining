String choice,s;
do
{
    choice = menu();
    Console.WriteLine("輸入0 結束");
    s=Console.ReadLine();
}while (s !="0");


static String menu()
{
    Console.WriteLine("1 : DrawStar ");
    Console.WriteLine("2 : GuessNum");
    Console.WriteLine("3 : AddNum ");
    Console.WriteLine("4 : dice");
    Console.WriteLine("your chice 1-4 : ");
    String s = Console.ReadLine();
    switch (s)
    {
        case "1":
            DrawStar();
            break;
        case "2":
            GuessNum();
            break;
        case "3":
            AddNum();
            break;
        case "4":
            dice();
            break;
        default:
            break;
    }
    return s;
}
static void DrawStar()
    {
         Console.WriteLine("輸入n");
    int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
static void GuessNum()
    {
        int m, min = 1, max = 99;
        Random random = new Random();
        int ans = random.Next(1, 99);

        do
        {
            Console.WriteLine("猜數字 :");
            String s = Console.ReadLine();
            m = int.Parse(s);
            if (m == -1)
            {
                Console.WriteLine("答案是 {0}", ans);
                break;
            }
            if (m < 1 || m > 99)
            {
                Console.WriteLine("超出範圍");
                continue;
            }
            if (m < ans)
            {
                min = m+1;
                Console.WriteLine("高一點 在{0} 和{1}之間", min, max);
            }

            else if (m > ans)
            {
                max = m-1;
                Console.WriteLine("低一點 在{0} 和{1}之間", min, max);
            }

            else
                Console.WriteLine("答對了");
        } while (m != ans);
    }
static void dice()
    {
        int[] num = new int[4];
        Random random = new Random();
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = random.Next(1, 7);

        }
        Array.Sort(num);
        foreach (int i in num)
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
static void AddNum()
    {
       int a = checknum(); int b = checknum();

        Console.WriteLine("{0} +{1} = {2}", a, b, a + b);

    }
static int checknum()
{
    int content;
    String s;
    bool isCorrect;
    do
    {
        Console.WriteLine("輸入數字");
        s = Console.ReadLine();
        isCorrect = int.TryParse(s, out content);
        if (!isCorrect)
            Console.WriteLine("必須為數字");
    } while (!isCorrect);
    return content;
}
