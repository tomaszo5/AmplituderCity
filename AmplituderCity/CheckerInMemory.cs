namespace AmplituderCity;
public class CheckerInMemory : CheckerBase
{
    private readonly List<float> grades = new List<float>();

    public CheckerInMemory(string country, string land, string city)
            : base(country, land, city)
    {

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

    public override Statistics GetStatistics()
    {
        var statistics = new Statistics();
        foreach (var grade in this.grades)
        {
            statistics.AddGrade(grade);
        }
        return statistics;
    }
}