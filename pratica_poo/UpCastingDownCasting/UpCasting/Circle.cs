using System;

namespace UpCastingDownCasting
{
    public class Circle : Form
    {
        public override void Draw()
        {
            Console.WriteLine("Desenhar Circulo");
        }
        public void PrintCircle()
        {
            Console.WriteLine("Desenhando o círculo");
        }
    }
}
