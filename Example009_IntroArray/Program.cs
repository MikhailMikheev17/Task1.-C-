Console.Clear();

int max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result;
}
//             0  1  2  3  4  5  6  7  8
int[] array ={11,22,31,41,15,56,17,11,19};
//array[0] = 12 - перезапись аргумента 
//Console.WriteLine(" array[0]");

//Способ первый
int maxMax = max(
  max(array[0], array[1], array[2]),
  max(array[3], array[4], array[5]),
  max(array[6], array[7], array[8]));

//Console.WriteLine($"max1 = {max1}");
//Console.WriteLine($"max2 = {max2}");
//Console.WriteLine($"max3 = {max3}");
Console.WriteLine($"mainMax = {maxMax}");