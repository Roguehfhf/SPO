using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricFigures;

namespace GeometricsFigureView
{
    public partial class AddFigureForm : Form
    {
        private IFigures _figure;

        public IFigures Figure
        {
            get
            {

                if (FigureComboBox1.SelectedIndex == 0)
                {
                    var rectangle = new GeometricFigures.Rectangle
                    {
                        Height = Convert.ToDouble(SideATextBox.Text),
                        Width = Convert.ToDouble(SideBTextBox.Text)
                    };
                    _figure = rectangle;
                }
                else if (FigureComboBox1.SelectedIndex == 1)
                {
                    var triangle = new Triangle();
                    triangle.SetSides(Convert.ToDouble(SideATextBox.Text),
                        Convert.ToDouble(SideBTextBox.Text),
                        Convert.ToDouble(SideCTextBox.Text));
                    _figure = triangle;
                }
                else if (FigureComboBox1.SelectedIndex == 2)
                {
                    var circle = new Circle()
                    {
                        Radius = Convert.ToDouble(RadiusTextBox.Text)
                    };
                    _figure = circle;
                }
                else if (FigureComboBox1.SelectedIndex == 3)
                {
                    var ring = new Ring();
                    {
                        ring.SetRadius(Convert.ToDouble(OutsideRadiusTextBox.Text),
                            Convert.ToDouble(InnerRadiusTextBox.Text));
                    }
                    _figure = ring;
                }
                return _figure;
            }

            set
            {
                if (value is GeometricFigures.Rectangle)
                {
                    var rec = (GeometricFigures.Rectangle) value;
                    FigureComboBox1.SelectedIndex = 0;
                    FigureComboBox1.Enabled = false;
                    SideATextBox.Text = rec.Height.ToString(CultureInfo.InvariantCulture);
                    SideBTextBox.Text = rec.Width.ToString(CultureInfo.InvariantCulture);
                }

                else if (value is Triangle)
                {
                    var rec = (Triangle) value;
                    FigureComboBox1.SelectedIndex = 1;
                    FigureComboBox1.Enabled = false;
                    SideATextBox.Text = rec.SideA.ToString(CultureInfo.InvariantCulture);
                    SideBTextBox.Text = rec.SideB.ToString(CultureInfo.InvariantCulture);
                    SideCTextBox.Text = rec.SideC.ToString(CultureInfo.InvariantCulture);
                }

                else if (value is Circle)
                {
                    var cir = (Circle) value;
                    FigureComboBox1.SelectedIndex = 2;
                    FigureComboBox1.Enabled = false;
                    RadiusTextBox.Text = cir.Radius.ToString(CultureInfo.InvariantCulture);
                }

                else if (value is Ring)
                {
                    var rin = (Ring) value;
                    FigureComboBox1.SelectedIndex = 3;
                    FigureComboBox1.Enabled = false;
                    OutsideRadiusTextBox.Text = rin.OutsideRadius.ToString(CultureInfo.InvariantCulture);
                    InnerRadiusTextBox.Text = rin.InnerRadius.ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        public AddFigureForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FigureComboBox1.SelectedIndex == 0)
            {
                SideATextBox.Visible = true;
                SideBTextBox.Visible = true;
                SideCTextBox.Visible = false;
                RadiusTextBox.Visible = false;
                OutsideRadiusTextBox.Visible = false;
                InnerRadiusTextBox.Visible = false;
                SideALabel.Visible = true;
                SideBLabel.Visible = true;
                SideCLabel.Visible = false;
                RadiusLabel.Visible = false;
                OutsideRadiusLabel.Visible = false;
                InnerRadiusLabel.Visible = false;
            }

            else if (FigureComboBox1.SelectedIndex == 1)
            {
                SideATextBox.Visible = true;
                SideBTextBox.Visible = true;
                SideCTextBox.Visible = true;
                RadiusTextBox.Visible = false;
                OutsideRadiusTextBox.Visible = false;
                InnerRadiusTextBox.Visible = false;
                SideALabel.Visible = true;
                SideBLabel.Visible = true;
                SideCLabel.Visible = true;
                RadiusLabel.Visible = false;
                OutsideRadiusLabel.Visible = false;
                InnerRadiusLabel.Visible = false;
            }

            else if (FigureComboBox1.SelectedIndex == 2)
            {
                SideATextBox.Visible = false;
                SideBTextBox.Visible = false;
                SideCTextBox.Visible = false;
                RadiusTextBox.Visible = true;
                OutsideRadiusTextBox.Visible = false;
                InnerRadiusTextBox.Visible = false;
                SideALabel.Visible = false;
                SideBLabel.Visible = false;
                SideCLabel.Visible = false;
                RadiusLabel.Visible = true;
                OutsideRadiusLabel.Visible = false;
                InnerRadiusLabel.Visible = false;
            }

            else if (FigureComboBox1.SelectedIndex == 3)
            {
                SideATextBox.Visible = false;
                SideBTextBox.Visible = false;
                SideCTextBox.Visible = false;
                RadiusTextBox.Visible = false;
                OutsideRadiusTextBox.Visible = true;
                InnerRadiusTextBox.Visible = true;
                SideALabel.Visible = false;
                SideBLabel.Visible = false;
                SideCLabel.Visible = false;
                RadiusLabel.Visible = false;
                OutsideRadiusLabel.Visible = true;
                InnerRadiusLabel.Visible = true;
            }
        }



        private void CanselButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (FigureComboBox1.SelectedIndex == 0)
            {
                if (SideATextBox.TextLength == 0 || SideBTextBox.TextLength == 0)
                {
                    MessageBox.Show(@"Вы ввели не все стороны прямоугольника.", @"Ошибка!");
                    return;
                }
            }

            else if (FigureComboBox1.SelectedIndex == 1)
            {
                if (SideATextBox.TextLength == 0 || SideBTextBox.TextLength == 0 || SideCTextBox.TextLength == 0)
                {
                    MessageBox.Show(@"Вы ввели не все стороны треугольника.", @"Ошибка!");
                    return;
                }
            }

            else if (FigureComboBox1.SelectedIndex == 2)
            {
                if (RadiusTextBox.TextLength == 0)
                {
                    MessageBox.Show(@"Вы не ввели радиус круга.", @"Ошибка!");
                    return;
                }
            }

            else if (FigureComboBox1.SelectedIndex == 3)
            {
                if (OutsideRadiusTextBox.TextLength == 0 || InnerRadiusTextBox.TextLength == 0)
                {
                    MessageBox.Show(@"Вы не ввели внешний или внутренний радиус кольца.", @"Ошибка!");
                    return;
                }
            }
            else if (FigureComboBox1.SelectedIndex == -1)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void SideCTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SideATextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void SideCTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void InnerRadiusTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void OutsideRadiusTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void SideBTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SideBTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void RadiusTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void SideATextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
