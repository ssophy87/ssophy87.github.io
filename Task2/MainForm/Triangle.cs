using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace MainForm;


[SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
public class Triangle
{
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set; }
    
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public Triangle()
    {
        A = 1;
        B = 1;
        C = 1;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Triangle triangle)
            return A == triangle.A && B == triangle.B && C == triangle.C;
        else return false;
    }

    protected bool Equals(Triangle other)
    {
        return A == other.A && B == other.B && C == other.C;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(A, B, C);
    }


    /// <summary>
    /// Проверка возможности существования треугольника
    /// </summary>
    /// <returns>True - если треугольник возможен, иначе False</returns>
    public bool ValidateTriangle()
    {
        if (this.A >= this.B + this.C)
            return false;

        if (this.B >= this.A + this.C)
            return false;

        if (this.C >= this.A + this.B)
            return false;

        return true;
    }

    /// <summary>
    /// Вычисление площади треугольника через три стороны
    /// </summary>
    /// <returns>Площадь треугольника</returns>
    public double GetTriangleArea()
    {
        if (!this.ValidateTriangle())
            throw new ArgumentException($"Треугольник невозможен. ");

        var halfPerimeter = (this.A + this.B + this.C) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - this.A) * (halfPerimeter - this.B) * (halfPerimeter - this.C));

    }


    /// <summary>
    /// Вычисляет углы треугольника по его сторонам
    /// </summary>
    /// <returns>Массив размером 3, содержащий все углы треугольника</returns>
    public double[] GetTriangleAngles()
    {
        if (!this.ValidateTriangle())
            throw new ArgumentException($"Треугольник невозможен. ");

        var firstAngle = Math.Acos((Math.Pow(this.A, 2) + Math.Pow(this.C, 2) - Math.Pow(this.B, 2))
                                   / (2 * this.A * this.C));
        var secondAngle = Math.Acos((Math.Pow(this.A, 2) + Math.Pow(this.B, 2) - Math.Pow(this.C, 2))
                                   / (2 * this.A * this.B));

        var thirdAngle = Math.Acos((Math.Pow(this.B, 2) + Math.Pow(this.C, 2) - Math.Pow(this.A, 2))
                                    / (2 * this.C * this.B));
        return [firstAngle, secondAngle, thirdAngle];
    }

    /// <summary>
    /// Вычисляет высоты треугольника по его сторонам
    /// </summary>
    /// <returns>Массив размером 3, содержащий высоты треугольника</returns>
    public double[] GetTriangleHeights()
    {
        var trArea = this.GetTriangleArea(); // Не будем проверять на Validatethis, так как тут уже есть проверка
        var firstHeight = 2 * trArea / this.A;
        var secondHeight = 2 * trArea / this.B;
        var thirdHeight = 2 * trArea / this.C;

        return [firstHeight, secondHeight, thirdHeight];
    }
}