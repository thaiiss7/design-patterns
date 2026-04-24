public class WindowsFactory : IFactory
{
    public IButton CreateButton()
    {
        Console.WriteLine("BOTÃO WINDOWS");
        return new WindowsButton();
    }
}