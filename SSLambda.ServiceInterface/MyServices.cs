using System;
using ServiceStack;
using SSLambda.ServiceModel;

namespace SSLambda.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
