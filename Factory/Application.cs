public class Application(IFactory factory)
{
    private IFactory Factory = factory;

    public void Logic()
    {
        Factory.Create();
    }
}