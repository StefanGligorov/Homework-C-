// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// TASK 1
//Console.WriteLine("Please enter 2 numbers");
//string num1 = Console.ReadLine();
//string num2 = Console.ReadLine();

//int number1 = int.Parse(num1);
//int number2 = int.Parse(num2);

//int result = number1 + number2;

//Console.WriteLine(result);

// TASK 2
//Console.WriteLine("Please enter 4 numbers");
//string numb1 = Console.ReadLine();
//string numb2 = Console.ReadLine();
//string numb3 = Console.ReadLine(); 
//string numb4 = Console.ReadLine();

//int numberR1 = int.Parse(numb1);
//int numberR2 = int.Parse(numb2);
//int numberR3 = int.Parse(numb3);
//int numberR4 = int.Parse(numb4);

//int result1 = (numberR1 + numberR2 + numberR3 + numberR4) / 4;
//Console.WriteLine(result1);

// Task 3

    int number1, number2, temp;
    Console.Write("\nInput the First Number : ");
    number1 = int.Parse(Console.ReadLine());
    Console.Write("\nInput the Second Number : ");
    number2 = int.Parse(Console.ReadLine());
    temp = number1;
    number1 = number2;
    number2 = temp;
    Console.Write("\nAfter Swapping : ");
    Console.Write("\nFirst Number : " + number1);
    Console.Write("\nSecond Number : " + number2);
    Console.Read();


