using System;

namespace UpCastingDownCasting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Form form = circle;
            
            if(form is Circle)
            {
                ((Circle)form).PrintCircle();
            }
            else
            {
                Console.WriteLine("Operação Inválida");
            }

            Console.ReadLine();
        }

        private static void DownCasting_AS()
        {
            Form form = new Form();
            Circle circle = form as Circle;

            if (circle != null) // downcasting
            {
                circle.PrintCircle();
            }
            else
            {
                Console.WriteLine("Operação inválida");
            }
        }

        private static void DownCasting()
        {
            Circle circle = new Circle();
            Form form = circle; //upcating => implicita

            Circle circleDown = (Circle)form; //Downcasting

            Console.WriteLine(circle == form);
            Console.WriteLine(circle == circleDown);

            circle.Draw();
            circleDown.Draw();
        }

        private static void UpCasting()
        {
            var circle = new Circle();
            Form form = circle;

            Console.WriteLine(form == circle);

            form.Draw();
        }
    }
}
