public class ConcreteShapeCreatorB : ShapeCreator
{
    public override IShape CreateShape(string type)
    {
        switch (type)
        {
            case "square": return new Square();
            default:
                Console.WriteLine($"Tipo errato");
                return null;
        }
    }
}