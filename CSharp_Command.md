# Команды
* dotnet new console - создать новый проект
* dotnet run - запустить проект
_______________________
* Console.WriteLine - выводит информацию в консоль(!Line значит в концепереход на другую строку!)
* Console.ReadLine - считывает введённую информацию в формате строки
* new Random().Next(a, b) - случайное целое число от a до b
* .ToLower() - перевод данных в нижний регистр
* Convert.ToInt32() - перевод данных в формат целого числа
* array.Length - возвращает длину массива
____________________________
# Типы данных

* int - целые числа(числа от -2 147 483 648 до 2 147 483 647 = 32 бита со знаком)
* double - дробные числа( числа от +-5,0*10в-324до=-1,7*10в308 = 64 бита со знаком)
* string - строка данных( от 0 до много символов = от 4байт до 2гб)
* bool - логические данные(true и false = 1 байт)
* математические операции + - * / %(остаток) и ()для порядка действия
____________________
# Создание метода
1. Тип данных            2.Название    3.скобки  4. Тип данных с параметром
int,double,string,char   FindNumber    (       int arg,   int arg2     );
{тело метода в конце return result если не войд}

____________________
# Массивы
создание массива
1. Обьявление тип данных 2.Название     3. перечислить значения или указать длинну масива
int[]                        array   =  {0,1,2,3} или array[n]; ими array[5]{1,2,3,4,5};