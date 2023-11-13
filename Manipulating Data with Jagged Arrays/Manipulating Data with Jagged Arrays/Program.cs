using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Data_with_Jagged_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a jagged array to store student scores
            int[][] studentScores = new int[3][]
            {
    new int[]{85, 92, 78},
    new int[]{90, 87, 93, 89},
    new int[]{76, 88}
            };

            // Print the scores of each student using nested loop
            for (int studentIndex = 0; studentIndex < studentScores.Length; studentIndex++)
            {
                Console.WriteLine($"Student {studentIndex + 1}:");
                for (int scoreIndex = 0; scoreIndex < studentScores[studentIndex].Length; scoreIndex++)
                {
                    Console.Write(studentScores[studentIndex][scoreIndex] + " ");
                }
                Console.WriteLine();
            }

            // Calculate the average score for each student and print the results
            for (int studentIndex = 0; studentIndex < studentScores.Length; studentIndex++)
            {
                int totalScore = 0;
                for (int scoreIndex = 0; scoreIndex < studentScores[studentIndex].Length; scoreIndex++)
                {
                    totalScore += studentScores[studentIndex][scoreIndex];
                }
                double averageScore = (double)totalScore / studentScores[studentIndex].Length;
                Console.WriteLine($"Average score for student {studentIndex + 1}: {averageScore}");
            }

            double averageScoreForAllStudents = 0;
            int totalScoreForAllStudents = 0;

            for (int studentIndex = 0; studentIndex < studentScores.Length; studentIndex++)
            {
                for (int scoreIndex = 0; scoreIndex < studentScores[studentIndex].Length; scoreIndex++)
                {
                    totalScoreForAllStudents += studentScores[studentIndex][scoreIndex];
                }
            }

            averageScoreForAllStudents = (double)totalScoreForAllStudents / studentScores.Length;

            Console.WriteLine($"Average score for all students combined: {averageScoreForAllStudents}");
            Console.ReadKey();
        }
        
    }
}
