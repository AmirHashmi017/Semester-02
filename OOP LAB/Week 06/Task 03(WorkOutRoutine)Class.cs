using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Task_3_Lab_06_
{
    internal class WorkOutRoutine
    {
        private string RoutineName;
        private List<Exercise> Exercises = new List<Exercise>();
        public WorkOutRoutine(string routinename, string exname1, string exname2)
        {
            this.RoutineName = routinename;
            Exercise e1 = new Exercise(exname1);
            Exercise e2 = new Exercise(exname2);
            Exercises.Add(e1);
            Exercises.Add(e2);
        }
        public void SetRoutineName(string name)
        {
            RoutineName = name;
        }
        public string GetRoutineName()
        {
            return RoutineName;
        }
        public void AddExercise(string exname)
        {
            Exercise e = new Exercise(exname);
        Exercises.Add(e);
        }
        public List<Exercise> GetExercises()
        {
            return Exercises;
        }
    }
}
