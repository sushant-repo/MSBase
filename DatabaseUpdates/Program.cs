using DbUp;
using System.Reflection;


internal class Program
{
    private static int Main(string[] args)
    {
        var connectionString = "Data Source=(local);Initial Catalog=MSBase;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";
        EnsureDatabase.For.SqlDatabase(connectionString);

        var assembly = Assembly.GetExecutingAssembly();
        var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(assembly, name => name.Contains("Scripts"))
                    .WithScriptsEmbeddedInAssembly(assembly, name => name.Contains("Managed") && name.Contains("Procedures"))
                    .LogToConsole()
                    .WithTransaction()
                    .Build();

        var result = upgrader.PerformUpgrade();

        if (!result.Successful)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(result.Error);
            Console.ResetColor();
#if DEBUG
            Console.ReadLine();
#endif
            return -1;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Success!");
        Console.ResetColor();
        return 0;
    }
}