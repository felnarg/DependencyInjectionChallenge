using System.Text;
using DependencyInjectionChallenge.Interfaces;

namespace DependencyInjectionChallenge
{
    public class Create : IDisposable
    {
        private Guid Id;
        private string? Name;
        StringBuilder sb = new StringBuilder();
        public static string? Message { get; set; }

        public Create(string className)
        {
            Id = Guid.NewGuid();
            Name = className;
        }
        public void Dispose()
        {
            //Console.WriteLine($"{Name} - Disposed");
            Message = sb.Append($"{Id} {Name} - Disposed").ToString();
        }
    }
}
