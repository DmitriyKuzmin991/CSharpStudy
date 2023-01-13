
Console.WriteLine("Введите первое число:");
string firstString = Console.ReadLine();
int a = Convert.ToInt32(firstString);

Console.WriteLine("Введите второе  число:");
string secondString = Console.ReadLine();
int b = Convert.ToInt32(secondString);

Console.WriteLine("Введите третье число:");
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
    Console.Write(max + " = самое большое из ");
    Console.Write(a + ";" + b + ";" + c + ";");
  }
  else
  {
    Console.Write(max + " = самое большое из ");
    Console.Write(a + ";" + b + ";" + c + ";");
  }
 
  
  
    
    
    
    
  
    
