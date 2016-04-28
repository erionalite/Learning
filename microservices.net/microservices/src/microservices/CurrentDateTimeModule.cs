using System;
using Nancy;

namespace microservices
{
    public class CurrentDateTimeModule : NancyModule
    {
        public CurrentDateTimeModule()
        {
            Get["/"] = _ => DateTime.Now;
        }
    }
}
