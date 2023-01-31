public class CSFraction{
    private int _cstop;
    private int _csbottom;
    //constructors

    public CSFraction(){
        _cstop = 1;
        _csbottom = 1;
    }
    public CSFraction(int wholenumber){
        _cstop = wholenumber;
        _csbottom = 1;
    }
    public CSFraction(int top, int bottom){
        _cstop = top;
        _csbottom = bottom;
    }

    //functions to process data
    public double CSGetDecimalValue(){
        return (double)_cstop / (double)_csbottom;
    }

    public string CSGetFraction(){
        string cstop = _cstop.ToString();
        string csbottom = _csbottom.ToString();
        string csfraction = String.Format($"{cstop}/{csbottom}");
        return csfraction;
    }
}