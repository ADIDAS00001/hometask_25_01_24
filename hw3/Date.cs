namespace hw3;

public class Date
{
    int _day;
    int _month;
    int _year;
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public Date(){}

    public Date(int day)
    {
        _day=day;
    }
    public Date(int day,int month)
    {
        _day=day;
        _month=month;
    }
     public Date(int day,int month,int year)
    {
        _day=day;
        _month=month;
        _year=year;
    }
    public void  SetDate(int day, int month, int year)
    {
        _day=day;
         _month=month;
        _year=year;
    }
    
    public int GetDay()
    {
        return _day;
    }
    public int GetMonth()
    {
        return _month;
    }
    public int GetYear()
    {
        return _year;
    }
}