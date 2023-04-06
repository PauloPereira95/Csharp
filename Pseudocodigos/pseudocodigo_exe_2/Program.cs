double val ,sum = 0,avg=0;
int i = 1, numVal;
try
{
Console.WriteLine("How many values do you want type ?");
numVal = int.Parse(Console.ReadLine());
while (i<=numVal)
{
    Console.WriteLine($"Type the {i}º value");
    val = double.Parse(Console.ReadLine());
    sum += val;
    i++;
}
avg = sum /numVal;
Console.WriteLine($"Sum -> {sum} || Average -> {avg}");
}catch (Exception e)
{
    Console.WriteLine(e.Message + " Type a integer number !");
}


