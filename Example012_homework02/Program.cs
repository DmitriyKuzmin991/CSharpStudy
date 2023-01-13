Console.Write("Введите первое число: ");
string firstString = Console.ReadLine();
int a = Convert.ToInt32(firstString);

Console.Write("Введите второе  число: ");
string secondString = Console.ReadLine();
int b = Convert.ToInt32(secondString);
int max = a;
int min = b;
if (a < b)
{
  max = b;
  min = a;
}
Console.Write(max + " больше чем " + min);