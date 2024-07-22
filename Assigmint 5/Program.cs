using Assigmint_5.First_project;
using Assigmint_5.Second_project;
using Assigmint_5.third_project;

namespace Assigmint_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First project
            /*   Point3D p1, p2;
               try
               {
                   Console.Write("Enter x, y, z for p1: ");
                   string[] coords = Console.ReadLine().Split(' ');
                   p1 = new Point3D(int.Parse(coords[0]), int.Parse(coords[1]), int.Parse(coords[2]));
                   Console.Write("Enter x, y, z for p2: ");
                   coords = Console.ReadLine().Split(' ');
                   p2 = new Point3D(int.Parse(coords[0]), int.Parse(coords[1]), int.Parse(coords[2]));
               }
               catch (Exception ex)
               {
                   Console.WriteLine("Invalid input: " + ex.Message);
                   return;
               }

               Console.WriteLine(p1.ToString());
               Console.WriteLine(p2.ToString());

               if (p1 == p2)
                   Console.WriteLine("p1 and p2 are equal");
               else
                   Console.WriteLine("p1 and p2 are not equal");

               Point3D[] points = new Point3D[] { p1, p2, new Point3D(5, 5, 5), new Point3D(1, 1, 1) };
               Array.Sort(points);

               foreach (Point3D p in points)
                   Console.WriteLine(p.ToString());*/
            #endregion


            #region SEcond project
            /* int x = 10, y = 5;

             Console.WriteLine("Add: " + Maths.Add(x, y));
             Console.WriteLine("Subtract: " + Maths.Subtract(x, y));
             Console.WriteLine("Multiply: " + Maths.Multiply(x, y));
             Console.WriteLine("Divide: " + Maths.Divide(x, y));*/

            #endregion


            #region third project

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2);

            Duration D3 = new Duration(666);
            Console.WriteLine(D3);

            D3 = D1 + D2;
            Console.WriteLine("D1 + D2 = " + D3);

            D3 = D1 + 7800;
            Console.WriteLine("D1 + 7800 = " + D3);

            D3++;
            Console.WriteLine("++D1 = " + D3);

            D2--;
            Console.WriteLine("--D2 = " + D2);

            D1 = D1 - D2;
            Console.WriteLine("D1 - D2 = " + D1);
            #endregion


        }
    }
}
