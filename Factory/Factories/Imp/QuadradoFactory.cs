public class QuadradoFactory : IFactory
{
    public IFormaGeomtrica Create()
    {
        Console.WriteLine("Quadrado criado com sucesso!");
        return new Quadrado();
    }
}