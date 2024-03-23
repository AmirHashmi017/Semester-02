using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_03
{
    internal class Student:Person
    {
        protected string DegreeProgram;
        protected int Year;
        protected double Fee;

        public Student(string name, string adress,string program,int year,double fee):base(name,adress)
        {
            DegreeProgram = program;
            Year = year;
            Fee = fee;
        }
        public string GetDegreeProgram()
        { return DegreeProgram; }
        public int GetYear()
        { return Year; }
        public double GetFee()
        { return Fee; }
        public void SetDegreeProgram(string program)
        { this.DegreeProgram = program; }
        public void SetYear(int year)
        { this.Year = year; }
        public void SetFee(double fee)
        { this.Fee = fee; }
	public new string To_String()
            {
	string personinfo=base.To_String();
            return ($" {personinfo} \t Degree Program: {DegreeProgram}\t Year: {Year} \t Fee:  {Fee}");
        }
    }
}
