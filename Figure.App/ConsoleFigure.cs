using System.Globalization;

namespace Figure.App;

public static class ConsoleFigure
{
    public static void ShowSquare(Figure figure)
    {
        CLI.ShowInfo(figure.GetSquare().ToString(CultureInfo.InvariantCulture));
    }

    public static void ShowPerimeter(Figure figure)
    {
        CLI.ShowInfo(figure.GetPerimeter().ToString(CultureInfo.InvariantCulture));
    }

    private static double ValidInput(string message)
    {
        double value;
        bool isConvertToDouble;
        do
        {
            var input = CLI.Input(message);
            isConvertToDouble = double.TryParse(input, out value);
        } while ((!isConvertToDouble) || value <= 0); //TODO Обратить внимание на логическое выражение

        return value;
    }

    private static void InputCircle(Circle circle)
    {
        
        circle.Radius = ValidInput("Введите радиус круга: ");
    }

    private static void InputRectangle(Rectangle rectangle)
    {
        rectangle.SideA = ValidInput("Введите первую сторону: ");
        rectangle.SideB = ValidInput("Введите вторую сторону: ");
    }

    public static void InputFigure(Figure figure)
    {
        /*Type type = figure.GetType();
        if (type == typeof(Circle))
        {
            InputCircle(figure as Circle);
            return;
        }

        if (type == typeof(Rectangle))
        {
            InputRectangle(figure as Rectangle);
            return;
        }*/

        /*if (figure is Circle circle)
        {
            InputCircle(circle);
            return;
        }

        if (figure is Rectangle rectangle)
        {
            InputRectangle(rectangle);
            return;
        }*/
        
        switch (figure)
        {
            case Circle circle:
                InputCircle(circle);
                break;
            case Rectangle rectangle:
                InputRectangle(rectangle);
                break;
        }
    }
}