﻿Console.Clear();

int max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33124124;
int a3 = 13;
int b3 = 233;
int c3 = 33;

//int max1 = max(a1,b1,c1);
//int max2 = max(a2,b2,c2);
//int max3 = max(a3,b3,c3);
//int maxMax = max(max1,max2,max3);

int maxMax = max(
  max(a1, b1, c1),
  max(a2, b2, c2),
  max(a3, b3, c3));

//Console.WriteLine($"max1 = {max1}");
//Console.WriteLine($"max2 = {max2}");
//Console.WriteLine($"max3 = {max3}");
Console.WriteLine($"mainMax = {maxMax}");