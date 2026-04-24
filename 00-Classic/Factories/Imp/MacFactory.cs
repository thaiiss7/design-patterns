public class MacFactory : IFactory
{
    public IButton CreateButton()
    {
        Console.WriteLine("BOTÃO MAC");
        return new MacButton();
    }
}