// Reads and displays a student file created in DebugFourteen2 program
using System;
using static System.Console;
using System.IO;
class DebugFourteen3
{
    static void Main()
    {
        const char DELIM = ',';
        const string FILENAME = "StudentData.txt";
        Student stu = new Student();
        FileStream inFile = new FileStream(FILENAME,FileMode.OpenOrCreate);
        StreamReader reader = new StreamReader(inFile);
        string recordIn;
        string[] fields;
        WriteLine("\n{0,-5}{1,-12}{2,8}\n", "Num", "Name", "GPA");
        recordIn = reader.ReadLine();
        while (recordIn != null)
        {
            fields = recordIn.Split(DELIM);
            stu.StuNum = Convert.ToInt32(fields[0]);
            stu.Name = fields[1];
            stu.Gpa = Convert.ToDouble(fields[2]);
            WriteLine("{0,-5}{1,-12}{2,8}", stu.StuNum, stu.Name, stu.Gpa.ToString("F2"));
            recordIn = reader.ReadLine();
        }
        reader.Close();
        inFile.Close();
    }
}

public class Student
{
    private double gpa;
    private const double MINGPA = 0.0;
    private const double MAXGPA = 4.0;
    public int StuNum { get; set; }
    public string Name { get; set; }
    public double Gpa
    {
        set
        {
            if (value >= MINGPA && value <= MAXGPA)
                gpa = value;
            else
                gpa = 0;
        }
        get
        {
            return gpa;
        }
    }
}
