namespace AmplituderCity;
public class CheckerInFile : CheckerBase
{
    public CheckerInFile(string country, string land, string city)
        : base(country, land, city) => fileNames = $"{city}_temperatures.txt";

    public override void AddGrade(byte grade)
    {
        float gradeAsFloat = grade;
        using (var writer = File.AppendText(fileNames))
        {
            if (gradeAsFloat >= -100 && gradeAsFloat <= 100)
            {
                writer.WriteLine(gradeAsFloat);
            }
            else
            {
                throw new Exception("Value out of range");
            }
        }
    }
    public override void AddGrade(long grade)
    {
        using (var writer = File.AppendText(fileNames))
        {
            writer.WriteLine((float)grade);
        }
    }
    public override void AddGrade(short grade)
    {
        float gradeAsFloat = (float)grade;
        using (var writer = File.AppendText(fileNames))
        {
            writer.WriteLine(gradeAsFloat);
        }
    }
    public override void AddGrade(double grade)
    {
        float gradeAsFloat = (float)grade;
        using (var writer = File.AppendText(fileNames))
        {
            writer.WriteLine(gradeAsFloat);
        }
    }
    public override void AddGrade(int grade)
    {
        float gradeAsFloat = (float)grade;
        using (var writer = File.AppendText(fileNames))
        {
            if (grade >= -100 && grade <= 100)
            {
                writer.WriteLine(gradeAsFloat);
            }
            else
            {
                throw new Exception("Value out of range");
            }
        }
    }
    public override Statistics GetStatistics()
    {
        var gradesFromFile = ReadGradesFromFile();
        var result = CountStatistics(gradesFromFile);
        return result;
    }

    private List<float> ReadGradesFromFile()
    {
        var grades = new List<float>();
        if (File.Exists(fileNames))
        {
            using (var reader = new StreamReader(fileNames))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (float.TryParse(line, out float number))
                    {
                        grades.Add(number);
                    }
                }
            }
        }
        return grades;
    }
    private Statistics CountStatistics(List<float> grades)
    {
        var statistics = new Statistics();
        foreach (var grade in grades)
        {
            statistics.AddGrade(grade);
        }

        return statistics;
    }

}

