using System;
using System.Threading.Tasks;
using SharpPad;
using static System.Math;
using Console = Colorful.Console;

namespace test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string name = "Peter";
            double gpa = 3.5;
            var student = (name, gpa);

            string accolades = CalculateAccolades(student);
            
            await accolades.Dump();

            await student.Dump();

            using var stream = System.IO.File.OpenText("demo.txt");

            string content = await stream.ReadToEndAsync();

            await content.Dump();

            string CalculateAccolades((string name, double gpa) student) =>
                student switch
                {
                    var s when s.gpa >= 4.0 => "Scholar Roll",
                    var s when s.gpa >= 3.0 && s.gpa < 4.0 => "Honor Roll",
                    _ => String.Empty
                };
        }
    }

    class Student
    {
        public Student(string name) => Name = name;
        
        public string Name { get; }
        
        public double GPA { get; set; }
    }
}