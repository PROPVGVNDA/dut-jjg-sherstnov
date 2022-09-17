//7-12

/*
* 12.Створити ліст інтових значень, дозволити заповнення з клавіатури.
* Знайти суму всіх простих елементів і різницю парних. Порахувати середнє арифметичне всіх елементів.
*/

Console.OutputEncoding = System.Text.Encoding.Unicode; // відображення літери і

List<int> list = new();

Console.WriteLine("Введіть почергово числа");
Console.WriteLine("Введіть 'EOF', щоб закінчити заповнення листу.");

while (true)
{
    string str = Console.ReadLine();
    if (str == "EOF") break;
    Int32.TryParse(str, out int value);
    list.Add(value);
}

Console.WriteLine($"Сума простих чисед у листі: {SumOfPrime(list)}");
Console.WriteLine($"Різниця парних чисел у листі: {DifOfEven(list)}");
Console.WriteLine($"Середнє арифметичне чисел у листі: {ArithmeticMean(list)}");

double ArithmeticMean(List<int> lst)
{
    double sum = 0.0;

    foreach (int number in lst)
        sum += number;
    return sum / lst.Count;
}

int SumOfPrime(List<int> lst)
{
    int sum = 0;
    foreach(int number in lst)
        if (IsPrimeNumber(number)) sum += number;

    return sum;
}

int DifOfEven(List<int> lst)
{
    bool isAssigned = false;
    int sum = 0;
    foreach (int number in lst)
        if (IsEven(number))
        {
            if (isAssigned) sum -= number;
            else
            {
                sum = number;
                isAssigned = true;
            }
        }

    return sum;
}

bool IsPrimeNumber(int number)
{
    bool result = true;

    if (number <= 1) return false;
    for (var i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            result = false;
            break;
        }
    }

    return result;
}

bool IsEven(int number)
{
    return number % 2 == 0;
}

