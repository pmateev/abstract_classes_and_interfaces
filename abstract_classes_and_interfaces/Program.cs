using abstract_classes;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Position> positions = new List<Position>
        {
            new Student { Name = "Georgi", Age = 21 },
            new Teacher { Name = "Petur", Age = 32 },
            new Adminsitrator { Name = "Aleksandra", Age = 48 }
        };

        Console.WriteLine("Different people in Uni: ");
        foreach (var prsn in positions)
        {
            prsn.Info();
            prsn.Show();
            Console.WriteLine();
        }
    }
}
