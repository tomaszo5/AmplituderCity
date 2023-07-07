namespace AmplituderCity;

public class CheckerInMemory : CheckerBase
{
    private readonly List<float> grades = new List<float>();

    public override event GradeAddedDelegate GradeAdded;

    public CheckerInMemory(string country, string land, string city)
            : base(country, land, city)
    {
    }

    public override void AddGrade(float grade)
    {
        if (grade >= -100 && grade <= 100)
        {
            this.grades.Add(grade);

            if(GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
        }
        else
        {
            throw new Exception("invalid temperature value");
        }
    }

    public override void AddGrade(string grade)
    {
        if (float.TryParse(grade, out float result))
        {
            this.AddGrade(result);
        }
        else
        {
            throw new Exception("Wrong Number");
        }
    }

    public override void AddGrade(byte grade)
    {
        this.AddGrade((float)grade);
    }

    public override void AddGrade(long grade)
    {
        this.AddGrade((float)grade);
    }
    public override void AddGrade(short grade)
    {
        this.AddGrade((float)grade);
    }
    public override void AddGrade(double grade)
    {
        float gradeAsFloat = (float)grade;
        this.AddGrade(gradeAsFloat);
    }

    public override void AddGrade(int grade)
    {
        float gradeAsFloat = grade;
        this.AddGrade(gradeAsFloat);
    }

    public override void AddGrade(char grade)
    {
         throw new Exception("Wrong Number");
        
    }

    public override Statistics GetStatistics()
    {
        var statistics = new Statistics();
        foreach(var grade in this.grades)
        {
            statistics.AddGrade(grade);
        }    
        return statistics;
    }

}