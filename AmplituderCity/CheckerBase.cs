namespace AmplituderCity;

public abstract class CheckerBase : IChecker
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public abstract event GradeAddedDelegate GradeAdded;

    public CheckerBase(string country, string land,string city)
    {
        this.Country = country;
        this.Land = land;
        this.City = city;
    }
    public string Country { get; private set; }
    public string Land { get; private set; }
    public string City { get; private set; }    

    public abstract void AddGrade(float grade);
    public abstract void AddGrade(long grade);
    public abstract void AddGrade(double grade);
    public abstract void AddGrade(int grade);
    public abstract void AddGrade(char grade);
    public abstract void AddGrade(string grade);
    public abstract void AddGrade(byte grade);
    public abstract void AddGrade(short grade);


    public abstract Statistics GetStatistics();

}
