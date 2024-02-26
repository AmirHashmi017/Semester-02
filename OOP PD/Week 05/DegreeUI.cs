using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams
{
    internal class DegreeUI
    {
       public static Degree AddDegreeUI(List<Subject> subjects)
        {
            string degtitle, subcode, subtype;
            int number, duration, credithours, seats;
            double fee;
            Console.Write(" Enter Degree Name: ");
            degtitle = Console.ReadLine();
            Console.Write(" Enter Degree Duration: ");
            duration = int.Parse(Console.ReadLine());
            Console.Write(" Enter Seats for Degree: ");
            seats = int.Parse(Console.ReadLine());
            Degree deg1 = new Degree(degtitle, duration, seats);
            Console.Write("How many subjects you want to add in Degree: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter subject {0} code: ", i + 1);
                subcode = Console.ReadLine();
                Console.Write("Enter subject {0} type: ", i + 1);
                subtype = Console.ReadLine();
                Console.Write("Enter subject {0} Credit Hours: ", i + 1);
                credithours = int.Parse(Console.ReadLine());
                Console.Write("Enter subject {0} Fees: ", i + 1);
                fee = double.Parse(Console.ReadLine());
                Subject sub =SubjectDL.AddSubjectToList(subcode, subtype, credithours, fee);
                subjects.Add(sub);
                if (deg1.AddSubject(sub))
                {
                    Console.WriteLine(" Subject cannot be added as Limit of credit hours is exceeded.");

                    break;
                }
            }
            return deg1;
        }

    }
}
