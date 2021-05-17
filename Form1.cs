using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph_Function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            f_1.Checked = true;
        }
        private void Input(TextBox textBox, object sender, KeyPressEventArgs e) // Проверка ввода
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                if (e.KeyChar == '-')
                {
                    if (textBox.Text.Length > 0 || textBox.Text.Contains('-'))
                        e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar == '+')
                    if (textBox.Text.Length > 0 || textBox.Text.Contains('+'))
                        e.KeyChar = (char)Keys.None;
                if (e.KeyChar == ',')
                {
                    e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar != '-' && e.KeyChar != '+' && e.KeyChar != ',')
                    e.KeyChar = (char)Keys.None;
            }

        }
        private void A_KeyPress(object sender, KeyPressEventArgs e) // ввод B
        {
            try
            {
                Input(A, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        private void B_KeyPress(object sender, KeyPressEventArgs e) // ввод B
        {
            try
            {
                Input(B, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        private void Max_KeyPress(object sender, KeyPressEventArgs e) // ввод B
        {
            try
            {
                Input(Max, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        private void Min_KeyPress(object sender, KeyPressEventArgs e) // ввод B
        {
            try
            {
                Input(Min, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }

        private void Op_Click(object sender, EventArgs e)
        {
            try
            {
                int min = int.Parse(Min.Text);
                int max = int.Parse(Max.Text);
                if (min > max || min >= 0 || max < 0)
                {
                    MessageBox.Show("Некоректный ввод!");
                }
                else if (min < max || min < 0 || max > 0)
                {
                    int[] y = new int[700];
                    int[] x = new int[700];
                    Graph.Series[0].ChartType = SeriesChartType.Line;
                    Graph.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    Graph.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    Graph.ChartAreas[0].AxisY.Maximum = max;
                    Graph.ChartAreas[0].AxisX.Maximum = max;
                    Graph.ChartAreas[0].AxisY.Minimum = min;
                    Graph.ChartAreas[0].AxisX.Minimum = min;
                    Graph.ChartAreas[0].AxisX.Crossing = 0;
                    Graph.ChartAreas[0].AxisY.Crossing = 0;
                    if (f_1.Checked) // y = ax
                    {
                        int a = int.Parse(A.Text);
                        Graph.Series[0].Points.Clear();
                        Graph.Series[0].Name = "y = ax";
                        for (int i = min; i < max; i++)
                        {
                            for (int j = 0; j < max; j++)
                            {
                                y[j] = a * i;
                                x[j] = i;
                            }
                        }
                        for (int i = 0; i < y.Length; i++)
                        {
                            Graph.Series[0].Points.AddXY(x[i], y[i]);
                            Graph.Series[0].Points.AddXY(-x[i], -y[i]);
                        }
                    }
                    if (f_2.Checked) // y = ax + b
                    {

                        int a = int.Parse(A.Text);
                        int b = int.Parse(B.Text);
                        Graph.Series[0].Points.Clear();
                        Graph.Series[0].Name = "y = ax + b";
                        for (int i = min; i < max; i++)
                        {
                            for (int j = 0; j < max; j++)
                            {
                                y[j] = (a * i);
                                x[j] = i;
                            }
                        }
                        for (int i = 0; i < y.Length; i++)
                        {
                            Graph.Series[0].Points.AddXY(x[i], y[i] + b);
                            Graph.Series[0].Points.AddXY(-x[i], -y[i] + b);
                        }
                    }
                    if (f_3.Checked) // y = x^2
                    {
                        Graph.Series[0].Points.Clear();
                        Graph.Series[0].Name = "y = x^2";
                        for (double i = min; i <= max; i += 0.1)
                            Graph.Series[0].Points.AddXY(i, i * i);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Некоректный ввод!");
            }
        }
        private void f_2_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = false;
            A.ReadOnly = false;
            C.ReadOnly = true;
        }

        private void f_1_CheckedChanged(object sender, EventArgs e)
        {
            A.ReadOnly = false;
            B.ReadOnly = true;
            C.ReadOnly = true;
        }

        private void f_3_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
        }
    }
}
