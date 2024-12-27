namespace OOP03
{
    #region Part 02
    //internal interface IShape
    //{
    //    public double Area { get;  }

    //    public void DisplayShapeInfo();
    //}

    //internal interface ICircle: IShape
    //{
    //    public double Radius { get; set; }
    //}
    //internal interface IRectangle : IShape
    //{
    //    public double Length { get; set; }
    //    public double Width { get; set; }
    //}
    //internal class Rectangle: IRectangle
    //{
    //    public double Length { get; set; }
    //    public double Width { get; set; }

    //    public double Area {
    //        get { return Length * Width; }
    //    }
    //    public void DisplayShapeInfo()
    //    {
    //        Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {Area}");
    //    }

    //}
    //internal class Circle : ICircle
    //{
    //    public double Radius { get; set; }
        

    //    public double Area {
    //        get { return Radius * Radius * Math.PI ; }
    //    }
    //    public void DisplayShapeInfo()
    //    {
    //        Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");
    //    }

    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Q1: What is the primary purpose of an interface in C#? 
            // To define a blueprint for a class 
            #endregion

            #region Q2: Which of the following is NOT a valid access modifier for interface members in C#?
            // private
            #endregion

            #region Q3: Can an interface contain fields in C#?
            // No 
            #endregion

            #region Q4: In C#, can an interface inherit from another interface?
            //  Yes, interfaces can inherit from multiple interfaces 
            #endregion

            #region Q5: Which keyword is used to implement an interface in a class in C#?
            // implements 
            #endregion

            #region Q6: Can an interface contain static methods in C#? 
            // Yes ==> Default Methods 
            #endregion

            #region Q7: In C#, can an interface have explicit access modifiers for its members?
            // No, all members are implicitly public 
            #endregion

            #region Q8: What is the purpose of an explicit interface implementation in C#
            // To hide the interface members from outside access  
            #endregion

            #region Q9: In C#, can an interface have a constructor? 
            // No, interfaces cannot have constructors
            #endregion

            #region Q10: How can a C# class implement multiple interfaces? 
            // By separating interface names with commas
            #endregion
            #endregion

            #region Part 02
            //// Test Circle
            //Circle circle = new Circle();
            //circle.Radius = 10;
            //circle.DisplayShapeInfo();

            //// Test Rectangle
            //IRectangle rectangle = new Rectangle();
            //rectangle.Length = 10;
            //rectangle.Width = 10;
            //rectangle.DisplayShapeInfo();
            #endregion

        }
    }
}
