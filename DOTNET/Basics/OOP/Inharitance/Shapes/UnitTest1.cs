public class Tests
{
    [TestCase(ExpectedResult = "name:'Shape',color:'white'")]
    public string Shape_Test()
    {
        var s = new Shape("white");
        return s.GetDetails();
    }

    [TestCase(2, ExpectedResult = "name:'Square',color:'blue',perimeter:8")]
    public string Square_Test1(int sideA)
    {
        var sq = new Square("blue", sideA);
        return sq.GetDetails();
    }
    [TestCase(2, 3, ExpectedResult = "name:'Square',color:'blue',perimeter:10")]
    public string Square_Test2(int sideA, int sideB)
    {
        var sq = new Square("blue", sideA, sideB);
        return sq.GetDetails();
    }

    [TestCase(2, 3, 4, ExpectedResult = "name:'Triangle',color:'yellow',perimeter:9")]
    public string Triangle_Test(int sideA, int sideB, int sideC)
    {
        var t = new Triangle("yellow", sideA, sideB, sideC);
        return t.GetDetails();
    }

    [TestCase(2, ExpectedResult = "name:'Circle',color:'red',perimeter:12.57")]
    public string Circle_Test(int radius)
    {
        var c = new Circle("red", radius);
        return c.GetDetails();
    }

    [TestCase(2, ExpectedResult = "name:'Circle',color:'red',perimeter:12.57;name:'Square',color:'blue',perimeter:8;name:'Triangle',color:'yellow',perimeter:6")]
    public string Shapes_Test(int sideA)
    {
        var sps = new string[]
        {
            new Circle("red", sideA).GetDetails(),
            new Square("blue", sideA).GetDetails(),
            new Triangle("yellow", sideA, sideA, sideA).GetDetails()
        };
        return string.Join(';', sps);
    }
}