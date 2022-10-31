using Business.Abstract;
using Core.Aspect;

namespace Business.Concrete;

public class UserManager : IUserService
{
    [InterceptionAspect]
    public void Add()
    {
        Console.WriteLine("Added Success");
    }
}
