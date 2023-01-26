int count = 0;
int currentNumber = 1;

Console.WriteLine("Pick what prime number you want");
int pickedNumber = Convert.ToInt32(Console.ReadLine());

while (count < pickedNumber){
    if (isPrime(currentNumber)) {
        count++;
    }
    currentNumber++;
}
currentNumber--;

Console.WriteLine($"Result: {currentNumber}");

bool isPrime(int number)
{
    if (number == 1) return false;
    if (number == 2) return true;

    var limit = Math.Ceiling(Math.Sqrt(number));

    for (int i = 2; i <= limit; ++i)
        if (number % i == 0)
            return false;
    return true;

}