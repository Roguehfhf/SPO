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
    public partial class RingControl : UserControl
    {
        public RingControl()
        {
            InitializeComponent();
        }
        public Ring Ring
        {
            get
            {
                var ring = new Ring();
                try
                {
                    ring.OutsideRadius = Convert.ToDouble(OutsideRadiusTextBox.Text);
                    ring.InnerRadius = Convert.ToDouble(InnerRadiusTextBox.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка ввода данных!");
                    throw exception;
                }
                return ring;

            }
            set
            {
                OutsideRadiusTextBox.Text = value.OutsideRadius.ToString();
                InnerRadiusTextBox.Text   = value.InnerRadius.ToString();
                try
                {
                    double outsideRadiusTextBox = Convert.ToDouble(this.OutsideRadiusTextBox.Text);
                    double innerRadiusTextBox = Convert.ToDouble(this.InnerRadiusTextBox.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка ввода данных!");
                    throw exception;
                }
            }
        }
    }
}
