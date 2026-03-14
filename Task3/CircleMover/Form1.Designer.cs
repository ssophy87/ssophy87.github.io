namespace CircleMover;

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
        components = new System.ComponentModel.Container();
        panel1 = new System.Windows.Forms.Panel();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        timerCircle = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Location = new System.Drawing.Point(28, 12);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(478, 317);
        panel1.TabIndex = 0;
        panel1.Paint += panel1_Paint;
        // 
        // button1
        // 
        button1.Font = new System.Drawing.Font("Roboto SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        button1.ForeColor = System.Drawing.Color.DarkBlue;
        button1.Location = new System.Drawing.Point(108, 359);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(125, 69);
        button1.TabIndex = 1;
        button1.Text = "Старт";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Font = new System.Drawing.Font("Roboto SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        button2.ForeColor = System.Drawing.Color.DarkRed;
        button2.Location = new System.Drawing.Point(307, 359);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(125, 69);
        button2.TabIndex = 2;
        button2.Text = "Настройки";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // timerCircle
        // 
        timerCircle.Interval = 10;
        timerCircle.Tick += timerCircle_Tick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(548, 450);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(panel1);
        Text = "Движение круга";
        Load += Form1_Load;
        Paint += Form1_Paint;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Timer timerCircle;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;

    #endregion
}