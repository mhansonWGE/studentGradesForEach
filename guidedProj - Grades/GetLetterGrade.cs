using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guidedProj___Grades
{
    public class GetLetterGrade
    {
        public static string getLetter(decimal numGrade = 0)
        {
            string ltrGrade = "F";
            if (numGrade >= 97)
                ltrGrade = "A+";
            else if (numGrade >= 93)
                ltrGrade = "A";
            else if (numGrade >= 90)
                ltrGrade = "A-";
            else if (numGrade >= 87)
                ltrGrade = "B+";
            else if (numGrade >= 83)
                ltrGrade = "B";
            else if (numGrade >= 80)
                ltrGrade = "B-";
            else if (numGrade >= 77)
                ltrGrade = "C+";
            else if (numGrade >= 73)
                ltrGrade = "C";
            else if (numGrade >= 70)
                ltrGrade = "C-";
            else if (numGrade >= 67)
                ltrGrade = "D+";
            else if (numGrade >= 63)
                ltrGrade = "D";
            else if (numGrade >= 60)
                ltrGrade = "D-";
            else
                ltrGrade = "F";

            return ltrGrade;
        }
    }
}
