namespace CircleMover;

public partial class FormOptions : Form
{
    public FormOptions()
    {
        InitializeComponent();
    }

    public FormOptions(Form1 form) : this()
    {
        this.Owner = form;
        this._parentForm1 = form;
    }

    private Form1 _parentForm1;

    private void button1_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = colorDialog1.ShowDialog();
        if (dialogResult != DialogResult.OK) return;

        _parentForm1.FormForwardColor = colorDialog1.Color;

    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
        this._parentForm1.Speed = trackBar1.Value;
    }
}