using AmplituderCity;
Console.WriteLine("Witaj w programie do obliczania amplitudy temperatur dla kilku miast w Polsce");
Console.WriteLine("Zaczynamy:");


var checkerGdynia = new CheckerInFile("Polska", "Pomorskie","Gdynia");
var checkerGdansk = new CheckerInFile("Polska", "Pomorskie", "Gdańsk");
var checkerWarszawa = new CheckerInFile("Polska", "Mazowieckie", "Warszawa");
var checkerKrakow = new CheckerInFile("Polska", "Małopolskie", "Kraków");


void CheckerGradeAdded(object sender, EventArgs args)
{
    var checker = (CheckerInFile)sender;
    Console.WriteLine($"Nowa wartość temperatury dla miasta {checker.City}:");
}

while (true)
{
    Console.WriteLine("Podaj wysokość temperatury dla Gdyni (jeżeli chcesz przejść do następnego miasta wciśnij q):");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        checkerGdynia.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

while (true)
{
    Console.WriteLine("Podaj wysokość temperatury dla Gdańska (jeżeli chcesz przejść do następnego miasta wciśnij q):");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        checkerGdansk.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

while (true)
{
    Console.WriteLine("Podaj wysokość temperatury dla Warszawy (jeżeli chcesz przejść do następnego miasta wciśnij q):");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        checkerWarszawa.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

while (true)
{
    Console.WriteLine("Podaj wysokość temperatury dla Krakowa (jeżeli chcesz zakończyć wciśnij q):");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        checkerKrakow.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}


var statistics = checkerGdynia.GetStatistics();
Console.WriteLine("Statystyki dla Gdyni:");
Console.WriteLine($"Średnia: {statistics.Average:N2}");
Console.WriteLine($"Najniższa: {statistics.Min}");
Console.WriteLine($"Najwyższa: {statistics.Max}");
Console.WriteLine();

statistics = checkerGdansk.GetStatistics();
Console.WriteLine("Statystyki dla Gdańska:");
Console.WriteLine($"Średnia: {statistics.Average:N2}");
Console.WriteLine($"Najniższa: {statistics.Min}");
Console.WriteLine($"Najwyższa: {statistics.Max}");
Console.WriteLine();

statistics = checkerWarszawa.GetStatistics();
Console.WriteLine("Statystyki dla Warszawy:");
Console.WriteLine($"Średnia: {statistics.Average:N2}");
Console.WriteLine($"Najniższa: {statistics.Min}");
Console.WriteLine($"Najwyższa: {statistics.Max}");
Console.WriteLine();

statistics = checkerKrakow.GetStatistics();
Console.WriteLine("Statystyki dla Krakowa:");
Console.WriteLine($"Średnia: {statistics.Average:N2}");
Console.WriteLine($"Najniższa: {statistics.Min}");
Console.WriteLine($"Najwyższa: {statistics.Max}");
Console.WriteLine();
