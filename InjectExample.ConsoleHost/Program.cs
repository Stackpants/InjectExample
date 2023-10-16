
using System.ComponentModel.Design;
using InjectExample.ConsoleHost.Services;
using Microsoft.Extensions.DependencyInjection;


namespace InjectExample.ConsoleHost;

public class Program
{
    public static void Main(string[] args)
    {
        ServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<ICalculationService, AddTenToNumberService>();
        serviceCollection.AddSingleton<IOtherService, UselessPrintHelloService>();
        var provider = serviceCollection.BuildServiceProvider();
        var calculator = provider.GetService<ICalculationService>()!;
        var shouldBeFifteen = calculator.AddNumber(5);
        Console.WriteLine(shouldBeFifteen);

    }
}
