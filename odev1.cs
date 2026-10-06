Console.WriteLine("Hello C#");
string name="Talha";
string department ="Computer Engineering";
int year=2026;

Console.WriteLine($"Name: {name}  Department: {department}  year: {year}");
Console.WriteLine(DateTime.Now);


Console.WriteLine("Enter Fahrenheit: ");

double fahrenheit = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Fahrenheit to Celsius: {(fahrenheit-32)*5.0/9:F2} 'C");

