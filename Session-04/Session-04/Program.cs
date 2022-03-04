using Session_04;


InputParser inputParser = new InputParser();

// Exercize 1

Console.Write("Enter a string to be reversed: ");
string inputString = inputParser.ParseUserInputString();
Exercize1 exercize1 = new Exercize1();
Console.WriteLine($"{inputString} revered is: {exercize1.ReverseString(inputString)}\n");

// Exercize 2
Exercize2 exercize2 = new Exercize2();

Console.Write("Please enter a number n: ");
int n = inputParser.ParseUserInputInt();

Console.Write($"Please enter ({ValidUserChoices.SUM_CHOICE}) for sum or ({ValidUserChoices.PROD_CHOICE}) for product: ");
ushort choice = inputParser.ParseUserChoice();

Console.WriteLine($"The result of the computation was: {exercize2.ComputeResult(n, choice)}\n");

// Exercize 3

Exercize3 exercize3 = new Exercize3();

Console.Write("Enter a number n: ");
n = inputParser.ParseUserInputInt();

Console.WriteLine($"All of the prime numbers from 1 to are: {exercize3.FindPrimes(n)}\n");

// Exercize 4

int[] array1 = { 2, 4, 9, 12 };
int[] array2 = { 1, 3, 7, 10 };

Exercize4 exercize4 = new Exercize4();

Console.WriteLine($"Result of Array1 [{string.Join(", ", array1)}] * Array2 [{string.Join(", ", array2)}] = [{string.Join(", ", exercize4.MultiplyArrays(array1, array2))}]\n");

// Exercize 5
Exercize5 exercize5 = new Exercize5();

int[] array3 = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
Console.WriteLine($"Initial Array: [{string.Join(", ", array3)}]");

exercize5.SortArray(array3);
Console.WriteLine($"Sorted Array: [{string.Join(", ", array3)}]");
