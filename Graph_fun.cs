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
    public partial class Graph_fun : Form
    {
        double min = -30;
        double max = 30;
        public Graph_fun()
        {
            InitializeComponent();
            Zr.Enabled = false;
            Area.Enabled = false;
            Op.Enabled = false;
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Bis.Enabled = false;
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
                if (e.KeyChar != '-')
                    e.KeyChar = (char)Keys.None;
            }

        }
        private void f_2_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = false;
            A.ReadOnly = false;
            C.ReadOnly = true;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Op.Enabled = true;
            Area.Enabled = false;
        }

        private void f_1_CheckedChanged(object sender, EventArgs e)
        {
            A.ReadOnly = false;
            B.ReadOnly = true;
            C.ReadOnly = true;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Op.Enabled = true;
            Area.Enabled = false;
        }

        private void f_3_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Op.Enabled = true;
            Area.Enabled = false;
        }

        private void f_5_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Op.Enabled = true;
            Area.Enabled = false;
        }

        private void f_4_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = false;
            A.ReadOnly = false;
            C.ReadOnly = false;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Op.Enabled = true;
            Area.Enabled = false;
        }

        private void f_6_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Op.Enabled = true;
            Area.Enabled = false;
        }

        private void f_7_CheckedChanged(object sender, EventArgs e)
        {
            A.ReadOnly = false;
            B.ReadOnly = true;
            C.ReadOnly = true;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Op.Enabled = true;
            Area.Enabled = false;
        }

        private void f_8_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Op.Enabled = true;
            Area.Enabled = false;
        }

        private void f_9_CheckedChanged(object sender, EventArgs e)
        {
            A.ReadOnly = false;
            B.ReadOnly = true;
            C.ReadOnly = true;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Op.Enabled = true;
            Area.Enabled = false;
        }

        private void f_10_CheckedChanged(object sender, EventArgs e)
        {
            A.ReadOnly = false;
            B.ReadOnly = true;
            C.ReadOnly = true;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Op.Enabled = true;
            Area.Enabled = false;
        }

        private void f_11_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Op.Enabled = true;
            Area.Enabled = false;
        }

        private void f_12_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Op.Enabled = true;
            Area.Enabled = false;
        }

        private void f_13_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
            Cr.ReadOnly = true;
            L.ReadOnly = true;
            Op.Enabled = true;
            Area.Enabled = false;
        }
        private void f_14_CheckedChanged(object sender, EventArgs e)
        {
            B.ReadOnly = true;
            A.ReadOnly = true;
            C.ReadOnly = true;
            Cr.ReadOnly = false;
            L.ReadOnly = false;
            Op.Enabled = true;
        }
        private void A_KeyPress(object sender, KeyPressEventArgs e) // ввод А
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
        private void C_KeyPress(object sender, KeyPressEventArgs e) // ввод C
        {
            try
            {
                Input(C, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        private void count_KeyPress(object sender, KeyPressEventArgs e) // ввод количества углов
        {
            try
            {
                Input(Cr, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        private void length_KeyPress(object sender, KeyPressEventArgs e) // ввод длины сторон
        {
            try
            {
                Input(L, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        private void Op_Click(object sender, EventArgs e) // Кнопка для построения графика
        {
            try
            {
                Graph.ChartAreas[0].AxisY.Maximum = max;
                Graph.ChartAreas[0].AxisX.Maximum = max;
                Graph.ChartAreas[0].AxisY.Minimum = min;
                Graph.ChartAreas[0].AxisX.Minimum = min;
                Graph.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                Graph.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                Graph.ChartAreas[0].AxisX.Crossing = 0;
                Graph.ChartAreas[0].AxisY.Crossing = 0;
                Graph.Series[0].Points.Clear();
                Graph.Series[1].Points.Clear();
                Build(max, min);
            }
            catch
            {
                MessageBox.Show("Некоректный ввод!");
            }
        }        
        private void Clear_Click(object sender, EventArgs e) // Кнопка очищения поля для графиков
        {
            Clear_graph();
        }
        private void Save_png_Click(object sender, EventArgs e) // Кнопка для сохранения графика в "png"
        {
            Save_img();
        }
        private void Zr_Click(object sender, EventArgs e) // Кнопка отзеркаливания
        {
            try
            {
                Graph.ChartAreas[0].AxisY.Maximum = max;
                Graph.ChartAreas[0].AxisX.Maximum = max;
                Graph.ChartAreas[0].AxisY.Minimum = min;
                Graph.ChartAreas[0].AxisX.Minimum = min;
                Graph.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                Graph.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                Graph.ChartAreas[0].AxisX.Crossing = 0;
                Graph.ChartAreas[0].AxisY.Crossing = 0;
                Graph.Series[1].Points.Clear();
                Reflect(max, min);
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
            Zr.Enabled = false;
        }
        private void aut_Click(object sender, EventArgs e) // Кнопка для показа окна автора
        {
            Author au = new Author();
            au.ShowDialog();
        }
        private void Help_Click(object sender, EventArgs e) // Кнопка для показа окна помощи по пограмме
        {
            Help h = new Help();
            h.ShowDialog();
        }
        private void Area_Click(object sender, EventArgs e) // Кнопка вычисления площади многоугольника
        {
            if (Graph.Series[0].Name == "Многоугольник(1)")
            {
                int count = int.Parse(Cr.Text);
                int length = int.Parse(L.Text);
                double s = Square(length, count);
                MessageBox.Show($"Площадь этого многоугольника = {Math.Round(s, 2)}");
                Area.Enabled = false;
            }
        }
        private void Bis_Click(object sender, EventArgs e) // Кнопка построения биссектрисы угла многоугольника
        {
            Bis_angle();
            Bis.Enabled = false;
        }
        public void Build(double max, double min) // Построения
        {
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
                    Graph.Series[0].Points.AddXY(i, a * Math.Pow(i, 2) + b * i + c);
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
                    Graph.Series[0].Points.AddXY(i, Math.Pow(i, 0.5));
            }
            if (f_7.Checked) // y = a/x and y = -(a/x)
            {
                double a = double.Parse(A.Text);
                if (a > 0)
                {
                    Graph.Series[0].Name = "y = a/x (x>0)";
                    Graph.Series[1].Name = "y = a/x (x<0)";
                }
                if (a < 0)
                {
                    Graph.Series[0].Name = "y = -a/x (x>0)";
                    Graph.Series[1].Name = "y = -a/x (x<0)";
                }
                for (double i = 0.1; i < max; i += 0.1)
                {
                    Graph.Series[0].Points.AddXY(i, a / i);
                    Graph.Series[1].Points.AddXY(-i, -(a / i));
                }
            }
            if (f_8.Checked) // y = ln(x)
            {
                Graph.Series[0].Name = "y = ln(x)";
                for (double i = 1e-3; i < 1e3; i += 0.1)
                {
                    Graph.Series[0].Points.AddXY(i, Math.Log(i));
                }
            }
            if (f_9.Checked) // y = loga(x)
            {
                int a = int.Parse(A.Text);
                Graph.Series[0].Name = "y = loga(x)";
                if (a > 0)
                {
                    for (double i = 1e-3; i < 1e3; i += 0.1)
                    {
                        Graph.Series[0].Points.AddXY(i, Math.Log(i, a));
                    }
                }
                else
                {
                    Graph.Series[0].Points.Clear();
                    Zr.Enabled = false;
                    MessageBox.Show("Число a не должно быть отрицательным!");
                }
            }
            if (f_10.Checked) // y = a^x
            {
                double a = double.Parse(A.Text);
                Graph.Series[0].Name = "y = a^x";
                if (a > 1 && a < 6)
                {
                    for (double i = min; i < max; i += 0.1)
                    {
                        Graph.Series[0].Points.AddXY(i, Math.Pow(a, i));
                    }
                }
                else if (a < 0 && a > -6)
                {
                    for (double i = min; i < max; i += 0.1)
                    {
                        Graph.Series[0].Points.AddXY(i, -Math.Pow(-a, i));
                    }
                }
                else if (a > 5 || a < -5 || a == 0)
                {
                    Graph.Series[0].Points.Clear();
                    MessageBox.Show("Ошибка!");
                    Zr.Enabled = false;
                }
            }
            if (f_11.Checked) // y = e^x
            {
                Graph.Series[0].Name = "y = e^x";
                for (double i = min; i < max; i += 0.1)
                {
                    Graph.Series[0].Points.AddXY(i, Math.Exp(i));
                }
            }
            if (f_12.Checked) // y = sin(x)
            {
                Graph.Series[0].Name = "y = sin(x)";
                for (double i = min; i < max; i += 0.1)
                {
                    Graph.Series[0].Points.AddXY(i, Math.Sin(i));
                }
            }
            if (f_13.Checked) // y = cos(x)
            {
                Graph.Series[0].Name = "y = cos(x)";
                for (double i = min; i < max; i += 0.1)
                {
                    Graph.Series[0].Points.AddXY(i, Math.Cos(i));
                }
            }
            if (f_14.Checked) // Многоугольник
            {
                Graph.Series[0].Points.Clear();
                int count = int.Parse(Cr.Text);
                int length = int.Parse(L.Text);
                Graph.Series[0].Name = "Многоугольник(1)";
                if (count < 3 || length < 2 || count > 20 || length > max)
                {
                    MessageBox.Show("Некоректный ввод! Количество сторон не должно быть меньше 3 и не больше 20, а длина не меньше 2 и не больше 30.");
                    Graph.Series[0].Points.Clear();
                    Zr.Enabled = false;
                    Area.Enabled = false;
                }
                else
                {
                    double R = length / (2 * Math.Sin(Math.PI / count));
                    for (double angle = 0.0; angle <= 2 * Math.PI; angle += 2 * Math.PI / count)
                    {
                        int x = (int)(R * Math.Cos(angle));
                        int y = (int)(R * Math.Sin(angle));
                        for (double i = 0; i < length; i += 0.1)
                        {
                            Graph.Series[0].Points.AddXY(x - max, y - max);
                            Graph.ChartAreas[0].AxisY.Maximum = max + 2 * length + 2 * count;
                            Graph.ChartAreas[0].AxisX.Maximum = max + 2 * length + 2 * count;
                            Graph.ChartAreas[0].AxisY.Minimum = min - 2 * length - 2 * count;
                            Graph.ChartAreas[0].AxisX.Minimum = min - 2 * length - 2 * count;
                        }
                    }
                    Bis.Enabled = true;
                    Area.Enabled = true;
                }
            }
            Zr.Enabled = true;
        }
        public void Reflect(double max, double min) // Отзеркаливания
        {
            if (Graph.Series[0].Name == "y = ax") // y = ax
            {
                double a = double.Parse(A.Text);
                Graph.Series[1].Name = "-y";
                for (double i = min; i <= max; i += 0.1)
                {
                    Graph.Series[1].Points.AddXY(i, -(a * i));
                }
            }
            if (Graph.Series[0].Name == "y = ax + b") // y = ax + b
            {

                double a = double.Parse(A.Text);
                double b = double.Parse(B.Text);
                Graph.Series[1].Name = "-y";
                for (double i = min; i <= max; i += 0.1)
                {
                    Graph.Series[1].Points.AddXY(i, -(a * i + b));
                }
            }
            if (Graph.Series[0].Name == "y = x^2") // y = x^2
            {
                Graph.Series[1].Name = "-y";
                for (double i = min; i <= max; i += 0.1)
                    Graph.Series[1].Points.AddXY(-i, -(i * i));
            }
            if (Graph.Series[0].Name == "y = ax^2 + bx + c") // y = ax^2 + bx + c
            {
                double a = double.Parse(A.Text);
                double b = double.Parse(B.Text);
                double c = double.Parse(C.Text);
                Graph.Series[1].Name = "-y";
                for (double i = min; i <= max; i += 0.1)
                {
                    Graph.Series[1].Points.AddXY(-i, -(a * Math.Pow(i, 2) + b * i + c));
                }
            }
            if (Graph.Series[0].Name == "y = x^3") // y = x^3
            {
                Graph.Series[1].Name = "-y";
                for (double i = min; i <= max; i += 0.1)
                    Graph.Series[1].Points.AddXY(i, -(i * i * i));
            }
            if (Graph.Series[0].Name == "y = x^1/2") // y = x^1/2
            {
                Graph.Series[1].Name = "-y";
                for (double i = min; i <= max; i += 0.1)
                    Graph.Series[1].Points.AddXY(-i, -Math.Pow(i, 0.5));
            }
            if (Graph.Series[0].Name == "y = a/x (x>0)" || Graph.Series[0].Name == "y = -a/x (x>0)") // y = a/x and y = -(a/x)
            {
                double a = double.Parse(A.Text);
                Graph.Series[0].Points.Clear();
                Graph.Series[1].Points.Clear();
                if (a > 0)
                {
                    Graph.Series[0].Name = "-y = a/x (x>0)";
                    Graph.Series[1].Name = "-y = a/x (x<0)";
                }
                if (a < 0)
                {
                    Graph.Series[0].Name = "-y = -a/x (x>0)";
                    Graph.Series[1].Name = "-y = -a/x (x<0)";
                }
                for (double i = 0.1; i < max; i += 0.1)
                {
                    Graph.Series[1].Points.AddXY(i, (a / i));
                    Graph.Series[0].Points.AddXY(-i, -(a / i));
                }
            }
            if (Graph.Series[0].Name == "y = ln(x)") // y = -ln(x)
            {
                Graph.Series[1].Name = "-y";
                for (double i = 1e-3; i < 1e3; i += 0.1)
                {
                    Graph.Series[1].Points.AddXY(-i, -Math.Log(i));
                }
            }
            if (Graph.Series[0].Name == "y = loga(x)") // y = -loga(x)
            {
                int a = int.Parse(A.Text);
                Graph.Series[1].Name = "-y";
                if (a > 0)
                {
                    for (double i = 1e-3; i < 1e3; i += 0.1)
                    {
                        Graph.Series[1].Points.AddXY(-i, -Math.Log(i, a));
                    }
                }
                else
                {
                    Graph.Series[0].Points.Clear();
                    MessageBox.Show("Число a не должно быть отрицательным!");
                }
            }
            if (Graph.Series[0].Name == "y = a^x") // y = a^x
            {
                double a = double.Parse(A.Text);
                Graph.Series[1].Name = "-y";
                if (a > 1)
                {
                    for (double i = min; i < max; i += 0.1)
                    {
                        Graph.Series[1].Points.AddXY(-i, -Math.Pow(a, i));
                    }
                }
                else if (a < 0)
                {
                    for (double i = min; i < max; i += 0.1)
                    {
                        Graph.Series[1].Points.AddXY(-i, Math.Pow(-a, i));
                    }
                }
            }
            if (Graph.Series[0].Name == "y = e^x") // y = -e^x
            {
                Graph.Series[1].Name = "-y";
                for (double i = min; i < max; i += 0.1)
                {
                    Graph.Series[1].Points.AddXY(-i, -Math.Exp(i));
                }
            }
            if (Graph.Series[0].Name == "y = sin(x)") // y = -sin(x)
            {
                Graph.Series[1].Name = "-y";
                for (double i = min; i < max; i += 0.1)
                {
                    Graph.Series[1].Points.AddXY(i, -Math.Sin(i));
                }
            }
            if (Graph.Series[0].Name == "y = cos(x)") // y = -cos(x)
            {
                Graph.Series[1].Name = "-y";
                for (double i = min; i < max; i += 0.1)
                {
                    Graph.Series[1].Points.AddXY(i, -Math.Cos(i));
                }
            }
            if (Graph.Series[0].Name == "Многоугольник(1)") // Многоугольник
            {
                Graph.Series[1].Points.Clear();
                int count = int.Parse(Cr.Text);
                int length = int.Parse(L.Text);
                Graph.Series[1].Name = "Многоугольник(2)";
                if (count <= 2 || length <= 1 || count > 20 || length > max)
                {
                    MessageBox.Show("Некоректный ввод!");
                    Graph.Series[1].Points.Clear();
                    Zr.Enabled = false;
                }
                else
                {
                    double R = length / (2 * Math.Sin(Math.PI / count));
                    for (double angle = 0.0; angle <= 2 * Math.PI; angle += 2 * Math.PI / count)
                    {
                        int x = (int)(R * Math.Cos(angle));
                        int y = (int)(R * Math.Sin(angle));
                        for (double i = 0; i < length; i += 0.1)
                        {
                            Graph.Series[1].Points.AddXY(-x + max, -y + max);
                            Graph.ChartAreas[0].AxisY.Maximum = max + 2 * length + 2 * count;
                            Graph.ChartAreas[0].AxisX.Maximum = max + 2 * length + 2 * count;
                            Graph.ChartAreas[0].AxisY.Minimum = min - 2 * length - 2 * count;
                            Graph.ChartAreas[0].AxisX.Minimum = min - 2 * length - 2 * count;
                        }
                    }
                }
            }
        }
        public double Square(int l, int c) // Вычисления площади многоугольника
        {
            double r = l/ (2 * Math.Tan(Math.PI / c));
            double s = c * Math.Pow(r, 2) * Math.Tan(Math.PI / c);
            return s;
        }
        public void Save_img() // Сохранения графика в "png"
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранить изображение как ...";
            sfd.Filter = "*.png|*.png";
            sfd.AddExtension = true;
            sfd.FileName = "graphicImage";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Graph.SaveImage(sfd.FileName, ChartImageFormat.Png);
            }
        }
        public void Clear_graph() // Очищения поля для графиков
        {
            Graph.Series[0].Points.Clear();
            Graph.Series[1].Points.Clear();
        }
        public void Bis_angle() // Построения биссектрисы угла многоугольника
        {
            if (Graph.Series[0].Name == "Многоугольник(1)")
            {
                Graph.Series[1].Points.Clear();
                Graph.Series[1].Name = "Биссектриса угла";
                int count = int.Parse(Cr.Text);
                int length = int.Parse(L.Text);
                double R = length / (2 * Math.Sin(Math.PI / count));
                int x = (int)(R * Math.Cos(0));
                int y = (int)(R * Math.Sin(0));
                if (count % 2 == 0)
                {
                    for (double i = x; i > -x; i -= 0.1)
                    {
                        Graph.Series[1].Points.AddXY(i - max, y - max);
                    }
                }
                else if (count % 2 == 1)
                {
                    for (double i = x; i > -x + length / count; i -= 0.1)
                    {
                        Graph.Series[1].Points.AddXY(i - max, y - max);
                    }
                }
            }
        }
    }
}
