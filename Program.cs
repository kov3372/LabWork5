using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace struct_lab_student
{
    partial class Program
    {
        static Student[] ReadData(string fileName)
        {
            string[] pathForFile = File.ReadAllLines(fileName);
            Student[] ArrayOfStudent = new Student[pathForFile.Length];

            for (int i = 0; i < pathForFile.Length; i++)
            {
                ArrayOfStudent[i] = new Student(pathForFile[i]);
            }
            return ArrayOfStudent;
        }

        static void runMenu(Student[] studs)
        {
            for (int i = 0; i < studs.Length; i++)
            {
                if (studs[i].scholarship == 0)
                {
                    string mathematicsStr = char.ToString(studs[i].mathematicsMark);
                    string physicsStr = char.ToString(studs[i].physicsMark);
                    string informaticsStr = char.ToString(studs[i].informaticsMark);

                    int mathematics = Convert.ToInt32(mathematicsStr);
                    int physics = Convert.ToInt32(physicsStr);
                    int informatics = Convert.ToInt32(informaticsStr);

                    double averengeMark = (double)(mathematics + physics + informatics) / 3;
                    Console.WriteLine(" {0}  {1}  {2}  {3} - середній бал ", studs[i].surName, studs[i].firstName, studs[i].patronymic, averengeMark);
                }
            }
        }

        static void Main(string[] args)
        {
            string path = @"..\bin\Debug\input.txt";

            Student[] studs = ReadData(path);

            runMenu(studs);
        }
    }
}
