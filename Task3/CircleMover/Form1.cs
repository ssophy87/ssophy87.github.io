using System.ComponentModel;
using System.Reflection;

namespace CircleMover;

public partial class Form1 : Form
{
    private static Point _startingPoint;
    private static readonly Size BoundingDefaultSize = new(70, 70);
    private static Rectangle _boundingBox;

    private MoveStatus _moveStatus = MoveStatus.Forwards;

    private float _speed;
    private readonly SolidBrush _brush = new(new Color());
    private SizeF _currentBoundingSize = BoundingDefaultSize;

    private readonly float _sizeModifier = 0.75f;

    public Form1()
    {
        InitializeComponent();
    }

    [DefaultValue(0)]
    public Color FormForwardColor
    {
        get => _brush.Color;
        set => _brush.Color = value;
    }

    [DefaultValue(1)]
    public float Speed
    {
        get => _speed;
        set => _speed = value > 0 ? value : 0;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
            ?.SetValue(panel1, true);
        button1.Tag = false;

        _startingPoint = new Point(panel1.Width / 2 - BoundingDefaultSize.Width / 2,
            panel1.Height - BoundingDefaultSize.Height);
        _boundingBox = new Rectangle(_startingPoint.X, _startingPoint.Y, BoundingDefaultSize.Width,
            BoundingDefaultSize.Height);

        Speed = 1;
        FormForwardColor = Color.FromArgb(255, 255, 0);
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.DrawRectangle(new Pen(Color.Black, 3), new Rectangle(panel1.Location, panel1.Size));
    }


    public void Stop()
    {
        button1.Text = "СТАРТ";
        button1.ForeColor = Color.DarkBlue;
        button1.Tag = false;

        timerCircle.Stop();
    }

    public void Start()
    {
        button1.Text = "СТОП";
        button1.ForeColor = Color.FromArgb(198, 15, 22);
        button1.Tag = true;

        timerCircle.Start();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (button1.Tag == null || (bool?)button1.Tag == false)
            Start();
        else
            Stop();
    }

    private void timerCircle_Tick(object sender, EventArgs e)
    {
        var newPoint = new Point(panel1.Width/2 - _boundingBox.Width/2,
            (int)Math.Round(_boundingBox.Y - Speed * (int)_moveStatus));

        _currentBoundingSize = new SizeF((int)Math.Round(_boundingBox.Width + _sizeModifier * (int)_moveStatus),
            _boundingBox.Height);
        _boundingBox = new Rectangle(newPoint,
            new Size((int)_currentBoundingSize.Width, (int)_currentBoundingSize.Height));

        if (newPoint.Y < 0) _moveStatus = MoveStatus.Backwards;

        if ((newPoint.Y + _boundingBox.Height) >= panel1.Height ) _moveStatus = MoveStatus.Forwards;

        panel1.Invalidate();
    }


    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.FillEllipse(_brush, _boundingBox);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        using var settingsForm = new FormOptions(this);
        settingsForm.ShowDialog();
    }

    private enum MoveStatus
    {
        Forwards = 1,
        Backwards = -1
    }
}