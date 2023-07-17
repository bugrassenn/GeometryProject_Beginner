using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            double edge, squarearea, squareperimeter;

            // Square Area and Perimeter 
            edge = Convert.ToDouble(TxtEdge.Text);
            squarearea = edge * edge;
            squareperimeter = edge * 4; 
            LblSquareArea.Text = squarearea.ToString("0.00");
            LblSquarePerimeter.Text = squareperimeter.ToString("0.00");

        }

        private void BtnCircle_Click(object sender, EventArgs e)
        {
            double radius, circlearea, circleperimeter;

            // Circle Area and Perimeter  π = 3
            radius = Convert.ToDouble(TxtRadius.Text);
            circlearea = radius * radius * 3;
            circleperimeter = radius * 2 * 3;
            LblCircleArea.Text = circlearea.ToString("0.00");
            LblCirclePerimeter.Text = circleperimeter.ToString("0.00");
        }
    }
}
