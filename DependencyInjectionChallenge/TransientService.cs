using DependencyInjectionChallenge.Interfaces;

namespace DependencyInjectionChallenge
{
    public class TransientService : Create, ITransientService
    {
        public TransientService() : base ("transient"){ }

        public string Get()
        {
            string message = "instancia transient creada";
            return message;
        }
    }
}
