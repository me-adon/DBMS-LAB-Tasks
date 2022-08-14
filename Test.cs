using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01task01
{
    public class Test
    {
        static void Main(string[] args)
        {
            List<Student> studenList = new List<Student>();

            using (var reader = new StreamReader(@"D:\2-1\DBMS\Lab-1\grades.txt"))
            {


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var segments = line.Split(';');

                    Student std = new Student();

                    std.ID = segments[0];
                    std.GPA = segments[1];
                    std.semester = segments[2];


                    studenList.Add(std);
                    
                }
            }

            //Console.WriteLine(studenList.Count);

            double maxGPA = 0.0;
            double maxindex = 0.0;



            for (int i = 0; i < studenList.Count; i++)
            {
                double tempGPA = Convert.ToDouble(studenList[i].GPA);
                if (tempGPA > maxGPA)
                {
                    maxGPA = tempGPA;
                    maxindex = i;
                    Console.WriteLine(studenList[Convert.ToInt32(maxindex)].ID);
                }
            }

            Console.WriteLine(studenList[Convert.ToInt32(maxindex)].ID);
            Console.ReadKey();

        }
    }
}