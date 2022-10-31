using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors;
public class MethodInterception : MethodInterceptionBaseAttribute
{
    public virtual void OnBefore(IInvocation invocation) { }
    public virtual void OnAfter(IInvocation invocation) { }
    public virtual void OnException(IInvocation invocation, Exception ex) { }
    public virtual void OnSuccess(IInvocation invocation) { }

    public override void Intercept(IInvocation invocation)
    {
        bool IsSuccess = true;
        OnBefore(invocation);
        try
        {
            invocation.Proceed();
        }
        catch (Exception ex)
        {
            IsSuccess = false;
            OnException(invocation, ex);
            throw;
        }
        finally
        {
            if (IsSuccess)
                OnSuccess(invocation);
        }
        OnAfter(invocation);
    }
}

