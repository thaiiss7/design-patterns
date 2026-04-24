public class CirculoFactory : IFactory
{
    public IFormaGeomtrica Create()
    {
        Console.WriteLine("Circulo criado com sucesso!");
        return new Circulo();
    }
}