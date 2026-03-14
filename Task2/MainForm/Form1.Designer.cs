namespace MainForm;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        labelHeader = new Label();
        button1 = new Button();
        dataGridView1 = new DataGridView();
        button2 = new Button();
        saveFileDialog1 = new SaveFileDialog();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // labelHeader
        // 
        labelHeader.Font = new Font("Roboto Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        labelHeader.Location = new Point(44, 38);
        labelHeader.Name = "labelHeader";
        labelHeader.Size = new Size(324, 36);
        labelHeader.TabIndex = 0;
        labelHeader.Text = "Вычисления треугольника";
        // 
        // button1
        // 
        button1.Font = new Font("Roboto", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        button1.Location = new Point(12, 127);
        button1.Name = "button1";
        button1.Size = new Size(282, 54);
        button1.TabIndex = 1;
        button1.Text = "Сгенерировать треугольники";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(320, 96);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(179, 291);
        dataGridView1.TabIndex = 2;
        dataGridView1.Text = "dataGridView1";
        dataGridView1.Validating += dataGridView1_Validating;
        // 
        // button2
        // 
        button2.Enabled = false;
        button2.Font = new Font("Roboto", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        button2.Location = new Point(12, 254);
        button2.Name = "button2";
        button2.Size = new Size(282, 68);
        button2.TabIndex = 3;
        button2.Text = "Получить и записать результаты";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(511, 399);
        Controls.Add(button2);
        Controls.Add(dataGridView1);
        Controls.Add(button1);
        Controls.Add(labelHeader);
        Name = "Form1";
        Text = "Вычисления треугольника";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label labelHeader;

    #endregion

    private Button button2;
    private SaveFileDialog saveFileDialog1;
}