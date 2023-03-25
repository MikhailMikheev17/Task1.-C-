Console.Clear();

int[] array = { 11, 23, 35, 4, 45, 66, 77, 4 };

int n = array.Length;
int find = 4;

int index = 0;

while(index < n) 
{

  if (array[index] == find)
  {
    Console.WriteLine(index);
    break;
  }
  index++;
}