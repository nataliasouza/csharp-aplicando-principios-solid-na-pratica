namespace AbstractClass
{
    public abstract class Form
    {
        public string Color { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();

        public string Description()
        {
            return "Classe abstrata Forma! 'Classe base'.";
        }
    }
}
