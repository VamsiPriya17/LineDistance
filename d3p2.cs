using System;
namespace lines{
    class coordinates{
        public double x1, y1, x2, y2, length;
    }
    class lineLength : coordinates{
      static double uc1(double x1, double x2, double y1, double y2){
          double length = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2));
          return length;
      }
      static void uc2(ref coordinates line1, ref coordinates line2){
          Console.WriteLine("Length of line 1 is: " + line1.length);
          line2.length = uc1(line2.x1, line2.x2, line2.y1, line2.y2);
          Console.WriteLine("Length of line 2 is: " + line2.length);
          
          if(line1.length == line2.length){
            Console.WriteLine("Both lines are equal");
          }
          else if(line1.length > line2.length){
              Console.WriteLine("Line 1 is greater than Line 2.");
          }
          else{
            Console.WriteLine("Line 2 is greater than Line 1.");
          }
      }
      static void input(ref coordinates obj){
        Console.WriteLine("Enter x1 :");
        obj.x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter y1 :");
        obj.y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter x2 :");
        obj.x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter y2 :");
        obj.y2 = Convert.ToInt32(Console.ReadLine());
      }
      static void Main() {
        coordinates line1 = new coordinates();
        coordinates line2 = new coordinates();
        
        Console.WriteLine("Line 1 Coordinates :");
        input(ref line1);
        Console.WriteLine("Line 2 Coordinates :");
        input(ref line2);
        
        line1.length = uc1(line1.x1, line1.x2, line1.y1, line1.y2);
        uc2(ref line1, ref line2);
      }
    }
}
