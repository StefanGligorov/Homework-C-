// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Task 1
int[] arr = new int[] { 12, 21, 34, 46, 51, 63 };
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 != 0)
    {
        sum += arr[i];
    }
}
Console.WriteLine(sum);

// Task 2
Console.WriteLine("Please enter number 1 or number 2!");
string input = Console.ReadLine();
int userInput = int.Parse(input);

string[] studentsG1 =  { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG3 =  { "Stefan", "Ernes", "Roze", "Anes", "Daris" };

for(int i = 0; i < studentsG1.Length; i++)
{
    if(userInput == 1)
    {
        Console.WriteLine("Student in G1: " + studentsG1[i]);
    }
}

for (int i = 0; i < studentsG3.Length; i++)
{
    if (userInput == 2)
    {
        Console.WriteLine("Student in G3: " + studentsG3[i]);
    }
}


