using DependencyInjectionChallenge.Interfaces;

namespace DependencyInjectionChallenge
{
    public class Create : IDisposable
    {
        private Guid Id;
        private string? Name;

        public Create(string className)
        {
            Id = Guid.NewGuid();
            Name = className;
        }
        public void Dispose()
        {
            Console.WriteLine($"{Name} - Disposed");
        }
    }
}
