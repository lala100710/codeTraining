// question 6
/*int a, b;
String content;
Console.WriteLine("輸入A ");
content = Console.ReadLine();
a=int.Parse(content);
Console.WriteLine("輸入B");
content = Console.ReadLine();
b = int.Parse(content);
Console.WriteLine(a + b);*/

//判斷成績
/*String s;int score;
Console.WriteLine("成績 :");
s=Console.ReadLine();
score=int.Parse(s);
if (score >60)
    Console.WriteLine("及格");
else if(score <0)
    Console.WriteLine("分數錯誤");
else
    Console.WriteLine("不及格");*/

//成績等級
/*
String s;int score;
Console.WriteLine("成績 :");
s=Console.ReadLine();
score=int.Parse(s);
if ((score > 100 )||( score < 0))
    Console.WriteLine("score error");
else if (score >=80)
    Console.WriteLine("A");
else if(score >=60)
    Console.WriteLine("B");
else
    Console.WriteLine("C");*/

//所得稅
Console.WriteLine("輸入所得稅");
int income,tax;
String s=Console.ReadLine();
income=int.Parse(s);
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
Console.WriteLine("年所得 :{0:#,##0} 所得稅 :{1:#,##0}",income,tax);

