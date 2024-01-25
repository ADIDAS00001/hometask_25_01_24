namespace hw2;

public class Circle
{
    double _radius ;
    double _pi=3.14;
    public Circle(){}
    public Circle(double radius)
    {
        _radius=radius;
    }
    public void SetRadius(double radius)
    {
        _radius=radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public double GetArea()
    {
        double Area;
        Area=_pi*_radius*_radius;
        return Area;
    }
    public double GetDiameter() 
    {
        double Diameter;
        Diameter=_radius*2;
        return Diameter;
    }
    public double GetCircumference()
    {
        double Circumference;
        Circumference=2*_pi*_radius;
        return Circumference;
    }

}
