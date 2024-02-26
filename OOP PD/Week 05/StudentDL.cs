using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace uams
{
    internal class StudentDL
    {
       public static List<Student> Students = new List<Student>();
        public static void AddStudent(Student student)
        {
            Students.Add(student);
        }
public static void SaveStudentDataIntoFile(Student s )
        {
            string path = "G:\\Task 01(UAMS)\\uams(Student).txt";
            StreamWriter Studentfile = new StreamWriter(path, true);
            Studentfile.Write($"{s.Name},{s.Age},{s.FscMarks},{s.EcatMarks},{s.Merit},{s.DegreeRegistered.DegreeTitle},");
	for(int n=0;n< s.Preferences.Count;n++)
            {
                Studentfile.Write(s.Preferences[n].DegreeTitle);
                if(n==s.Preferences.Count-1)
                    Studentfile.Write(",");
                else
                Studentfile.Write(";");
            }
            for(int i=0;i< s.SubjectsRegistered.Count;i++)
            {
                Studentfile.Write(s.SubjectsRegistered[i].Subjecttype);
                if(i==s.SubjectsRegistered.Count-1)
                    Studentfile.Write("\n");
                else
                Studentfile.Write(":");
            }
            Studentfile.Flush();
            Studentfile.Close();
}
        public static void LoadStudentDataFromFile()
        {
            string title;
	string Name;
int Age;
string deg;
double FscMarks,EcatMarks;
List<Degree>preferenceList=new List<Degree>();
            string type;
            string record = "";
            string path = "G:\\Task 01(UAMS)\\uams(Student).txt";
            if (File.Exists(path))
            {
                StreamReader Studentfile = new StreamReader(path);
                while ((record = Studentfile.ReadLine()) != null)
                {
                    string[] splittedrecord = record.Split(',');
                    Name = splittedrecord[0];
                    Age= int.Parse(splittedrecord[1]);
                    FscMarks = double.Parse(splittedrecord[2]);
	EcatMarks = double.Parse(splittedrecord[3]);
string[] splittedpreferences= splittedrecord[6].Split(';');
for(int n=0;n<splittedpreferences.Length;n++)
                    {
                         title= splittedpreferences[n];
                        for(int p=0;p<DegreeDL.Degrees.Count;p++)
                        {
                            if(title== DegreeDL.Degrees[p].DegreeTitle)
                            {
                                Degree d1 = DegreeDL.Degrees[p];
                                preferenceList.Add(d1);
                            }
                        }
                    }
                    Student s1 = new Student(Name, Age, FscMarks,EcatMarks,preferenceList);
                    Students.Add(s1);
		s1.Merit = double.Parse(splittedrecord[4]);
		deg=splittedrecord[5];
	for(int l=0;l<DegreeDL.Degrees.Count;l++)
                        {
                            if(deg== DegreeDL.Degrees[l].DegreeTitle)
                            {
                               s1.DegreeRegistered = DegreeDL.Degrees[l];
                            }
                        }
                    string[] splittedsubjects= splittedrecord[7].Split(':');
                    for(int i=0;i<splittedsubjects.Length;i++)
                    {
                        type = splittedsubjects[i];
                        for(int x=0;x<SubjectDL.Subjects.Count;x++)
                        {
                            if(type== SubjectDL.Subjects[i].Subjecttype)
                            {
                                Subject sub = SubjectDL.Subjects[i];
                                s1.AddStudentSubject(sub);
                            }
                        }
                    }
                }
                Studentfile.Close();}
else{
Console.Write("File Not Found");
}
            }
    }
}

