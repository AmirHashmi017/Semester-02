using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Lab_06_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkOutRoutine routine1 = new WorkOutRoutine("Day1", "pushup", "situps");
            List<Exercise> exercises = new List<Exercise>();
            exercises = routine1.GetExercises();
            Console.Write($" Exercises in routine{routine1.GetRoutineName()} are: ");
            foreach (Exercise ex in exercises)
            {
                Console.Write($"{ex.GetExerciseName()} , ");
            }
            ExerciseSet set1 = new ExerciseSet(10.5, 3);
            exercises[1].AddSets(set1);
            ExerciseSet set2 = new ExerciseSet(15.5, 7);
            exercises[1].AddSets(set2);
            List<ExerciseSet> sets = new List<ExerciseSet>();
            sets = exercises[1].GetSets();
            Console.Write($" \nThe sets in Exercise {exercises[1].GetExerciseName()} are: ");
            foreach (ExerciseSet s in sets)
            {
                Console.Write($"{s.GetWeight()}  Kg ");
            }
            Console.ReadKey();
        }
    }
}
