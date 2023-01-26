Console.Clear();
Console.WriteLine("Pick what prime number you want");
int pickedNumber = Convert.ToInt32(Console.ReadLine());

PrimeFinder.ProgressEvent += (count) => {
    int percentage = (int)((double)count/ pickedNumber * 100.0);
    Console.SetCursorPosition(0, 3);
    Console.Write(percentage.ToString() + "%");
};

int result = PrimeFinder.FindPrime(pickedNumber);

Console.WriteLine($"Result: {result}");

