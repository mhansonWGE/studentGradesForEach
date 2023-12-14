using guidedProj___Grades;
using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
string[] studentNames = new string[] { "Logan", "Sophia", "Emma", "Andrew" };
int[] studentScores = new int[10];
string studentLetterGrade = "";

int[] loganScores = new int[] {90,95,87,88,96};
int[] emmaScores = new int[] {90,85,87,98,68 };
int[] andrewScores = new int[] {92,89,81,96,90};
int[] sophiaScores = new int[] {90,86,87,98,100};


Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else studentScores = emmaScores;

    int sumScores = 0;
    decimal currStudentGrade = 0;

    foreach (int score in studentScores)
    {
        sumScores += score;
    }


    currStudentGrade = (decimal)sumScores / currentAssignments;


    studentLetterGrade = GetLetterGrade.getLetter(currStudentGrade);


    Console.WriteLine($"{currentStudent}\t\t{currStudentGrade}\t???");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
