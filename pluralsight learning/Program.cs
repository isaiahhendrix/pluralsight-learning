// See https://aka.ms/new-console-template for more information
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;

/*Console.WriteLine("Hello, everybody");

Console.WriteLine("please enter your first name");
String firstname = Console.ReadLine();

Console.WriteLine("please enter your last name");
string lastname = Console.ReadLine();

Console.WriteLine("hello " + firstname +" " +lastname);*/

//Console.WriteLine("welcome to bethany's pie shop");

//Console.WriteLine("please enter your name: ");

//string name = Console.ReadLine();

//string name2

//int monthlyWage = 1234;

//int months = 12, bonus = 1000;

//bool isActive = true;

//double rating = 99.25;

//byte numberOfEmployees = 300;

//int hoursWorked; 

//hoursWorked = 125;
//hoursWorked =  148;
////monthlyWage = true;

//const double interestRate = 0.007;

//string firstName = "bethany";
//string lastName = "smith";
//string emptyString = "";
//Console.WriteLine("please enter your name");
//string name = Console.ReadLine();

//double ratePerHour = 12.34;
//int numberOfHoursWorked = 165;

//double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
//Console.WriteLine(currentMonthWage);

//ratePerHour += 3; //ratePerHour = RatePerHour +3
//Console.WriteLine(ratePerHour);
//if (currentMonthWage > 2000)
//    Console.WriteLine("top paid employee!");
//int numberOfEmployees = 15;

//bool a;
//int b;
//numberOfEmployees--;

//Console.ReadLine();

//int intMaxValue = int.MaxValue;   //used to see max value of data type
//int intMinValue = int.MinValue;   //used to see min value of data type
//char userSelection = 'a';     //used to see default output
//char upperVersion = char.ToUpper(userSelection);
//bool isDigit = char.IsDigit(userSelection);

//bool isLetter = char.IsLetter(userSelection);


//Console.ReadLine();

//var hireDate = new DateTime(2022, 3, 28, 14, 30, 0);
//Console.WriteLine(hireDate);

//DateTime exitDate = new DateTime(2025, 12, 11);

////DateTime invalidDate = new DateTime(2025, 15, 11);

//DateTime startDate = hireDate.AddDays(15);
//Console.WriteLine(startDate);

//DateTime currentDate = DateTime.Now;
//bool areWeInDst = currentDate.IsDaylightSavingTime();

//DateTime startHour = DateTime.Now;
//TimeSpan workTime = new TimeSpan(8, 35, 0);
//DateTime endHour = startHour.Add(workTime);

//Console.WriteLine(startHour.ToLongDateString());
//Console.WriteLine(endHour.ToShortDateString());


//int numberOfHoursWorked = 165;

//long veryLongMonth = numberOfHoursWorked; //works fine

//double d = 123456789.0;

//int x = (int)d; //forcing c# to accept

//int intVeryLongMonth = (int)veryLongMonth;

// a == b; both operands are equal
//a != b; both operands are not equal
//a >= b; a greater than b operand
// a <= b; b greater than a operand
// age == 45; true if value of age is equal to 45, otherwise false
// age != 0; true if age is not equal to 0
// && = if both equations are true, will return true but if one is not, it will return false
// || (or) will return true if either one is true, false if both are not true


//int age = 23;

//bool a =  age == 23;

//Console.WriteLine("age is 23: " + a);

//bool b = age > 23;
//Console.WriteLine("age is greater than 23: " + b);

//bool c = (age >= 18) && (age <= 65);
//Console.WriteLine("age is between 18 and 65: " + c);

//int age1 = 16;
//int age2 = 64;
//bool d = (age1 >= 18) && (age2 <= 65);
//Console.WriteLine("Age1 is greater than 18 AND age2 is less than 65: " + d); //false due to &&, only 1 true
//bool e = (age1 >= 18) || (age2 <= 65);
//Console.WriteLine("age1 is greater than 18 OR age2 is less than 65: " + e); // true due to || (or) one is true, other false

//flow of execution = first statement, then the second, then so on

//Console.WriteLine("Enter the age of the new candidate: ");
//int age = int.Parse(Console.ReadLine());

//if (age < 18)
//{
//    Console.WriteLine("too young to apply");
//    Console.WriteLine("Send email to candidate.");
//}
//else if (age > 65)
//{
//    Console.WriteLine("Sorry, the selected age is too old");
//    Console.WriteLine("Send email to candidate.");
//}

//else
//{
//    Console.WriteLine("great, you can now start with the application!");
//}

//DateTime today = DateTime.Now;
//bool endOfMonthPaymentStarted = false;

//if (today.Date.Day == 20)
//{
//    Console.WriteLine("Please start end-of-month employee payments");
//}
//else if (today.Date.Day >= 25 && !endOfMonthPaymentStarted)
//{
//    Console.WriteLine("Payments will be late!");

//else is not required

// switch statement
//works for most data types but not float and double
//case labels use a pattern: constant or relational
//each case type must be unique
//default can be placed anywhere, always executed last

//switch(age)
//{
//    case < 18:
//    case > 65:
//        Console.WriteLine("sorry, your age is not within the range we are looking for");     
//         Console.WriteLine("sorry, your age is not within the range we are looking for");
//        break;
//    case 23:
//        Console.WriteLine("Wow, exactly what we are looking for");
//        break;
//    default:
//        Console.WriteLine("great, you can now start with the application!");
//        break;
//}
//Console.WriteLine("Choose the action you want to do: ");
//Console.WriteLine("1. Add employee");
//Console.WriteLine("2. update employee");
//Console.WriteLine("3. delete employee");
//Console.WriteLine("99. exit application");
//string selectedAction = Console.ReadLine();

//while (selectedAction != "99")
//{

//    switch (selectedAction)
//    {
//        case "1":
//            Console.WriteLine("adding new employee...");
//            break;
//        case "2":
//            Console.WriteLine("updating employee...");
//            break;
//        case "3":
//            Console.WriteLine("deleting employee...");
//            break;
//        default:
//            Console.WriteLine("invalid input");
//            break;
//    }
//    Console.WriteLine("Choose the action you want to do: ");
//    Console.WriteLine("1. Add employee");
//    Console.WriteLine("2. update employee");
//    Console.WriteLine("3. delete employee");
//    Console.WriteLine("99. exit application");
//    selectedAction = Console.ReadLine();
//}

// b = true;
//while (b) will keep running until a break or a false


//Console.WriteLine("Enter a value: ");
//int max = int.Parse(Console.ReadLine());
//int i = 0;

//while(i < max)
//{
//    Console.WriteLine(i);
//    i++;
//}
//Console.WriteLine("loop finished!");

//int i = 0;

//while (i > 0)
//{
//    Console.WriteLine(i);
//    i--;

//}
//Console.WriteLine("Loop finished");

//int i = 0;
//int j = 0;

//while (i < 10)
//{

//    while (j < 10)
//    {

//        Console.WriteLine("i: " + i + " j:" + j);
//        j++;

//    }
//    j = 0;
//    i++;

//}

//while (true)
//{
//    Console.WriteLine(DateTime.Now);
//}
Console.WriteLine("Enter a value: ");
int max = int.Parse(Console.ReadLine());

for (int i = 0; i < max; i++)
{
  

    if (i == 5)
    {
        Console.WriteLine("Bingo! " + i + " was found!");
        break;
    }
    Console.WriteLine(i);

}
