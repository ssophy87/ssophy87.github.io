using System.Data;
using System.Text;

namespace MainForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        dataGridView1.ColumnCount = 3;
        dataGridView1.Columns[0].Name = "A";
        dataGridView1.Columns[1].Name = "B";
        dataGridView1.Columns[2].Name = "C";
    }

    private void GenerateTriangles()
    {
        dataGridView1.Rows.Clear();
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            int a; int b; int c;
            Triangle tr;
            do
            {
                a = random.Next(1, 150);
                b = random.Next(1, 150);
                c = random.Next(1, 150);
                tr = new Triangle(a, b, c);
            } while (!tr.ValidateTriangle());

            dataGridView1.Rows.Add(a, b, c);
        }

        button2.Enabled = true;
    }



    private void GetAndWriteResults()
    {
        DialogResult dialogResult = saveFileDialog1.ShowDialog();
        if (dialogResult != DialogResult.OK)
            return;

        int count = 1;
        File.Delete(saveFileDialog1.FileName);
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            if (row.IsNewRow) continue;
            int a = Convert.ToInt32(row.Cells[0].Value);
            int b = Convert.ToInt32(row.Cells[1].Value);
            int c = Convert.ToInt32(row.Cells[2].Value);
            var tria = new Triangle(a, b, c);
            var area = tria.GetTriangleArea();
            var angles = tria.GetTriangleAngles();
            var heights = tria.GetTriangleHeights();
            string resultString = $"Треугольник {count}:\n" +
                                  $"Стороны: {a}, {b}, {c}:\n" +
                                  $"Площадь: {area}\n" +
                                  $"Углы: 1 - {Math.Round(angles[0], 4)}, 2 - {Math.Round(angles[1], 4)}, 3 - {Math.Round(angles[2], 4)}\n" +
                                  $"Высоты: 1 - {Math.Round(heights[0], 4)}, 2 - {Math.Round(heights[1], 4)}, 3 - {Math.Round(heights[2], 4)}\n\n";

            File.AppendAllText(saveFileDialog1.FileName, resultString);
            count++;
        }

    }

    private void button2_Click(object sender, EventArgs e)
    {
        GetAndWriteResults();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        GenerateTriangles();
    }

    private void dataGridView1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            if (row.IsNewRow) continue;
            int a = Convert.ToInt32(row.Cells[0].Value);
            int b = Convert.ToInt32(row.Cells[1].Value);
            int c = Convert.ToInt32(row.Cells[2].Value);
            if (!(new Triangle(a, b, c)).ValidateTriangle())
            {
                MessageBox.Show($"Треугольник со сторонами {a}, {b}, {c} невозможен. ", "ОШИБКА", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}