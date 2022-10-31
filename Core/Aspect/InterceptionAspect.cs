using Castle.DynamicProxy;
using Core.Utilities.Interceptors;

namespace Core.Aspect;
public class InterceptionAspect : MethodInterception
{
    public override void OnBefore(IInvocation invocation)
    {
        Console.WriteLine("Before Run Method");
    }
    public override void OnAfter(IInvocation invocation)
    {
        Console.WriteLine("After Run Method");
    }
}

