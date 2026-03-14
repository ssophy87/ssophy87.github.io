using System.ComponentModel;

namespace CircleMover;

partial class FormOptions
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        colorDialog1 = new System.Windows.Forms.ColorDialog();
        button1 = new System.Windows.Forms.Button();
        trackBar1 = new System.Windows.Forms.TrackBar();
        label1 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        button1.Location = new System.Drawing.Point(80, 212);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(325, 88);
        button1.TabIndex = 0;
        button1.Text = "Выбрать цвет";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // trackBar1
        // 
        trackBar1.LargeChange = 30;
        trackBar1.Location = new System.Drawing.Point(80, 103);
        trackBar1.Maximum = 30;
        trackBar1.Minimum = 2;
        trackBar1.Name = "trackBar1";
        trackBar1.Size = new System.Drawing.Size(325, 56);
        trackBar1.SmallChange = 15;
        trackBar1.TabIndex = 1;
        trackBar1.Value = 10;
        trackBar1.Scroll += trackBar1_Scroll;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(94, 42);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(231, 43);
        label1.TabIndex = 2;
        label1.Text = "Скорость движения";
        // 
        // FormOptions
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(482, 348);
        Controls.Add(label1);
        Controls.Add(trackBar1);
        Controls.Add(button1);
        Text = "Настройки";
        ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Button button1;

    #endregion
}