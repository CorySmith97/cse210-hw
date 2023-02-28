public class Triangle: Shape{
    private float _longSide;
    private float _shortSide;

    public Triangle(string color, float longSide, float shortSide): base (color){
        _longSide = longSide;
        _shortSide = shortSide;
    }
    public override double GetArea()
    {
        return .5 * _longSide * _shortSide;
    }

}