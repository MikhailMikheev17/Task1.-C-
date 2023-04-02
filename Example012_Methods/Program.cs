Console.Clear();

// Вид 1 
void Method1()
{
  System.Console.WriteLine(" Автор ...");
}
//Method1();

// Вид 2
void Method2(string msg)
{
  System.Console.WriteLine(msg);
}
//Method2(msg: "Текст");

void Method21(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
    System.Console.WriteLine(msg);
    i++;
  }
}
//Method21(msg: "Текст", count: 4);

//Вид 3

int Method3()
{
  return DateTime.Now.Year;
}

int year = Method3();
//System.Console.WriteLine(year);

//Вид 4 
string Method4(int count, string text)
{
  int i = 0;
  string result = String.Empty;

  while (i < count)
  {
    result = result + text;
    i++;
  }
  return result;
}

string res = Method4(10, "qwerty ");
//System.Console.WriteLine(res);

// Вывод таблицы умножения на экран
for (int i = 2; i <= 10; i++)
{
  for (int j = 2; j < 10; j++)
  {
   // System.Console.WriteLine($"{i} x {j} = {i * j}");
  }
 // System.Console.WriteLine();
}

// ===== Работа с текстом 
//дан текст и тд ...

string text = "- Я думаю, - сказал кнзяь, улыбаясь, - что, "
           + "ежели бы вас послали вместо нашего милого Винценгероде"
           + " вы бы взяли приступом соглсие прусского короля. "
           + " Вы так красноречивы. Вы дадите мне чаю?";

//string s ="qwerty"
//           012
// s[3] // r

string Replace(string text, char oldValue,char newValue)
{
  string result = String.Empty;
  int length = text.Length;
   
  for (int i = 0; i< length;i++)
  {
    if (text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
  }

  return result;
}

string newText = Replace( text,' ','|');
System.Console.WriteLine(newText);
System.Console.WriteLine();

newText = Replace( newText,'к','К');
System.Console.WriteLine(newText);
System.Console.WriteLine();

newText = Replace( newText,'с','С');
System.Console.WriteLine(newText);
System.Console.WriteLine();


