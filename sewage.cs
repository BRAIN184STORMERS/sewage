using System;
namespace SewerageBillCalculator
{
class Program
{
static void Main()
{
Console.WriteLine("\t\t\t SEWERAGE BILL CALCULATOR: \r");
Console.WriteLine ("\t\t\t ________________________\r");

Console.WriteLine("Enter the user name");
Console.ReadLine();

Console.WriteLine ("Enter the usage type:(residential,commercial,industrial):");
#pragma warning disable CS8602//Deference of a possibly null reference.
string usageType=Console.ReadLine().ToLower();
#pragma warning restore CS8602//Deference of a possibly null reference. 

Console.WriteLine("Enter the water consumption in cubic meters:");
double waterConsumption=Convert.ToDouble(Console.ReadLine());
 double ratePerCubicMeter;

switch(usageType)
{
case"residential":
ratePerCubicMeter=10.00;
break;
case"commercial":
ratePerCubicMeter=12.50;
break;
case"industrial":
ratePerCubicMeter=15.00;
break;
default:
Console.WriteLine("invalid usage Type");
return;
}
double totalBill=ratePerCubicMeter*waterConsumption;
Console.WriteLine($"Sewerage Bill for {usageType}usage:${totalBill}");
}
}
}
