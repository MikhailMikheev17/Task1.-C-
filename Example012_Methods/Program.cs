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

string res = Method4(10,"qwerty ");
System.Console.WriteLine(res);