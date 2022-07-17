// switch case month
//ctrl +k +ctrl+d 自動排版

/*Console.WriteLine("輸入月份");
String month;
month = Console.ReadLine();
switch (month)
{
    case "1":
    case "3":
    case "7":
    case "8":
    case "10":
    case "12":
    case "5":
        Console.WriteLine("大月(31天)");
        goto case "2";
    case "2":
        Console.WriteLine("二月(28  or 29天)");
        break;
    case "4":
    case "6":
    case "9":
    case "11":
        Console.WriteLine("小月(30天)");
        break;
    default:
        Console.WriteLine("輸入1-12");
        break;
}*/

//台幣轉換
int nt;decimal amt;
Console.WriteLine("輸入台幣");
String s = Console.ReadLine();
nt=int.Parse(s);
Console.WriteLine("輸入幣別 U=usd/J=JPY/E=EUR");
String type=Console.ReadLine();
switch (type)
{
    case "U":
        amt = nt / 30.05M;
        break;
    case "J":
        amt = nt / 0.2758m;
        break;
    case "E":
        amt = nt / 32.55m;
        break;
    default:
        amt = 0;
        break;
}
Console.WriteLine("台幣:{0:#,##0} 可兌換金額:{1:#,##0}",nt,amt);
