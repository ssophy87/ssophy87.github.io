using System.Text;

namespace WinForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    
    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            var argument = (double)numericUpDown2.Value;
            
            if (argument < 0 || argument == 1)
                throw new ArgumentOutOfRangeException("Несоответствие ОДЗ: X меньше 0 или равен 1.");
            
            var precision = (double)numericUpDown1.Value;
            
            var valueFirst = CalculateFunction(argument);
            var valueSecond = CalculateSum(argument, precision);
            int amountOfRows;
            var valueThird = CalculateRow(argument, precision, out amountOfRows);

            SendResult($"Результат ln x: {valueFirst}", $"Результат Суммы: {valueSecond}",
                $"Кол-во членов ряда: {amountOfRows}");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка:\n" + ex.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private double CalculateFunction(double argument)
    {
        return Math.Log(argument);
    }

    private double CalculateSum(double argument, double precision)
    {
        double? lastResult = null;
        double? currentResult = 0;
        for (int i = 0; lastResult == null || Math.Abs(lastResult.Value - currentResult.Value) > precision; i++)
        {
            lastResult = currentResult;
            var powValue = 2 * i + 1;
            currentResult += Math.Pow((argument - 1), powValue)/(powValue * Math.Pow((argument + 1),powValue));
        };
        if (currentResult != null) 
            return 2 * currentResult.Value;
        else throw  new Exception("Ошибка при currentResult");
    }

    private double CalculateRow(double argument, double precision, out int numberOfCalcRows)
    {
        double? lastResult = null;
        double? currentResult = (argument - 1) / (argument+1);
        for (numberOfCalcRows = 1; lastResult == null || Math.Abs(lastResult.Value - currentResult.Value) > precision; numberOfCalcRows++)
        {
            lastResult = currentResult;
            var powNum = 2 * numberOfCalcRows + 1;
            currentResult += Math.Pow((argument - 1),powNum)/(powNum * Math.Pow((argument + 1),powNum));
        };
        if (currentResult != null) 
            return 2 * currentResult.Value;
        else throw  new Exception("Ошибка при currentResult");
    }

    private void SendResult(params string[] strs)
    {
        StringBuilder sb = new StringBuilder();
        foreach (string str in strs)
        {
            sb.AppendLine(str);
        }
        labelResult.Text =  sb.ToString();
        labelResult.Visible = true;
    }
    
}