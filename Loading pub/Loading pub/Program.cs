Console.WriteLine("Pick what prime number you want");
int pickedNumber = Convert.ToInt32(Console.ReadLine());

int result = PrimeFinder.FindPrime(pickedNumber);

Console.WriteLine($"Result: {result}");

