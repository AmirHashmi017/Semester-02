using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams
{
    internal class SubjectDL
    {
        public static List<Subject> Subjects = new List<Subject>();
        public static Subject AddSubjectToList(string subcode,string subtype,int credithours,double fee)
        {
            Subject Sub1=new Subject(subcode,subtype,credithours,fee);
            Subjects.Add(Sub1);
            SaveSubjectDataIntoFile(Sub1);
            return Sub1;
        }
        public static void SaveSubjectDataIntoFile(Subject s)
        {
            string path = "G:\\Task 01(UAMS)\\uams(Subject).txt";
            StreamWriter subjectfile = new StreamWriter(path, true);
            subjectfile.WriteLine($"{s.Subjectcode},{s.Subjecttype},{s.Credithours},{s.Subjectfee}");
            subjectfile.Flush();
            subjectfile.Close();
        }
public static void LoadSubjectDataFromFile()
        {
            string record;
            string path = "G:\\Task 01(UAMS)\\uams(Subject).txt";
            if(File.Exists(path))
            {
                StreamReader subfile=new StreamReader(path);
            while((record=subfile.ReadLine())!=null)
                {
                    string[] data= record.Split(',');
                    string code= data[0];
                    string type=data[1];
                    int credit = int.Parse(data[2]);
                    double fee= double.Parse(data[3]);
                    Subject s1=new Subject(code, type, credit, fee);
                    Subjects.Add(s1);
                }
                subfile.Close();
            }
            else {Console.WriteLine("File Not Found"); }
        }
    }
}
