public class Aplication(IFactory factory)
{
    private IFactory Factory = factory;

    public void Logic()
    {
        Factory.CreateButton();
        Factory.CreateCheckbox();
    } 
}