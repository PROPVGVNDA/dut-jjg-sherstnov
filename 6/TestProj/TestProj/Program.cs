//6

// 6 пункт не реалізован...

Console.OutputEncoding = System.Text.Encoding.Unicode; // відображення літери і

Func1(12345);
Func2("ABCD");
Func3(123.456);
Func4("ABC|DEF", '|');

var func5 = new Func5();

func5.Func(12345);
func5.Func("ABCD");
func5.Func(123.456);
func5.Func("ABC|DEF", '|');

int[] array = new int[] { 1, 2, 3, 4, 5 };

array = Func7(array);
foreach (var value in array)
    Console.WriteLine(value);

Console.WriteLine();

Func8(ref array);

foreach (var value in array)
    Console.WriteLine(value);

int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
Func8(ref arr);


void Func1(int number)
{
    int reverse = 0;
    while (number > 0)
    {
        int remainder = number % 10;
        reverse = (reverse * 10) + remainder;
        number = number / 10;
    }
    Console.WriteLine(reverse);
}

void Func2(string str)
{
    Console.WriteLine(ReverseString(str));
}

string ReverseString(string str)
{
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

void Func3(double number)
{
    string str = number.ToString();
    int index = str.IndexOf(',');
    double f = double.Parse(ReverseString(str.Substring(0, index)));
    double s = double.Parse(ReverseString(str.Substring(index + 1, str.Length - index - 1)));
    
    Console.WriteLine($"{f}.{s}");
}

void Func4(string str, char magChar)
{
    int index = str.IndexOf(magChar);
    string f = ReverseString(str.Substring(0, index));
    string s = ReverseString(str.Substring(index + 1, str.Length - index - 1));
    Console.WriteLine(f + magChar + s);
}

int[] Func7(int[] array)
{
    int length = array.Length;
    int[] arr = new int[length];
    for (int i = length - 1, j = 0; i >= 0; i--, j++)
    {
        arr[j] = array[i];
    }
    return arr;
}

void Func8(ref int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[length - i - 1];
        array[length - i - 1] = temp;
    }
    return;
}

// 5

class Func5
{
    public void Func(int number)
    {
        int reverse = 0;
        while (number > 0)
        {
            int remainder = number % 10;
            reverse = (reverse * 10) + remainder;
            number = number / 10;
        }
        Console.WriteLine(reverse);
    }
    public void Func(string str)
    {
        Console.WriteLine(ReverseString(str));
    }

    public void Func(double number)
    {
        string str = number.ToString();
        int index = str.IndexOf(',');
        double f = double.Parse(ReverseString(str.Substring(0, index)));
        double s = double.Parse(ReverseString(str.Substring(index + 1, str.Length - index - 1)));

        Console.WriteLine($"{f}.{s}");
    }

    public void Func(string str, char magChar)
    {
        int index = str.IndexOf(magChar);
        string f = ReverseString(str.Substring(0, index));
        string s = ReverseString(str.Substring(index + 1, str.Length - index - 1));
        Console.WriteLine(f + magChar + s);
    }

    private string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

