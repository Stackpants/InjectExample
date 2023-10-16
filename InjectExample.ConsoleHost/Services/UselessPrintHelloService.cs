namespace InjectExample.ConsoleHost.Services;

public class UselessPrintHelloService : IOtherService
{
    public void DoSomethingUseless()
    {
        Console.WriteLine("HELLO!! I DON'T CONTRIBUTE ANY VALUE");
    }
}
