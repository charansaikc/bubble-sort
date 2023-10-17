
using System;

namespace Phase1Section4._21
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] students = new string[10];
            students[0] = "Kumar";
            students[1] = "Mojesh";
            students[2] = "Ajay";
            students[3] = "Sai";
            students[4] = "Naresh";
            students[5] = "Fazal";
            students[6] = "Tarun";
            students[7] = "Ganesh";
            students[8] = "Charandini";
            students[9] = "Kedar";

            bool flag = true;
            string temp;
            int numLength = students.Length;
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (students[j + 1].CompareTo(students[j]) < 0)
                    {
                        temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                        flag = true;
                    }
                }
            }


            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}

