using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricFigures;

namespace GeometricsFigureView
{

    public partial class MainForm : Form
    {
             
        /// <summary>
        /// 
        /// </summary>
        private static List<INterfaceFigures> _figures;

        public MainForm()
        {
            InitializeComponent();
            _figures = new List<INterfaceFigures>();
            INterfaceFiguresBindingSource1.DataSource = _figures;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void AddFigureButton_Click(object sender, EventArgs e)
        {
            var form = new AddFigureForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                INterfaceFiguresBindingSource1.Add(form.Figure);
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (INterfaceFiguresBindingSource1.Current == null)
            {
                MessageBox.Show(@"Вы не выбрали строку, которую хотите изменить.", @"Ошибка!");
            }
            else
            {
                var index = FigureDataGridView.SelectedCells[0].RowIndex;
                var form = new AddFigureForm
                {
                    Figure = _figures[index]
                };
                if (form.ShowDialog() == DialogResult.OK)
                {
                    INterfaceFiguresBindingSource1.RemoveAt(index);
                    INterfaceFiguresBindingSource1.Insert(index, form.Figure);
                }
            }
        }

        private void RemoveFigureButton_Click(object sender, EventArgs e)
        {
            if (INterfaceFiguresBindingSource1.Current != null)
            {
                foreach (DataGridViewRow r in FigureDataGridView.SelectedRows)
                {
                    INterfaceFiguresBindingSource1.RemoveAt(r.Index);
                }
            }
            else
            {
                MessageBox.Show(@"Вы не выбрали строку, которую хотите удалить.", @"Ошибка!");
            }
        }

        private void RandomFigureButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            INterfaceFiguresBindingSource1.Add(new GeometricFigures.Rectangle(rnd.Next(1, 30), rnd.Next(1, 30)));
            INterfaceFiguresBindingSource1.Add(new Triangle(10, 20, 29));
            INterfaceFiguresBindingSource1.Add(new Circle(rnd.Next(1, 10)));
            INterfaceFiguresBindingSource1.Add(new Ring(rnd.Next(6, 10),rnd.Next(1,5)));
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _figures = new List<INterfaceFigures>();
            INterfaceFiguresBindingSource1.DataSource = _figures;
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
            {
                _figures = Serialization.Deserialize(ofd.FileName);
                INterfaceFiguresBindingSource1.DataSource = _figures;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_figures.Count != 0)
            {
                var ofd = new SaveFileDialog
                {
                    Filter = @"dat files (*.dat)|*.dat",
                    RestoreDirectory = true
                };
                if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
                {
                    Serialization.Serialize(ofd.FileName, _figures);
                }
            }
            else
            {
                MessageBox.Show(@"Ошибка. Файл не може быть пустым");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != string.Empty)
            {
                for (var i = 0; i < FigureDataGridView.RowCount; i++)
                {
                    FigureDataGridView.Rows[i].Selected = false;
                    for (var j = 0; j < FigureDataGridView.ColumnCount; j++)
                    {
                        if (FigureDataGridView.Rows[i].Cells[j].Value == null)
                        {
                            continue;
                        }
                        if (!FigureDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(SearchTextBox.Text.ToLower()))
                        {
                            continue;
                        }
                        FigureDataGridView.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Введите значение поиска", @"Ошибка!");
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
