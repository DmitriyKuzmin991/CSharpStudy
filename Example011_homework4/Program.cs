Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
if (number > 0){ 
  while(i <= number)
  {
  if (i%2 ==0)
  { 
  Console.Write("'" + i + "'");
  i++;
  }
  else
  i++;
  }
}
else{
  while(i >= number)
    {
  if (i%2 ==0)
  { 
  Console.Write("'" + i + "'");
  i--;
  }
  else
  i--;
  }
}  
Console.Write("< Чётные числа до числа " + number);