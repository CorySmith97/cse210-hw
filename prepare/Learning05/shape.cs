public abstract class Shape {
    private string _color;

    public string GetColor(){
        return _color;
    }
    protected Shape(string color){
        _color = color;
    }


    public abstract double GetArea();
}