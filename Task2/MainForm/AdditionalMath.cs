using JetBrains.Annotations;

namespace MainForm;

[PublicAPI]
public class AdditionalMath
{
    
    
    public double RadiansToDegrees(double radian)
    {
        return radian * 180 / Math.PI;
    }

    public double DegreesToRadians(double degree)
    {
        return degree * Math.PI / 180;
    }
}
