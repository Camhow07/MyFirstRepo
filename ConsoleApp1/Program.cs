//Challenge 1

string? name;
int age;
string? courseName;
bool fullTime;
bool isAdult;

Console.WriteLine("What is your name?");
name = Console.ReadLine();

Console.WriteLine("What is your age?");
while (!int.TryParse(Console.ReadLine(), out age))
{
    Console.WriteLine("Please enter a valid age:");
}

Console.WriteLine("What is your course name?");
courseName = Console.ReadLine();

Console.WriteLine("Are you a full time student? true/false");
while (!bool.TryParse(Console.ReadLine(), out fullTime))
{
    Console.WriteLine("Please enter true/false");
}

Console.WriteLine($"\nName: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Course: {courseName}");
Console.WriteLine($"Full Time Student: {fullTime}");

if (age >= 18)
{
    isAdult = true;
    Console.WriteLine("Adult");
}
else
{   
    isAdult= false;
    Console.WriteLine("Child");
}

Console.WriteLine($"Is Adult: {isAdult}");

//Challenge 2

double number1 = 12;
double number2 = 5;

Console.WriteLine("Add: " + (number2 + number1));
Console.WriteLine("Subtract: " + (number2 - number1));
Console.WriteLine("Multiply: " + (number2 * number1));
Console.WriteLine("Divide: " + (number2 / number1));
Console.WriteLine("Remainder: " + (number2 % number1));


//Challenge 3

string studentName = ("Alex");​

int age1 = 20;​

int score = 75​;

​

Console.WriteLine(studentName);​
Console.WriteLine(age1);
Console.WriteLine(score);​
