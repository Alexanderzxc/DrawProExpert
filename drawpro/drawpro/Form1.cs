namespace drawpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            TriangleClass triangleClass = new TriangleClass();
            int widthoffigure = triangleClass.FigureWidth(Convert.ToInt32(textBoxWidth.Text));
            Color color = colorDialog1.Color;
            labelOnPanel.Text = "Фигура: Треугольник\nШирина: " + Convert.ToString(widthoffigure) + "\nЦвет: ";
            panel3color.BackColor = color;
        }

        private void panel2Color_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                panel2Color.BackColor = color;
            }
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            SquareClass squareClass = new SquareClass();
            int widthoffigure = squareClass.FigureWidth(Convert.ToInt32(textBoxWidth.Text));
            Color color = colorDialog1.Color;
            labelOnPanel.Text = "Фигура: Квадрат\nШирина: " + Convert.ToString(widthoffigure) + "\nЦвет: ";
            panel3color.BackColor = color;
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            CircleClass circleClass = new CircleClass();
            int widthoffigure = circleClass.FigureWidth(Convert.ToInt32(textBoxWidth.Text));
            Color color = colorDialog1.Color;
            labelOnPanel.Text = "Фигура: Круг\nШирина: " + Convert.ToString(widthoffigure) + "\nЦвет: ";
            panel3color.BackColor = color;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            LineClass lineClass = new LineClass();
            int widthoffigure = lineClass.FigureWidth(Convert.ToInt32(textBoxWidth.Text));
            Color color = colorDialog1.Color;
            labelOnPanel.Text = "Фигура: Линия\nШирина: " + Convert.ToString(widthoffigure) + "\nЦвет: ";
            panel3color.BackColor = color;
        }
    }
}