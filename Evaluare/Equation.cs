using System;
using System.Drawing;
using System.Windows.Forms;

namespace Evaluare
{
    public partial class Equation : Form
    {
        private int _delta;
        private double _x1, _x2;
        
        public Equation()
        {
            InitializeComponent();
        }


        private void textBox_A_TextChanged(object sender, EventArgs e)
        {
            calcDelta();
        }
        
        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            calcDelta();
        }

        private void textBox_C_TextChanged(object sender, EventArgs e)
        {
            calcDelta();
        }


        private void calcDelta()
        {
            int a, b, c;
            bool aIsNumber = int.TryParse(textBox_A.Text, out a);
            bool bIsNumber = int.TryParse(textBox_B.Text, out b);
            bool cIsNumber = int.TryParse(textBox_C.Text, out c);
            
            if (aIsNumber && bIsNumber && cIsNumber && a != 0)
            {
                _delta = b * b - 4 * a * c;
                _x1 = (-1 * b - (double.IsNaN(Math.Sqrt(_delta)) ? 0 : Math.Sqrt(_delta))) / (2 * a);
                _x2 = (-1 * b + (double.IsNaN(Math.Sqrt(_delta)) ? 0 : Math.Sqrt(_delta))) / (2 * a);

                delta.Text = _delta.ToString();
                x1.Text = _x1.ToString("0.##");
                x2.Text = _x2.ToString("0.##");

                resizeTextBoxes();
            } 
        }

        private void resizeTextBoxes()
        {
            Size size_delta = TextRenderer.MeasureText(delta.Text, delta.Font);
            Size size_x1 = TextRenderer.MeasureText(x1.Text, x1.Font);
            Size size_x2 = TextRenderer.MeasureText(x2.Text, x2.Font);

            delta.Size = size_delta;
            x1.Size = size_x1;
            x2.Size = size_x2;

        }
    }
}