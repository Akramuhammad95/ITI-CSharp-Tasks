using System;
using Day2;
using Day2.calulator;
using Day2.Date;
using Day2.Emp;



///1 Find the minimum and maximum number in an array of integers.
#region Find min and max
Console.WriteLine("1 Find the minimum and maximum number in an array of integers.");
int[] numbers = { 3, 5, 1, 8, 2 };
Console.WriteLine("the array is");
foreach (int i in numbers)
    Console.Write($"{i} ");
Console.WriteLine();

ArrayUtility.GetMinAndMax(numbers);
#endregion

//2 sort the array of integers in ascending order.
Console.WriteLine("---------------------");
#region Sort the array

Console.WriteLine("2 sort the array of integers in ascending order.");
Console.WriteLine("the array after sorting");
ArrayUtility.SortArray(numbers);
foreach (int i in numbers)
{
    Console.Write($"{i} ");
}
//Console.WriteLine($"the hashcode of numbers array is {numbers.GetHashCode}");


Console.WriteLine();
#endregion

//3 array of 10 integers and serach numbers and get index of number
#region get index of number in arrray by searching
Console.WriteLine("---------------------");

Console.WriteLine("3 array of 10 integers and serach numbers and get index of number\r\n");
Console.WriteLine("Enter the number to find the number's index in the array");

int num = int.Parse(Console.ReadLine());
int index = ArrayUtility.SearchNumber(numbers, num);
if (index == -1)
{
    Console.WriteLine($"number {num} not found in the array");
}
else
    Console.WriteLine($"the index of number {num} is {index}");
#endregion

//4 read and write 2d array

Console.WriteLine("---------------------");

#region read and write 2d array
Console.WriteLine("-----------4 read and write 2d array-----------");

int[,] userNumbers = ArrayUtility.ReadAndWriteArray();
Console.WriteLine("the print of 2d array");
for (int i = 0; i < userNumbers.GetLength(0); i++)
{
    for (int j = 0; j < userNumbers.GetLength(1); j++)
    {
        Console.Write(userNumbers[i, j] + " ");
    }
    Console.WriteLine();
}

#endregion


// 5 calculate the birthday of a person given their age.
#region birthDay

Console.WriteLine();
int year;
int month;
int day;



CheckDateOfBirth dateOfBirth = new();

Console.WriteLine("---------------------");

Console.WriteLine("---------------5 calculate the birthday of a person given their age---------------------");

do
{
    Console.WriteLine("Enter your age from 1980 to 2025:");
    year = int.TryParse(Console.ReadLine(), out int y) ? y : 0;
    dateOfBirth.Year = year;
}
while (!dateOfBirth.IsValidYear());

do
{
    Console.WriteLine("enter the Month");
    month = int.TryParse(Console.ReadLine(), out int m) ? m : 0;
    dateOfBirth.Month = month;
}
while (!dateOfBirth.IsValidMonth());
do
{
    Console.WriteLine("enter the Day");
    day = int.TryParse(Console.ReadLine(), out int d) ? d : 0;
    dateOfBirth.Day = day;
}
while (!dateOfBirth.IsValidDay());

CalculateYearsMonthsDays calculate = new(year, month, day);

Console.WriteLine(calculate.ToString());

#endregion


// 6 simple calculator

#region Simple calclulator
Console.WriteLine("---------------------");

Console.WriteLine("6-Simple calculator");
int num1;
int num2;
char op;



do
{
    Console.WriteLine("Num1");
    num1 = int.Parse(Console.ReadLine());

}
while (num1.GetType == 1.GetType);
do
{
    Console.WriteLine("Operator");
    op = char.TryParse(Console.ReadLine(), out char p) ? p : 'f';
}
while (op == 'f' || !CalculatorExtensions.IsValidOperator(op));
do

{
    Console.WriteLine("Num2");
    num2 = int.Parse(Console.ReadLine());

}
while (num1.GetType == 1.GetType);
SimpleCalculator simpleCalculator = new(num1, num2);



switch (op)
{
    case '+':
        Add add = new();
        Console.WriteLine($"the result is {simpleCalculator.DoOperation(add)}");
        break;
    case '-':
        Sub sub = new();
        Console.WriteLine($"the result is {simpleCalculator.DoOperation(sub)}");
        break;
    case '*':
        Multibly multibly = new();
        Console.WriteLine($"the result is {simpleCalculator.DoOperation(multibly)}");
        break;
    case '/':
        Devide devide = new();
        Console.WriteLine($"the result is {simpleCalculator.DoOperation(devide)}");
        break;
}
#endregion

#region Employee
Console.WriteLine();
Console.WriteLine("______________________");
Console.WriteLine("Build Employees list");
Console.WriteLine();

ListOfEmoloyees employees = new ListOfEmoloyees();


for (int i = 0; i < 1; i++)
{
    short iD;
    Console.WriteLine($"enter the emp {i} Data");


    do
    {
        Console.WriteLine(" ID");

    }
    while (!short.TryParse(Console.ReadLine(), out iD) || !employees.IsValidId(iD));

    Console.WriteLine($" first name");
    string firstName = Console.ReadLine();
    Console.WriteLine(" last name");
    string lastName = Console.ReadLine();
    Console.WriteLine(" title");
    string title = Console.ReadLine();

    decimal salary;
    do
    {
        Console.WriteLine("salary ");
    }

    while (!decimal.TryParse(Console.ReadLine(), out salary) || salary > 100000 || salary < 1000);


    Employee emp = new Employee
    {
        ID = iD,
        FirstName = firstName,
        LastName = lastName,
        Title = title,
        Salary = salary
    };
    employees.Add(emp);
    foreach (var employee in employees)
    {
        Console.WriteLine(employee);
    }
    #endregion



}

