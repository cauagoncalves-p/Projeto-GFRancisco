using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernTextBox : UserControl
{
    private TextBox textBox;

    public string PlaceholderText { get; set; } = "Digite aqui...";
    public string TextValue
    {
        get => (textBox.Text == PlaceholderText) ? "" : textBox.Text;
        set => textBox.Text = value;
    }

    public ModernTextBox()
    {
        this.Size = new Size(250, 40);
        this.BackColor = Color.Transparent;
        this.DoubleBuffered = true;

        textBox = new TextBox
        {
            BorderStyle = BorderStyle.None,
            ForeColor = Color.White,
            BackColor = ColorTranslator.FromHtml("#009E70"),
            Font = new Font("Segoe UI", 10),
            Location = new Point(10, 10),
            Width = this.Width - 20
        };

        textBox.GotFocus += RemovePlaceholder;
        textBox.LostFocus += SetPlaceholder;

        this.Controls.Add(textBox);
        SetPlaceholder(null, null);
    }

    private void SetPlaceholder(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            textBox.Text = PlaceholderText;
            textBox.ForeColor = Color.LightGray;
        }
    }

    private void RemovePlaceholder(object sender, EventArgs e)
    {
        if (textBox.Text == PlaceholderText)
        {
            textBox.Text = "";
            textBox.ForeColor = Color.White;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        int radius = 10;
        Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            using (Pen pen = new Pen(Color.White, 1.5f))
            {
                g.DrawPath(pen, path);
            }
        }
    }
}
