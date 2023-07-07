using static AmplituderCity.CheckerBase;
namespace AmplituderCity;

    public interface IChecker
    {
        string Country { get; }
        string Land { get; }
        string City { get; }


        void AddGrade (float grade);    
        void AddGrade (double grade);
        void AddGrade(int grade);   
        void AddGrade(char grade);
        void AddGrade(string grade);
        void AddGrade(byte grade);
        void AddGrade(short grade);

        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();
    }

