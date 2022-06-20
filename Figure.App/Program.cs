namespace Figure.App
{
    internal class Program
    {
        static void Main()
        {
            CLI.ShowInfo("Типы фигур:");
            CLI.ShowInfo("1. Круг");
            CLI.ShowInfo("2. Прямоугольник");
            var select = CLI.Input("Введите тип фигуры, для которой хотите рассчитать площадь и переиметр - ");

            Figure? figure = select switch
            {
                "1" => new Circle(),
                "2" => new Rectangle(),
                _ => null
            };

            if (figure is not null)
            {
                ConsoleFigure.InputFigure(figure);
                ConsoleFigure.ShowPerimeter(figure);
                ConsoleFigure.ShowSquare(figure);
            }
        }
    }
}