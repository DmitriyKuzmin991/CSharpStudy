int[] array = {1,2,3,34,9,5,4,6,4,8,9};

int n = array.Length; // возвращает длину массива
int find = 4;
int index = 0;

while(index<n)
{
    if(array[index] == find)
    {
      Console.WriteLine(index);
      break;
    }

    index++;
}