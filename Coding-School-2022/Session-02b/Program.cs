// Exercise 1
string myName = "Fotis";
Console.WriteLine("Hello " + myName + "\n");

// Exercise 2
int firstNum = 5;
int secondNum = 10;
Console.WriteLine(firstNum + secondNum + "\n");

// Exercise 3
int firstResult = -1 + 5 * 6;
int secondResult = 38 + 5 % 7;
float thirdResult = 14 + ((-3 * 6) / (float) 7);
double fourthResult = 2 + (13 / (double) 6) * 6 + Math.Sqrt(7);
double fifthResult = Math.Pow(6, 4) + Math.Pow(5, 7) / 9 % 4;

Console.WriteLine("First result: " + firstResult);
Console.WriteLine("Second result: " + secondResult);
Console.WriteLine("Third result: " + thirdResult);
Console.WriteLine("Fourth result: " + fourthResult);
Console.WriteLine("Fifth result: " + fifthResult + "\n");

// Exercise 4
ushort age = 21;
string gender = "male";
Console.WriteLine("You are " + gender + " and look younger than " + age + ".\n");

// Exercise 5
int initialSeconds = int.Parse(Console.ReadLine());
int seconds = initialSeconds;

int years = seconds / 31556926;
seconds -= years * 31556926;

int days = seconds / 86400;
seconds -= days * 86400;

int hours = seconds / 3600;
seconds -= hours * 3600;

int minutes = seconds / 60;
seconds -= minutes * 60;

Console.WriteLine(initialSeconds + " seconds is equal to: " + years + " years, " + days + " days, " + hours + " hours and " + minutes + " minutes.\n");

// Exercise 6
TimeSpan ts = TimeSpan.FromSeconds(initialSeconds);

Console.WriteLine(initialSeconds + " seconds is equal to: " + ts.Days / 365 + " years, " + ts.Days + " days, " + ts.Hours + " hours and " + ts.Minutes + " minutes.\n");

// Exercise 7
float celcius = float.Parse(Console.ReadLine());
Console.WriteLine(celcius + " degrees celcius is roughly equal to " + (celcius * 33.8) + " Fahreneit and " + (274.15 * celcius) + " Kelvin.");
