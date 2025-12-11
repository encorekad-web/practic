using System;
using System.Collections.Generic;

namespace task_4
{
    class Student
    {
        public string Name;
        public int Score;
    }

    class Program
    {
        static void Main()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student { Name = "Анна", Score = 95 });
            list.Add(new Student { Name = "Пётр", Score = 95 });
            list.Add(new Student { Name = "Ольга", Score = 88 });
            list.Add(new Student { Name = "Иван", Score = 75 });
            list.Add(new Student { Name = "Мария", Score = 75 });
            Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>();
            foreach (Student s in list)
            {
                int scr = s.Score;
                if (!dict.ContainsKey(scr))
                {
                    dict[scr] = new List<string>();
                }
                dict[scr].Add(s.Name);
            }
            List<int> scrs = new List<int>();
            foreach (int scr in dict.Keys)
            {
                scrs.Add(scr);
            }
            for (int i = 0; i < scrs.Count; i++)
            {
                for (int j = i + 1; j < scrs.Count; j++)
                {
                    if (scrs[i] < scrs[j])
                    {
                        int temp = scrs[i];
                        scrs[i] = scrs[j];
                        scrs[j] = temp;
                    }
                }
            }
            Console.WriteLine("Результат:");
            foreach (int scr in scrs)
            {
                List<string> nameList = dict[scr];
                foreach (string name in nameList)
                {
                    Console.WriteLine($"{name} = {scr}");
                }
            }
        }
    }
}