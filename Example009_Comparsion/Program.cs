
Console.Write("Введите первое число для сравнения:");
string firstString = Console.ReadLine();
int a = Convert.ToInt32(firstString);

Console.Write("Введите второе  число для сравнения:");
string secondString = Console.ReadLine();
int b = Convert.ToInt32(secondString);

Console.Write("Введите третье число для сравнения:");
string thirdString = Console.ReadLine();
int c = Convert.ToInt32(thirdString);
int max;
  if (a > b )
  {
    max = a;
    
  }        
  else
  {    
    max = b;
    
  }
  if (c > max)
  {
    max = c;
        
  }
  

Console.Write("Число " + max + " самое большое из чисел ");
Console.Write(a + ";" + b + ";" + c + ";");
  
  
    
    
    
    
  
    
