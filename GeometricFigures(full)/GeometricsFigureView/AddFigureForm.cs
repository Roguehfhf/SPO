using GeometricFigures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricsFigureView
{
    public partial class AddFigureForm : Form
    {
        public AddFigureForm()
        {
            InitializeComponent();
        }

        public IFigures Figure
        {
            get
            {
                try
                {
                    var cathThrowFigure = figureControl1.Figure;
                }
                catch (FormatException exception)
                {
                    MessageBox.Show(exception.Message);
                    return null;
                }
                return figureControl1.Figure;
            }
            set
            {
                try
                {
                    figureControl1.Figure = value;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception A)
            {
                MessageBox.Show(A.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
