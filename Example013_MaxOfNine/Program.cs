
   int Max( int arg1, int arg2, int arg3)
  {
        int result = arg1;
        if(arg2 > result) result = arg2;
        if(arg3 > result) result = arg3;
        return result;
  }

 int a1 = 13;
 int a2 = 14;
 int a3 = 15;
 int a4 = 16;
 int a5 = 17;
 int a6 = 188;
 int a7 = 19;
 int a8 = 1003;
 int a9 = 175;
 

//int max1 = Max(a1,a2,a3);
//int max2 = Max(a4,a5,a6);
//int max3 = Max(a7,a8,a9);
//int maxMax = Max(max1, max2, max3);
int maxMax = Max(
 Max(a1,a2,a3),
 Max(a4,a5,a6),
 Max(a7,a8,a9));
Console.WriteLine(maxMax);