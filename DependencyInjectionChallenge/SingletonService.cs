using DependencyInjectionChallenge.Interfaces;

namespace DependencyInjectionChallenge
{
    public class SingletonService : Create , ISingletonService
    {
        public SingletonService() : base("singleton"){}
        public string Get()
        {
            string message = "instancia singleton creada";
            return message;
        }
    }
}
