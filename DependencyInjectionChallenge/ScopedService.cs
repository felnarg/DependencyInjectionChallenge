using DependencyInjectionChallenge.Interfaces;

namespace DependencyInjectionChallenge
{
    public class ScopedService : Create, IScopedService
    {
        public ScopedService() : base("scoped") { }
        public string Get()
        {
            string message = "instancia scoped creada";
            return message;
        }
    }
}
