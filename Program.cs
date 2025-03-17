namespace ICE_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name shape? \n (1) Rectangle/Square \n (2) Circle");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string name = "Rectangle";
                    Console.WriteLine("Enter the length(mm) of the shape: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the width(mm) of the shape: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(name, length, width);
                    Console.WriteLine();
                    rectangle.Display();
                    break;
                case "2":
                    string name2 = "Circle";
                    Console.WriteLine("Enter the radius(mm) of the shape: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(name2, radius);
                    Console.WriteLine();
                    circle.Display();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                   
                    
                    break;
            }
           
        }
        
    }
}
