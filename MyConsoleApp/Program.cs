// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {DateTime.Now}");

DateTime startDate = DateTime.Today;
DateTime endDate = new DateTime(2026, 12, 25);

double christmasDays = (endDate - startDate).TotalDays;

Console.WriteLine($"There are {Math.Round(christmasDays)} until the next christmas");


