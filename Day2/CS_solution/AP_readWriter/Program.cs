//寫入
StreamWriter streamWriter = new StreamWriter("C:/Users/USER/Desktop/帳號.txt");
for (int i = 0; i < 10; i++)
    streamWriter.WriteLine("hello {0}",i);
   streamWriter.Close();

//讀取
StreamReader streamReader = new StreamReader(@"C:/Users/USER/Desktop/帳號.txt");
for(int i = 0; i < 10; i++)

    Console.WriteLine(streamReader.ReadToEnd()); 

streamReader.Close();