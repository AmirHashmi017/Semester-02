using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Lab_06_
{
    internal class Exercise
    {
        private string ExerciseName;
        private List<ExerciseSet> Sets = new List<ExerciseSet>();
        public Exercise(string exerciseName)
        {
            ExerciseName = exerciseName;
        }
        public Exercise(string exerciseName, List<ExerciseSet> sets)
        {
            ExerciseName = exerciseName;
            this.Sets = sets;
        }
        public void SetExerciseName(string name)
        {
            ExerciseName = name;
        }
        public string GetExerciseName()
        {
            return ExerciseName;
        }
        public void AddSets(ExerciseSet set)
        {
            Sets.Add(set);
        }
        public List<ExerciseSet> GetSets()
        {
            return Sets;
        }

    }
}
