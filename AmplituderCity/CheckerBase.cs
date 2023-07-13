namespace AmplituderCity;
public abstract class CheckerBase : IChecker
{
    private readonly List<float> grades = new List<float>();
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    public event GradeAddedDelegate GradeAdded;
    public CheckerBase(string country, string land, string city)
    {
        this.Country = country;
        this.Land = land;
        this.City = city;
    }
    public string fileNames;
    public string Country { get; private set; }
    public string Land { get; private set; }
    public string City { get; private set; }
    public void AddGrade(float grade)
    {
        if (grade >= -100 && grade <= 100)
        {
            if (!File.Exists(fileNames))
            {
                using (var writer = File.CreateText(fileNames)) { }
            }

            using (var writer = File.AppendText(fileNames))
            {
                writer.WriteLine(grade);
            }

            GradeAdded?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            throw new Exception("Invalid temperature value");
        }
    }
    public abstract void AddGrade(long grade);
    public abstract void AddGrade(double grade);
    public abstract void AddGrade(int grade);
    public void AddGrade(char grade)
    {
        if (float.TryParse(grade.ToString(), out float result) && result >= -100 && result <= 100)
        {
            this.AddGrade(result);
        }
        else
        {
            throw new Exception("Invalid temperature value");
        }
    }
    public void AddGrade(string grade)
    {
        if (float.TryParse(grade, out float result) && result >= -100 && result <= 100)
        {
            if (!File.Exists(fileNames))
            {
                using (var writer = File.CreateText(fileNames)) { }
            }

            using (var writer = File.AppendText(fileNames))
            {
                writer.WriteLine(grade);
            }
        }
        else
        {
            throw new Exception("Wrong Temperature");
        }
    }
    public abstract void AddGrade(byte grade);
    public abstract void AddGrade(short grade);
    public abstract Statistics GetStatistics();
}

