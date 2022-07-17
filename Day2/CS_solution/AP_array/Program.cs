/*int[] arr = { 17, 31, 42, 21, 53 };
int total = 0;
Array.Sort(arr);
foreach (int i in arr)
{
    Console.WriteLine(i);
    total += i;
}
Console.WriteLine("total ={0}", total);*/

//while 先判斷 do while 先做一次
/*int n=1,total=0;

while (n > 0)
{
    String s = Console.ReadLine();
    n = int.Parse(s);
    total += n;
}
Console.WriteLine("total ={0}", total);*/
/*do
{
    String s = Console.ReadLine();
    n = int.Parse(s);
    total += n;

} while (n > 0);
Console.WriteLine("total ={0}", total);*/

//猜數字
String s;
do
{
    GuessNum();
    Console.WriteLine("是否繼續猜(Y/N)");
   s= Console.ReadLine();
}while(s=="y" ||s=="Y");

static void GuessNum()
{   
    int m,min=1,max=99;
    Random random = new Random();
    int ans = random.Next(1, 99);

    do
    {
        Console.WriteLine("猜數字1-99 :");
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
            min = m ;
            Console.WriteLine("高一點 在{0} 和{1}之間",min,max);
        }
         
        else if (m > ans)
        {
            max = m ;
            Console.WriteLine("低一點 在{0} 和{1}之間",min,max);
        }
          
        else
            Console.WriteLine("答對了");
    } while (m != ans);
}