using guidedProj___Grades;
using System.ComponentModel.Design;
/*using System;
*/
// initialize variables - graded assignments 
int currentAssignments = 8;
string[] studentNames = new string[] { "Logan", "Sophia", "Emma", "Andrew", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];
string studentLetterGrade = "";

int[] loganScores = new int[] {90,95,87,88,96,0,0};
int[] emmaScores = new int[] {90,85,87,98,68,0,0 };
int[] andrewScores = new int[] {92,89,81,96,90};
int[] sophiaScores = new int[] {90,86,87,98};
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };


Console.WriteLine("Student\t\tGrade\t\t\t\tLetter Grade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores; 
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores; 
    else studentScores = emmaScores;

    int sumScores = 0;
    decimal currStudentGrade = 0;

    foreach (int score in studentScores)
    {
        sumScores += score;
    }


    currStudentGrade = (decimal)sumScores / currentAssignments;


    studentLetterGrade = GetLetterGrade.getLetter(currStudentGrade);


    Console.WriteLine($"{currentStudent}\t\t{currStudentGrade}\t\t\t\t{studentLetterGrade}\n");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
