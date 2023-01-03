Console.Clear();
int points = 0;
int MaxPoints = 0;
double calculation = 0;
int grade = 0;
int gradewithhomework = 0;
int pointswithhomework = 0;
int calculationwithhomework = 0;
int pointsfirstexam = 0;
int pointssecondexam = 0;
int pointshomework = 0;
int pointsoralexam = 0;



Console.WriteLine("Have you participated in the first exam?");
string answer = Console.ReadLine()!;

if (answer == "yes")
{

    Console.WriteLine("How many points did you get on your first exam? (0 - 20)");
    pointsfirstexam += int.Parse(Console.ReadLine()!);

    MaxPoints += 20;
    points += pointsfirstexam;
    pointswithhomework += pointsfirstexam;



    Console.WriteLine("Have you participated in the second exam?");
    answer = Console.ReadLine()!;

    if (answer == "yes")
    {
        Console.WriteLine("How many points did you get on your second exam? (0 - 20)");
        pointssecondexam += int.Parse(Console.ReadLine()!);
        MaxPoints += 20;
        points += pointssecondexam;
        pointswithhomework += pointssecondexam;
    }

    Console.WriteLine("Have you done the homework?");
    answer = Console.ReadLine()!;

    if (answer == "yes")
    {
        Console.WriteLine("How many points did you get on your homework? (0 - 20)");
        pointshomework += int.Parse(Console.ReadLine()!);
        MaxPoints += 20;
        points += pointshomework;
        pointswithhomework += 20;
    }


    Console.WriteLine("Have you participated in the oral exam?");
    answer = Console.ReadLine()!;

    if (answer == "yes")
    {
        Console.WriteLine("How many points did you get on your oral exam? (0-20)");
        pointsoralexam += int.Parse(Console.ReadLine()!);
        MaxPoints += 20;
        points += pointsoralexam;
        pointswithhomework += pointsoralexam;
    }


}

else if (answer == "no")
{
    Console.WriteLine("Have you participated in the second exam?");
    answer = Console.ReadLine()!;

    if (answer == "yes")
    {
        Console.WriteLine("How many points did you get on your second exam? (0 - 20)");
        points += int.Parse(Console.ReadLine()!);
        MaxPoints += 20;
        points += pointssecondexam;
        pointswithhomework += pointssecondexam;
    }

    Console.WriteLine("Have you done the homework?");
    answer = Console.ReadLine()!;

    if (answer == "yes")
    {
        Console.WriteLine("How many points did you get on your homework? (0 - 20)");
        pointshomework += int.Parse(Console.ReadLine()!);
        MaxPoints += 20;
        points += pointshomework;
        pointswithhomework += 20;
    }

    Console.WriteLine("Have you participated in the oral exam?");
    answer = Console.ReadLine()!;

    if (answer == "yes")
    {
        Console.WriteLine("How many points did you get on your oral exam? (0-20)");
        pointsoralexam += int.Parse(Console.ReadLine()!);
        MaxPoints += 20;
        points += pointsoralexam;
        pointswithhomework += pointsoralexam;
    }


}

if (MaxPoints > 0)
{

    calculation += 100 * points / MaxPoints;
}


if (calculation >= 89)
{
    Console.WriteLine("Congrats you have an A!");
    grade = 1;
}
else if (calculation >= 76)
{
    Console.WriteLine("Congrats you have a B!");
    grade = 2;
}
else if (calculation >= 63)
{
    Console.WriteLine("Congrats you have a C!");
    grade = 3;
}
else if (calculation >= 50)
{
    Console.WriteLine("Congrats you have a D!");
    grade = 4;
}

else if (calculation <= 0)
{
    Console.WriteLine("Sorry, you failed.");
    grade = 5;
}

calculationwithhomework += 100 * pointswithhomework / MaxPoints;


if (calculationwithhomework >= 89)
{
    gradewithhomework = 1;
}
else if (calculationwithhomework >= 76)
{
    gradewithhomework = 2;
}
else if (calculationwithhomework >= 63)
{
    gradewithhomework = 3;
}
else if (calculationwithhomework >= 50)
{
    gradewithhomework = 4;
}

else if (calculationwithhomework <= 0)
{
    gradewithhomework = 5;
}

if (grade != gradewithhomework)
{
    Console.WriteLine("If you did all your homework correctly you would get " + gradewithhomework);
}

else
{
    Console.WriteLine("Okay bye");
}



Console.WriteLine("Press any key to exit");
Console.ReadKey();
Console.Clear();

