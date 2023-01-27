Console.Clear();
Console.WriteLine("Pick what prime number you want");
int pickedNumber = Convert.ToInt32(Console.ReadLine());



PrimeFinder.ProgressEvent += (count) =>
{
    Console.CursorVisible = false;
    int percentage = (int)((double)count / pickedNumber * 100.0);
    Console.SetCursorPosition(0, 3);
    Console.Write("[" + new string('#', percentage / 10) + new string('-', 10 - percentage / 10) + "]");
};

int result = PrimeFinder.FindPrime(pickedNumber);
Console.SetCursorPosition(0, 4);
Console.WriteLine($"Result: {result}");

