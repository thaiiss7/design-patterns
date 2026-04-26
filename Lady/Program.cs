using Lady.Interfaces;
using Lady.Scene;

namespace Lady;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        Factory factory = new();
        // Exemplo de registro na factory
        // ("square", (x,y) => new Square(x,y))

        Application.Run(new Board(factory));
    }    
}