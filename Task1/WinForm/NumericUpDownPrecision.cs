namespace WinForm;

public class NumericUpDownPrecision : NumericUpDown
{
    public override void UpButton()
    {
        var tempValue = Value * 10;
        if (tempValue <= Maximum)
            Value = tempValue;
    }

    public override void DownButton()
    {
        var tempValue = Value / 10;
        if (tempValue >= (decimal)Math.Pow(10, -DecimalPlaces))
            Value = tempValue;
        
    }
}