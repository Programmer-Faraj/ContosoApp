using System;
using System.Globalization;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine();

/*Creating an application that calculates student GPA and prints out a formated result. 
  Decalring verious data types to store values. Implement a method to perform math operations
  and print out the result. Perform multiple calculations using numeric data types*/

// TRAINING SOLUTION
/*string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

int leadingDigit = (int)gradePointAverage;
int firstDigit = (int)(gradePointAverage * 10) % 10;
int secondDigit = (int)(gradePointAverage * 100) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine($"Course\t\t\t\tGrade\t\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\n{totalGradePoints} {totalCreditHours}");

Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");*/





// MY SOLTUION
/*try
{
    CalculateGPA();
    //Console.WriteLine("Calculation successed");
}
catch (InvalidOperationException e)
{
    Console.WriteLine($"Could not complete calculation {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"An error ocurred {e.Message}");
}

// A method to implement math operations
void CalculateGPA()
{
    string studentName = "Sophia Johnson";
    string course1Name = "English 101";
    string course2Name = "Algebra 101";
    string course3Name = "Biology 101";
    string course4Name = "Computer Science I";
    string course5Name = "Psychology 101";

    int course1Credit = 3;
    int course2Credit = 3;
    int course3Credit = 4;
    int course4Credit = 4;
    int course5Credit = 3;

    int gradeA = 4;
    int gradeB = 3;

    int course1Grade = gradeA;
    int course2Grade = gradeB;
    int course3Grade = gradeB;
    int course4Grade = gradeB;
    int course5Grade = gradeA;

    Console.WriteLine($"Student: {studentName}");
    Console.WriteLine($"\nCourse\t\t\tGrade\tHour");
    Console.WriteLine($"{course1Name}\t\t {course1Grade}\t {course1Credit}");
    Console.WriteLine($"{course2Name}\t\t {course2Grade}\t {course2Credit}"); 
    Console.WriteLine($"{course3Name}\t\t {course3Grade}\t {course3Credit}"); 
    Console.WriteLine($"{course4Name}\t {course4Grade}\t {course4Credit}"); 
    Console.WriteLine($"{course5Name}\t\t {course5Grade}\t {course5Credit}"); 

    decimal totalGradePoints = (course1Credit * course1Grade) +
                               (course2Credit * course2Grade) +
                               (course3Credit * course3Grade) +
                               (course4Credit * course4Grade) +
                               (course5Credit * course5Grade);
    
    if ( totalGradePoints == 0)
    {
        throw new InvalidOperationException("Total grade points cannot be zero." );
    }

    int totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
   
    if (totalCreditHours == 0)
    {
        throw new InvalidOperationException("Total credit hours cannot be zero.");
    }
    
    decimal gpa = totalGradePoints / totalCreditHours;

    if (gpa == 0)
    {
        throw new InvalidOperationException("Total GPA cannot be zero.");
    }

    Console.WriteLine();
    Console.WriteLine($"Total Grade Points: {totalGradePoints}");
    Console.WriteLine($"Total Credit Hours: {totalCreditHours}");
    string formattedGPA = gpa.ToString("F2", CultureInfo.InvariantCulture);
    Console.WriteLine();
    Console.WriteLine($"Final GPA: {formattedGPA}");
}*/