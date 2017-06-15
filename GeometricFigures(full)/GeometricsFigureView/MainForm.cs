﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeometricFigures;

namespace GeometricsFigureView
{
    public partial class MainForm : Form
    {
        private List<IFigures> _figures;

        private Dictionary<string, double> figureDictionary;
        public MainForm()
        {
            InitializeComponent();
            _figures = new List<IFigures>();
            iFiguresBindingSource.DataSource = _figures;
            figureDictionary = new Dictionary<string, double>();
        }

        private void AddFigureButton_Click(object sender, EventArgs e)
        {
            var form = new AddFigureForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                iFiguresBindingSource.Add(form.Figure);
                figureDictionary.Add(form.Figure.Type, form.Figure.Perimeter);
            }
        }

        private void ModifyFigureButton_Click(object sender, EventArgs e)
        {
            if (iFiguresBindingSource.Current == null)
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
                    iFiguresBindingSource.RemoveAt(index);
                    iFiguresBindingSource.Insert(index, form.Figure);
                }
            }
        }

        private void RemoveFigureButton_Click(object sender, EventArgs e)
        {
            if (iFiguresBindingSource.Current != null)
            {
                foreach (DataGridViewRow r in FigureDataGridView.SelectedRows)
                {
                    iFiguresBindingSource.RemoveAt(r.Index);
                    figureDictionary.Clear();
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
            iFiguresBindingSource.Add(new GeometricFigures.Rectangle(rnd.Next(1, 30), rnd.Next(1, 30)));
            iFiguresBindingSource.Add(new Triangle(10, 20, 29));
            iFiguresBindingSource.Add(new Circle(rnd.Next(1, 10)));
            iFiguresBindingSource.Add(new Ring(rnd.Next(6, 10), rnd.Next(1, 5)));
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
            {
                _figures = Serialization.Deserialize(ofd.FileName);
                iFiguresBindingSource.DataSource = _figures;
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

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
