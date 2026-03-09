public class ConcreteShapeCreatorA : ShapeCreator
{
    public override IShape CreateShape(string type)
    {
        switch (type)
        {
            case "circle": return new Circle();
            default:
                Console.WriteLine($"Tipo errato");
                return null;
        }
    }
}