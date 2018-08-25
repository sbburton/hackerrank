using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades) {
        /*
         * Write your code here.
         */
        
        var numberOfGrades = grades.Length;
        var roundedGrades = new int[numberOfGrades];
        
        for (var i = 0; i < numberOfGrades; i++)
        {
            var remainder = grades[i] % 5;
            if (grades[i] < 38)
                roundedGrades[i] = grades[i];
            else if (remainder > 2)
                roundedGrades[i] = grades[i] + 5 - remainder;
            else
                roundedGrades[i] = grades[i];
        }
        
        return roundedGrades;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}

