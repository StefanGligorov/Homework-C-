// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Task 1
Console.WriteLine("Please enter a word with more than 5 characters: ");

string userInput = Console.ReadLine();
string input = userInput.Substring(userInput.Length - 5);
Console.WriteLine(input);
Console.WriteLine("===========================================");
// Task 2
string userInput1 = "We are in Public Room and we enjoy some nice cold beer!";
string[] input1 = userInput1.Split(" ");
for (int i = 0; i < userInput1.Length; i++)
{
    Console.WriteLine(userInput1[i]);
}
Console.WriteLine("=========================================");

//Task 3
int SumOfTwoNumbers(int number1, int number2)
{
    int num1 = number1;
    int num2 = number2;

    return num1 + num2;
}
Console.WriteLine(SumOfTwoNumbers(20, 30));
Console.WriteLine("=======================================");

// Task 4
Console.WriteLine("Enter date:YY ");
string bDay = Console.ReadLine();
int birthDay = int.Parse(bDay);

int AgeCalculator(int birthDayDate)
{ 
    int age = birthDayDate;
    return birthDay - age;
}

Console.WriteLine(AgeCalculator(1995));
