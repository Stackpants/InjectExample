namespace InjectExample.ConsoleHost.Services;

public class AddTenToNumberService : ICalculationService
{
    private readonly IOtherService otherService;

    /// <summary>
    /// The advantage of the dependency container is that we no longer have to manage writing new ... whenever we
    /// need some "system" inside another "system/service". We just add the interfaces we need in the constructors
    /// and now the service container takes care of creating all the actual objects we need.
    ///
    /// This makes it a lot quicker to refactor
    /// </summary>
    /// <param name="otherService"></param>
    public AddTenToNumberService(IOtherService otherService)
    {
        this.otherService = otherService;
    }


    public int AddNumber(int toThisNumber)
    {
        otherService.DoSomethingUseless();
        return toThisNumber + 10;
    }
}
