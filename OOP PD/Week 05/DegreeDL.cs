using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.UI;

namespace uams
{
    internal class DegreeDL
    {
        public static List<Degree> Degrees = new List<Degree>();
        static public void AddDegree(Degree degree)
        {
            Degrees.Add(degree);
        }
        public static void SaveDegreeDataIntoFile(Degree d)
        {
            string path = "G:\\Task 01(UAMS)\\uams(Degree).txt";
            StreamWriter Degreefile = new StreamWriter(path, true);
            Degreefile.Write($"{d.DegreeTitle},{d.Duration},{d.Seats},");
            for(int i=0;i< d.SubjectsAdd.Count;i++)
            {
                Degreefile.Write(d.SubjectsAdd[i].Subjecttype);
                if(i==d.SubjectsAdd.Count-1)
                    Degreefile.Write("\n");
                else
                Degreefile.Write(";");
            }
            Degreefile.Flush();
            Degreefile.Close();
        }
        public static void LoadDegreeDataFromFile()
        {
            string title;
            int duration;
            int seats;
            string type;
            string record = "";
            string path = "G:\\Task 01(UAMS)\\uams(Degree).txt";
            if (File.Exists(path))
            {
                StreamReader degfile = new StreamReader(path);
                while ((record = degfile.ReadLine()) != null)
                {
                    string[] splittedrecord = record.Split(',');
                    title = splittedrecord[0];
                    duration = int.Parse(splittedrecord[1]);
                    seats = int.Parse(splittedrecord[2]);
                    Degree d1 = new Degree(title, duration, seats);
                    Degrees.Add(d1);
                    string[] splittedsubjects= splittedrecord[3].Split(';');
                    for(int i=0;i<splittedsubjects.Length;i++)
                    {
                        type = splittedsubjects[i];
                        for(int x=0;x<SubjectDL.Subjects.Count;x++)
                        {
                            if(type== SubjectDL.Subjects[i].Subjecttype)
                            {
                                Subject sub = SubjectDL.Subjects[i];
                                d1.AddSubject(sub);
                            }
                        }
                    }
                }
                degfile.Close();
            }
	else{
	Console.Write("File Not Found");
	}
        }
    }
}
