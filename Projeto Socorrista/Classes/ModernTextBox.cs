using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernTextBox : UserControl
{
    private TextBox textBox;
    public string PlaceholderText { get; set; } = "Digite aqui...";
    public char PlaceholderChar { get; set; }
    private bool isPlaceholderActive = true;
    private bool usePasswordChar = false;
    public bool EnablePlaceholder { get; set; } = true;
    public event KeyEventHandler KeyDownCustom;

    public string TextValue
    {
        get => (textBox.Text == PlaceholderText) ? "" : textBox.Text;
        set => textBox.Text = value;
    }

    public int SelectionStart
    {
        get => textBox.SelectionStart;
        set => textBox.SelectionStart = value;
    }


    //Mostrar senha

    private void UpdatePasswordChar()
    {
        textBox.UseSystemPasswordChar = !isPlaceholderActive && usePasswordChar;
    }

    public void MostrarSenha(bool mostrar)
    {
        textBox.UseSystemPasswordChar = !mostrar && usePasswordChar;
    }

    // transforma o caracter em bolinha 
    public bool UseSystemPasswordChar
    {
        get => usePasswordChar;
        set
        {
            usePasswordChar = value;
            UpdatePasswordChar();
        }
    }

    public char PasswordChar
    {
        get { return textBox.PasswordChar; }
        set { textBox.PasswordChar = value; }
    }

    // Metodo para limitar o caracter do campo
    public int MaxLength
    {
        get => textBox.MaxLength;
        set => textBox.MaxLength = value;
    }

    public Color TextBoxBackColor
    {
        get => textBox.BackColor;
        set => textBox.BackColor = value;
    }

    private Color placeholderColor = Color.LightGray;
    private Color BorderColor = Color.White;

    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public Color PlaceholderColor
    {
        get => placeholderColor;
        set
        {
            placeholderColor = value;
            if (isPlaceholderActive)
                textBox.ForeColor = value;
        }
    }

    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public Color BorderColorB
    {
        get => BorderColor;
        set
        {
            BorderColor = value;
            this.Invalidate(); 
        }
    }


    // adicionado o evento de textchanged
    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public event EventHandler TextChanged;

    public ModernTextBox()
    { 
        this.Size = new Size(400, 40);
        this.BackColor = Color.Transparent;
        this.DoubleBuffered = true;

        textBox = new TextBox
        {
            BorderStyle = BorderStyle.None,
            ForeColor = Color.LightGray,
            BackColor = ColorTranslator.FromHtml("#009E70"),
            Font = new Font("Segoe UI", 10),
            Location = new Point(10, 10),
            Width = this.Width - 20
        };


        textBox.TextChanged += (s, e) =>
        {
            if (!isPlaceholderActive)
            {
                TextChanged?.Invoke(this, e); // Encaminha o evento corretamente
            }
        };

        textBox.GotFocus += RemovePlaceholder;
        textBox.LostFocus += SetPlaceholder;

        this.Controls.Add(textBox);

        // Propagando o evento KeyDown do TextBox interno
        textBox.KeyDown += (s, e) =>
        {
            this.OnKeyDown(e);             // dispara o evento KeyDown comum
            KeyDownCustom?.Invoke(this, e); // dispara o evento personalizado (caso você use ele)
        };
    }

    // fazendo o placeholder aparecer quando inicia o form
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        if (EnablePlaceholder)
        {
            SetPlaceholder(null, null);
        }
    }

    private void SetPlaceholder(object sender, EventArgs e)
    {
        if (!EnablePlaceholder) return;
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            isPlaceholderActive = true;
            textBox.UseSystemPasswordChar = false;
            textBox.Text = PlaceholderText;
            textBox.ForeColor = Color.LightGray;
        }
    }

    private void RemovePlaceholder(object sender, EventArgs e)
    {
        if (textBox.Text == PlaceholderText)
        {
            isPlaceholderActive = false;
            textBox.Text = "";
            textBox.ForeColor = placeholderColor;
        }
    }

    // arredodando as bordas e colocando elas com color white 
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

            using (Pen pen = new Pen(BorderColor , 1.5f))
            {
                g.DrawPath(pen, path);
            }
        }
    }
}
