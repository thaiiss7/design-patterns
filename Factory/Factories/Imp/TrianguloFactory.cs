public class TrianguloFactory : IFactory
{
    public IFormaGeomtrica Create()
    {
        Console.WriteLine("Triangulo criado com sucesso!");
        return new Triangulo();
    }
}