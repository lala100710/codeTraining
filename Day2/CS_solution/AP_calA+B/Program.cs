int a, b;



a=checknum();b=checknum();

Console.WriteLine("{0} +{1} = {2}", a, b, a + b);
/*try catch 寫法
try
{
    Console.WriteLine("a=");
    s=Console.ReadLine();
    a=int.Parse(s);
    Console.WriteLine("b= ");
    s = Console.ReadLine();
    b=int.Parse(s);
    Console.WriteLine("{0} +{1} = {2}",a,b,a+b);

}catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("bye");
}*/
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
        if(!isCorrect)
            Console.WriteLine("必須為數字");
    } while(!isCorrect);
    return content;
}
