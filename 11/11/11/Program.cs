//11-2

using _11;

Console.OutputEncoding = System.Text.Encoding.Unicode; // відображення літери і

/*
 * Створити клас СТО. 
 * Створити клас Автомобіль, додати в нього властивості типу bool: 
 * розвал-сходження зроблено, пофарбувано, заміну масла виконано, повний тех-огляд пройдений, заміна колес виконано, ремонт кузова виконано. 
 * Створити наступні методи в класі СТО: розвал-сходження, фарбування, заміну масла, повний тех-огляд, заміна колес, ремонт кузова. 
 * Всі методи приймають екземпляр класу Автомобіль і проставляють значенням true відповідні властивості екземпляру класу. 
 * Створити комбіновані делегати, які будуть виконувати весь, або частину функціоналу. 
 * Реалізувати можливість виводу значень всіх властивостей на екрану вигляді: Назва Властивості -- Значення
*/

Student stud1 = new("Olexey", "Ledokol", 5);
Student stud2 = new("Stepan", "Bandera", 50);
Student stud3 = new("Volodymyr", "Zelenskyy", 44);
Student stud4 = new("Mykyta", "Sherstnov", 19);
Student stud5 = new("Taras", "Shevchenko", 47);
Student stud6 = new("Lesya", "Ukrainka", 47);
Student stud7 = new("Poppy", "John", 1);
Student stud8 = new("Artorias", "Abysswalker", 90);
Student stud9 = new("Arc", "Warden", 20);
Student stud10 = new("Andriy", "Jobs", 17);
Student stud11 = new("John", "Mur", 13);
Student stud12 = new("Sen", "For", 28);
Student stud13 = new("Andrew", "Troelsen", 24);


List<Student> lst = new() { stud1, stud2, stud3, stud4, stud5, stud6, stud7, stud8, stud9, stud10, stud11, stud12, stud13 };

//8

var result = Extention.FindStudent(lst, new(Student.IsAdult));
Console.WriteLine("First");
foreach (Student student in result)
    Console.WriteLine($"{student.FirstName}  {student.LastName} - {student.Age}");
result = Extention.FindStudent(lst, new(Student.FirstNameStartsWithA));
Console.WriteLine("Second");
foreach (Student student in result)
    Console.WriteLine($"{student.FirstName}  {student.LastName} - {student.Age}");
result = Extention.FindStudent(lst, new(Student.LastNameGreater));
Console.WriteLine("Third");
foreach (Student student in result)
    Console.WriteLine($"{student.FirstName}  {student.LastName} - {student.Age}");

//9

result = Extention.FindStudent(lst, new(delegate(Student student)
{
    return student.Age >= 18;
}));
Console.WriteLine("Fourth");
foreach (Student student in result)
    Console.WriteLine($"{student.FirstName}  {student.LastName} - {student.Age}");
result = Extention.FindStudent(lst, new(delegate (Student student)
{
    return student.FirstName[0] == 'A';
}));
Console.WriteLine("Fifth");
foreach (Student student in result)
    Console.WriteLine($"{student.FirstName}  {student.LastName} - {student.Age}");
result = Extention.FindStudent(lst, new(delegate (Student student)
{
    return student.LastName.Length > 3; 
}));
Console.WriteLine("Sixth");
foreach (Student student in result)
    Console.WriteLine($"{student.FirstName}  {student.LastName} - {student.Age}");


/*
В аналогічний з пунктом 9 спосіб знайти студентів вік яких знаходиться в межах від 20 до 25 років.
В аналогічний з пунктом 9 спосіб знайти студентів яких FirstName “Andrew”.
В аналогічний з пунктом 9 спосіб знайти студентів яких LastName “Troelsen”.
*/

//10-11
result = Extention.FindStudent(lst, new(delegate (Student student)
{
    return (student.Age >= 20 & student.Age <= 25);
}));
Console.WriteLine("Seventh");
foreach (Student student in result)
    Console.WriteLine($"{student.FirstName}  {student.LastName} - {student.Age}");
result = Extention.FindStudent(lst, new(delegate (Student student)
{
    return student.FirstName == "Andrew";
}));
Console.WriteLine("Eigth");
foreach (Student student in result)
    Console.WriteLine($"{student.FirstName}  {student.LastName} - {student.Age}");
result = Extention.FindStudent(lst, new(delegate (Student student)
{
    return student.LastName == "Troelsen";
}));
Console.WriteLine("Ninth");
foreach (Student student in result)
    Console.WriteLine($"{student.FirstName}  {student.LastName} - {student.Age}");
