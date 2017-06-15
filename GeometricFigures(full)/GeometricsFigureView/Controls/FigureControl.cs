using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricFigures;

namespace GeometricsFigureView.Controls
{
    public partial class FigureControl : UserControl
    {
        public FigureControl()
        {
            InitializeComponent();
            FigureComboBox1.Items.Add("Прямоугольник");
            FigureComboBox1.Items.Add("Треугольник");
            FigureComboBox1.Items.Add("Кольцо");
            FigureComboBox1.Items.Add("Окружность");

            rectangleControl1.Visible = false;
            triangleControl1.Visible = false;
            ringControl1.Visible = false;
            circleControl1.Visible = false;
        }
        public IFigures Figure
        {
            get
            {
                IFigures figure = null;
                int ss = FigureComboBox1.SelectedIndex;
                switch (ss)
                {
                    case 0:
                        {
                            try
                            {
                                figure = rectangleControl1.Rectangle;
                            }
                            catch (FormatException exception)
                            {
                                throw exception;
                            }
                            break;
                        }
                    case 1:
                        {
                            try
                            {
                                figure = triangleControl1.Triangle;
                            }
                            catch (FormatException exception)
                            {
                                throw exception;
                            }
                            break;
                        }
                    case 2:
                        {
                            try
                            {
                                figure = ringControl1.Ring;
                            }
                            catch (FormatException exception)
                            {
                                throw exception;
                            }
                            break;
                        }
                    case 3:
                        {
                            try
                            {
                                figure = circleControl1.Circle;
                            }
                            catch (FormatException exception)
                            {
                                throw exception;
                            }
                            break;
                        }
                }
                return figure;
            }
            set
            {
                if (value is GeometricFigures.Rectangle)
                {
                    FigureComboBox1.SelectedIndex = 0;
                    try
                    {
                        rectangleControl1.Rectangle = (GeometricFigures.Rectangle)value;
                    }
                    catch (FormatException exception)
                    {
                        throw exception;
                    }
                }
                else if (value is Triangle)
                {
                    FigureComboBox1.SelectedIndex = 1;
                    try
                    {
                        triangleControl1.Triangle = (Triangle)value;
                    }
                    catch (FormatException exception)
                    {
                        throw exception;
                    }
                }
                else if (value is Ring)
                {
                    FigureComboBox1.SelectedIndex = 2;
                    try
                    {
                        ringControl1.Ring = (Ring)value;
                    }
                    catch (FormatException exception)
                    {
                        throw exception;
                    }
                }
                else if (value is Circle)
                {
                    FigureComboBox1.SelectedIndex = 3;
                    try
                    {
                        circleControl1.Circle = (Circle)value;
                    }
                    catch (FormatException exception)
                    {
                        throw exception;
                    }
                }
            }
        }
        private void figurecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rectangleControl1.Visible = (FigureComboBox1.SelectedIndex == 0);
            triangleControl1.Visible = (FigureComboBox1.SelectedIndex == 1);
            ringControl1.Visible = (FigureComboBox1.SelectedIndex == 2);
            circleControl1.Visible = (FigureComboBox1.SelectedIndex == 3);
        }
    }
}
