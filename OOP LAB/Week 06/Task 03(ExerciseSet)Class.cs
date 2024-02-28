using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Lab_06_
{
    internal class ExerciseSet
    {
        private double Weight;
        private int Repitition;

        public ExerciseSet(double weight, int rep)
        {
            this.Weight = weight;
            this.Repitition = rep;
        }
        public void SetWeight(double weight)
        {
            this.Weight = weight;

        }
        public double GetWeight()
        {
            return Weight;
        }
        public void SetRepitition(int rep)
        {
            this.Repitition = rep;

        }
        public float GetRepitition()
        {
            return Repitition;
        }
    }

}
