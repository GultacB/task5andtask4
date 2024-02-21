
Random random = new Random();
int randomValue = random.Next(1,200);
int[] arr= new int[randomValue];
int count1 = 0;
int count2 = 0;
int count3 = 0;

for (int i = 0; i <arr.Length; i++)
{
    if (arr[i] < 10)
    {
         count1++;
    }
    if (arr[i] >= 10 && arr[i]<100) 
    {
        count2++;
    }
     if (arr[i] >= 100 && arr[i]<=200)
    {
        count3++;
    }
    Console.WriteLine("birreqemlilerin sayi:"+ count1);
    Console.WriteLine("ikireqemlilerin sayi:" + count2);
    Console.WriteLine("ucreqemlilerin sayi:" + count3);

Console.WriteLine("birreqemli ucun faiz:" + (count1 / 20) * 100);
Console.WriteLine("ikireqemli ucun faiz:" + (count2 / 20) * 100);
Console.WriteLine("ucreqemli ucun faiz:" + (count3 / 20) * 100);

