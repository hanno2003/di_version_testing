using System;

namespace WebApplication1.Services
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ServiceVersion : Attribute
    {
        public string Version { get; set; }
        public Type Type { get; set; }
    }
}
