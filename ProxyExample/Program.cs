using ProxyExample;

Console.WriteLine("Before Proxy Pattern");
RealSubject subject = new RealSubject();
subject.Request();

Console.WriteLine(new String('-', 50));

Console.WriteLine("After Proxy Pattern");
RealSubjectProxy realSubjectProxy = new RealSubjectProxy(subject);
realSubjectProxy.Request();