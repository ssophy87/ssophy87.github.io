namespace WinForm;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        pictureBox1 = new PictureBox();
        label1 = new Label();
        numericUpDown1 = new NumericUpDownPrecision();
        label2 = new Label();
        numericUpDown2 = new NumericUpDown();
        button1 = new Button();
        label3 = new Label();
        labelResult = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(12, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(540, 71);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.Location = new Point(12, 106);
        label1.Name = "label1";
        label1.Size = new Size(175, 24);
        label1.TabIndex = 1;
        label1.Text = "Точность вычислений:";
        // 
        // numericUpDown1
        // 
        numericUpDown1.DecimalPlaces = 8;
        numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 327680 });
        numericUpDown1.InterceptArrowKeys = false;
        numericUpDown1.Location = new Point(12, 133);
        numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(175, 27);
        numericUpDown1.TabIndex = 2;
        numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 327680 });
        // 
        // label2
        // 
        label2.Location = new Point(363, 106);
        label2.Name = "label2";
        label2.Size = new Size(133, 24);
        label2.TabIndex = 3;
        label2.Text = "Аргумент X:";
        // 
        // numericUpDown2
        // 
        numericUpDown2.DecimalPlaces = 2;
        numericUpDown2.Location = new Point(363, 133);
        numericUpDown2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numericUpDown2.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new Size(175, 27);
        numericUpDown2.TabIndex = 4;
        numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 327680 });
        // 
        // button1
        // 
        button1.Location = new Point(209, 171);
        button1.Name = "button1";
        button1.Size = new Size(130, 48);
        button1.TabIndex = 5;
        button1.Text = "Вычислить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label3
        // 
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label3.Location = new Point(12, 235);
        label3.Name = "label3";
        label3.Size = new Size(141, 34);
        label3.TabIndex = 6;
        label3.Text = "Результат:";
        // 
        // labelResult
        // 
        labelResult.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
        labelResult.Location = new Point(39, 283);
        labelResult.Name = "labelResult";
        labelResult.Size = new Size(481, 149);
        labelResult.TabIndex = 7;
        labelResult.Text = "label4";
        labelResult.Visible = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(564, 455);
        Controls.Add(labelResult);
        Controls.Add(label3);
        Controls.Add(button1);
        Controls.Add(numericUpDown2);
        Controls.Add(label2);
        Controls.Add(numericUpDown1);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        Name = "Form1";
        Text = "Вычисление ln X";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label labelResult;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.NumericUpDown numericUpDown2;

    private System.Windows.Forms.Label label1;
    private NumericUpDownPrecision numericUpDown1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}