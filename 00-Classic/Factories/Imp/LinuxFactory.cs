public class LinuxFactory : IFactory
{
    public IButton CreateButton()
    {
        Console.WriteLine("BOTÃO LINUX");
        return new LinuxButton();
    }
}