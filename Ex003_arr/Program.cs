int[] array = { 3, 4, 1, 23, 98, 0, 1, 760, 543 };
int n = array.Length;
int find = 1;
int index = 0;
while(index<n)
{
    if (array[index]==find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}


