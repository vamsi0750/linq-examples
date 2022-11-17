using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupBy
{
    internal class Program
    {
        static void Main()
        {
            var GroupByBranch = Student.GetStudents().GroupBy(s => s.Barnch);

            var GroupByGender = Student.GetStudents().GroupBy(s => s.Gender);

            var GroupById = Student.GetStudents().GroupBy(s => s.ID);

            var GroupByAge = Student.GetStudents().GroupBy(s => s.Age);

            var GroupByAgeAndGender = Student.GetStudents().GroupBy(s => new {s.Gender ,s.Age});

        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Barnch { get; set; }
        public int Age { get; set; }
        public static List<Student> GetStudents()
        {
            return new List<Student>()
        {
            new Student { ID = 1001, Name = "Preety", Gender = "Female",
                                         Barnch = "CSE", Age = 20 },
            new Student { ID = 1002, Name = "Snurag", Gender = "Male",
                                         Barnch = "ETC", Age = 21  },
            new Student { ID = 1003, Name = "Pranaya", Gender = "Male",
                                         Barnch = "CSE", Age = 21  },
            new Student { ID = 1004, Name = "Anurag", Gender = "Male",
                                         Barnch = "CSE", Age = 20  },
            new Student { ID = 1005, Name = "Hina", Gender = "Female",
                                         Barnch = "ETC", Age = 20 },
            new Student { ID = 1006, Name = "Priyanka", Gender = "Female",
                                         Barnch = "CSE", Age = 21 },
            new Student { ID = 1007, Name = "santosh", Gender = "Male",
                                         Barnch = "CSE", Age = 22  },
            new Student { ID = 1008, Name = "Tina", Gender = "Female",
                                         Barnch = "CSE", Age = 20  },
            new Student { ID = 1009, Name = "Celina", Gender = "Female",
                                         Barnch = "ETC", Age = 22 },
            new Student { ID = 1010, Name = "Sambit", Gender = "Male",
                                         Barnch = "ETC", Age = 21 }
        };
        }

    }
    }
