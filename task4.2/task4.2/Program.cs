Console.WriteLine("Saati daxil edin:");
string time = Console.ReadLine();
Console.WriteLine("Deqiqeni daxil edin:");
string minute = Console.ReadLine();
string result = $"{time} {minute}";

switch (result)
{
    case "8 saat 5 deqiqe":
        Console.WriteLine("sabahiniz xeyr!");
        break;
    case "16 saat 27 deqiqe":
        Console.WriteLine("gunortaniz xeyr!");
        break;
    case "22 saat 45 deqiqe":
        Console.WriteLine("axsaminiz xeyr!");
        break;
}