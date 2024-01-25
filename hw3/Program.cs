
using hw3;

var date = new Date(1,12,2023);
System.Console.WriteLine("---------------------------");
System.Console.Write("day : ");
date.Day=Convert.ToInt32(Console.ReadLine());
System.Console.Write("month : ");
date.Month=Convert.ToInt32(Console.ReadLine());
System.Console.Write("year : ");
date.Year=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{date.Day}/{date.Month}/{date.Year}");

