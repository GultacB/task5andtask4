const int length = 10;
double[] arr = new double[length] { 2.3, 3.9, 5.6,7,9.5,8,2.3,4,5.9,10.1};
int count = 0; 
for (int i = 0; i < length; i++)
{
    if (arr[i] == (int)arr[i]) {

        count = count + 1;
        Console.WriteLine(count);
    }
    
}

