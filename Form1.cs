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
                        e.KeyChar = (char)Keys.None;
                if (e.KeyChar == ',')
                {
                    if (textBox.Text.Contains(','))
                        e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar != '-' && e.KeyChar != '+' && e.KeyChar != ',')
                    e.KeyChar = (char)Keys.None;
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

        private void f_5_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
        }

        private void f_4_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = false;
            A.ReadOnly = false;
            C.ReadOnly = false;
        }

        private void f_6_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
        }

        private void f_7_CheckedChanged(object sender, EventArgs e)
        {
            A.ReadOnly = false;
            B.ReadOnly = true;
            C.ReadOnly = true;
        }

        private void f_8_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
        }

        private void f_9_CheckedChanged(object sender, EventArgs e)
        {
            A.ReadOnly = false;
            B.ReadOnly = true;
            C.ReadOnly = true;
        }

        private void f_10_CheckedChanged(object sender, EventArgs e)
        {
            A.ReadOnly = false;
            B.ReadOnly = true;
            C.ReadOnly = true;
        }

        private void f_11_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
        }

        private void f_12_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
        }

        private void f_13_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
        }

        private void f_14_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
        }

        private void f_15_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
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
                double min = double.Parse(Min.Text);
                double max = double.Parse(Max.Text);
                if (min > max || min >= 0 || max < 0)
                {
                    MessageBox.Show("Некоректный ввод!");
                }
                else if (min < max || min < 0 || max > 0)
                {
                    Graph.Series[0].Points.Clear();
                    Graph.Series[1].Points.Clear();
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
                        double a = double.Parse(A.Text);
                        Graph.Series[0].Name = "y = ax";
                        for (double i = min; i <= max; i += 0.1)
                        {
                            Graph.Series[0].Points.AddXY(i, a * i);
                        }
                    }
                    if (f_2.Checked) // y = ax + b
                    {

                        double a = double.Parse(A.Text);
                        double b = double.Parse(B.Text);
                        Graph.Series[0].Name = "y = ax + b";
                        for (double i = min; i <= max; i += 0.1)
                        {
                            Graph.Series[0].Points.AddXY(i, a * i + b);
                        }
                    }
                    if (f_3.Checked) // y = x^2
                    {
                        Graph.Series[0].Name = "y = x^2";
                        for (double i = min; i <= max; i += 0.1)
                            Graph.Series[0].Points.AddXY(i, i * i);
                    }
                    if (f_4.Checked) // y = ax^2 + bx + c
                    {
                        double a = double.Parse(A.Text);
                        double b = double.Parse(B.Text);
                        double c = double.Parse(C.Text);
                        Graph.Series[0].Name = "y = ax^2 + bx + c";
                        for (double i = min; i <= max; i += 0.1)
                        {
                            Graph.Series[0].Points.AddXY(i, a * Math.Pow(i,2) + b * i + c);
                        }
                    }
                    if (f_5.Checked) // y = x^3
                    {
                        Graph.Series[0].Name = "y = x^3";
                        for (double i = min; i <= max; i += 0.1)
                            Graph.Series[0].Points.AddXY(i, i * i * i);
                    }
                    if (f_6.Checked) // y = x^1/2
                    {
                        Graph.Series[0].Name = "y = x^1/2";
                        for (double i = min; i <= max; i += 0.1)
                            Graph.Series[0].Points.AddXY(i, Math.Pow(i,0.5));
                    }
                    if (f_7.Checked) // y = a/x and y = -(a/x)
                    {
                        double a = double.Parse(A.Text);
                        Graph.Series[0].Name = "y = a/x";
                        Graph.Series[1].Name = "y = -(a/x)";
                        for (double i = 0.1; i < max; i+=0.1)
                        {
                            Graph.Series[0].Points.AddXY(i, a/i);
                            Graph.Series[1].Points.AddXY(-i, -(a / i));
                        }
                    }
                    if (f_8.Checked) // y = ln(x) and y = -ln(x)
                    {
                        Graph.Series[0].Name = "y = ln(x)";
                        Graph.Series[1].Name = "y = -ln(x)";
                        for (double i = 1e-3; i < 1e3; i+=0.1)
                        {
                            Graph.Series[0].Points.AddXY(i, Math.Log(i));
                            Graph.Series[1].Points.AddXY(-i, -Math.Log(i));
                        }
                    }
                    if (f_9.Checked) // y = loga(x) and -loga(x)
                    {
                        int a = int.Parse(A.Text);
                        Graph.Series[0].Name = "y = loga(x)";
                        Graph.Series[1].Name = "y = -loga(x)";
                        if (a > 0) {
                            for (double i = 1e-3; i < 1e3; i += 0.1)
                            {
                                Graph.Series[0].Points.AddXY(i, Math.Log(i, a));
                                Graph.Series[1].Points.AddXY(i, -Math.Log(i, a));
                            }
                        }
                        else
                        {
                            Graph.Series[0].Points.Clear();
                            MessageBox.Show("Число a не должно быть отрицательным!");
                        }
                    }
                    if (f_10.Checked) // y = a^x НЕ РАБОТАЕТ С ОТРИЦАТЕЛЬНЫМИ ЧИСЛАМИ
                    {
                        int a = int.Parse(A.Text);
                        Graph.Series[0].Name = "y = a^x";
                        for (double i = min; i < max; i += 0.1)
                        {
                            double k = Math.Pow(a, i);
                            Graph.Series[0].Points.AddXY(i, k);
                        }
                    }
                    if (f_11.Checked) // y = e^x
                    {
                        Graph.Series[0].Name = "y = e^x";
                        Graph.Series[1].Name = "y = -e^x";
                        for (double i = min; i < max; i+=0.1)
                        {
                            Graph.Series[0].Points.AddXY(i, Math.Exp(i));
                            Graph.Series[1].Points.AddXY(i, -Math.Exp(i));
                        }
                    }
                    if (f_12.Checked) // y = sin(x)
                    {
                        Graph.Series[0].Name = "y = sin(x)";
                        Graph.Series[1].Name = "y = -sin(x)";
                        for (double i = min; i < max; i += 0.1)
                        {
                            Graph.Series[0].Points.AddXY(i, Math.Sin(i));
                            Graph.Series[1].Points.AddXY(i, -Math.Sin(i));
                        }
                    }
                    if (f_13.Checked) // y = cos(x)
                    {
                        Graph.Series[0].Name = "y = cos(x)";
                        Graph.Series[1].Name = "y = -cos(x)";
                        for (double i = min; i < max; i += 0.1)
                        {
                            Graph.Series[0].Points.AddXY(i, Math.Cos(i));
                            Graph.Series[1].Points.AddXY(i, -Math.Cos(i));
                        }
                    }
                    if (f_14.Checked) // y = tg(x) НЕ ГОТОВ
                    {
                        Graph.Series[0].Name = "y = tg(x)";
                        for (double i = min; i < max; i+=0.1)
                        {
                            Graph.Series[0].Points.AddXY(i, Math.Tan(i));
                        }
                    }
                    if (f_15.Checked) // y = ctg(x) НЕ ГОТОВ
                    {
                        Graph.Series[0].Name = "y = ctg(x)";
                        for (double i = min; i < max; i += 0.1)
                        {
                            Graph.Series[0].Points.AddXY(i, 1/Math.Tan(i));
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Некоректный ввод!");
            }
        }
    }
}
