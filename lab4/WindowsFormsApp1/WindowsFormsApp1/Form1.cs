using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public enum FigureType
        {
            Circle,
            Rhomb,
            Square
        }

        FigureType figure {get;set;}

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add(FigureType.Circle);
            comboBox1.Items.Add(FigureType.Square);
            comboBox1.Items.Add(FigureType.Rhomb);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            figure = (FigureType)comboBox1.SelectedItem;
            Figure selectedFigure;

            switch(figure)
            {
                case FigureType.Circle:
                    selectedFigure = new Circle();
                    CircleFigure(selectedFigure);
                    break;
                case FigureType.Square:
                    selectedFigure = new Square();
                    SquareFigure(selectedFigure);
                    break;
                case FigureType.Rhomb:
                    selectedFigure = new Rhomb();
                    RhombFigure(selectedFigure);
                    break;
                    
            }
        }

        private void CircleFigure(Figure selectedFigure)
        {
            try
            {
                double radius = Convert.ToDouble(circleRadius_TextBox.Text);
                selectedFigure = new Circle(30, 30, radius);

                Task task = new Task(() =>
                {
                    while (true)
                    {
                        if (selectedFigure.x >= 800)
                        {
                            break;
                        }

                        selectedFigure.MoveRight(pictureBox1);
                        Thread.Sleep(100);
                        Invoke(new MethodInvoker(delegate { pictureBox1.Refresh(); }));
                    }
                });
                task.Start();
            }

            catch(FormatException)
            {
                MessageBox.Show("Введіть значення");
            }
            catch(ObjectDisposedException) { }
        }

        private void SquareFigure(Figure selectedFigure)
        {
            try
            {
                double sideLength = Convert.ToDouble(SquareSideLength_TextBox.Text);

                selectedFigure = new Square(20, 25, (int)sideLength);

                Task task2 = new Task(() =>
                {
                    while (true)
                    {
                        if (selectedFigure.x >= 800)
                        {
                            break;
                        }

                        selectedFigure.MoveRight(pictureBox1);
                        Thread.Sleep(100);
                        Invoke(new MethodInvoker(delegate { pictureBox1.Refresh(); }));
                    }
                });
                task2.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ви не ввели значення!");
            }
            catch (ObjectDisposedException) { }
        }

        private void RhombFigure(Figure selectedFigure)
        {
            try
            {
                double horizontal = Convert.ToDouble(RhombHorizontalLength_TextBox.Text);
                double vertical = Convert.ToDouble(RhombVerticalLength_TextBox.Text);

                selectedFigure = new Rhomb(20, 25, horizontal, vertical);

                Task task3 = new Task(() =>
                {
                    while (true)
                    {
                        if (selectedFigure.x >= 800)
                        {
                            break;
                        }

                        selectedFigure.MoveRight(pictureBox1);
                        Thread.Sleep(100);
                        Invoke(new MethodInvoker(delegate { pictureBox1.Refresh(); }));
                    }
                });
                task3.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ви не ввели значення!");
            }
            catch (ObjectDisposedException) { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                circleRadius_TextBox.Visible = true;
                CircleRadius_Label.Visible = true;

                SquareSideLength_TextBox.Visible = false;
                label2.Visible = false;
                RhombHorizontalLength_TextBox.Visible = false;
                RhombVerticalLength_TextBox.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                SquareSideLength_TextBox.Visible = true;
                label2.Visible = true;

                circleRadius_TextBox.Visible = false;
                CircleRadius_Label.Visible = false;
                RhombHorizontalLength_TextBox.Visible = false;
                RhombVerticalLength_TextBox.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                RhombHorizontalLength_TextBox.Visible = true;
                RhombVerticalLength_TextBox.Visible = true;
                label3.Visible = true;
                label4.Visible = true;

                circleRadius_TextBox.Visible = false;
                CircleRadius_Label.Visible = false;
                SquareSideLength_TextBox.Visible = false;
                label2.Visible = false;
            }
        }
        private void TextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) { e.Handled = true; }
        }
    }
}
