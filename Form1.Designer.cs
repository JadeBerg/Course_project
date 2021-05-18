namespace Graph_Function
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Min = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.f_1 = new System.Windows.Forms.RadioButton();
            this.Op = new System.Windows.Forms.Button();
            this.f_2 = new System.Windows.Forms.RadioButton();
            this.f_3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.f_13 = new System.Windows.Forms.RadioButton();
            this.f_12 = new System.Windows.Forms.RadioButton();
            this.f_11 = new System.Windows.Forms.RadioButton();
            this.f_10 = new System.Windows.Forms.RadioButton();
            this.f_9 = new System.Windows.Forms.RadioButton();
            this.f_8 = new System.Windows.Forms.RadioButton();
            this.f_7 = new System.Windows.Forms.RadioButton();
            this.f_6 = new System.Windows.Forms.RadioButton();
            this.f_4 = new System.Windows.Forms.RadioButton();
            this.f_5 = new System.Windows.Forms.RadioButton();
            this.Clear = new System.Windows.Forms.Button();
            this.Many_Corner = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Zr = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Save_png = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(52, 51);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(100, 27);
            this.Min.TabIndex = 0;
            this.Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Min_KeyPress);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(52, 84);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(100, 27);
            this.Max.TabIndex = 1;
            this.Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Max_KeyPress);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(52, 117);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 27);
            this.A.TabIndex = 2;
            this.A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.A_KeyPress);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(52, 150);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 27);
            this.B.TabIndex = 3;
            this.B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.B_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "b";
            // 
            // Graph
            // 
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graph.Legends.Add(legend1);
            this.Graph.Location = new System.Drawing.Point(361, 12);
            this.Graph.Name = "Graph";
            this.Graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.Graph.Series.Add(series1);
            this.Graph.Series.Add(series2);
            this.Graph.Size = new System.Drawing.Size(833, 607);
            this.Graph.TabIndex = 8;
            this.Graph.Text = "chart1";
            // 
            // f_1
            // 
            this.f_1.AutoSize = true;
            this.f_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_1.ForeColor = System.Drawing.Color.Yellow;
            this.f_1.Location = new System.Drawing.Point(9, 36);
            this.f_1.Name = "f_1";
            this.f_1.Size = new System.Drawing.Size(81, 24);
            this.f_1.TabIndex = 9;
            this.f_1.TabStop = true;
            this.f_1.Text = "y = ax";
            this.f_1.UseVisualStyleBackColor = true;
            this.f_1.CheckedChanged += new System.EventHandler(this.f_1_CheckedChanged);
            // 
            // Op
            // 
            this.Op.BackColor = System.Drawing.Color.DimGray;
            this.Op.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Op.ForeColor = System.Drawing.Color.Yellow;
            this.Op.Location = new System.Drawing.Point(12, 487);
            this.Op.Name = "Op";
            this.Op.Size = new System.Drawing.Size(343, 40);
            this.Op.TabIndex = 10;
            this.Op.Text = "Построить график функции";
            this.Op.UseVisualStyleBackColor = false;
            this.Op.Click += new System.EventHandler(this.Op_Click);
            // 
            // f_2
            // 
            this.f_2.AutoSize = true;
            this.f_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_2.ForeColor = System.Drawing.Color.Yellow;
            this.f_2.Location = new System.Drawing.Point(9, 63);
            this.f_2.Name = "f_2";
            this.f_2.Size = new System.Drawing.Size(114, 24);
            this.f_2.TabIndex = 11;
            this.f_2.TabStop = true;
            this.f_2.Text = "y = ax + b";
            this.f_2.UseVisualStyleBackColor = true;
            this.f_2.CheckedChanged += new System.EventHandler(this.f_2_CheckedChanged);
            // 
            // f_3
            // 
            this.f_3.AutoSize = true;
            this.f_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_3.ForeColor = System.Drawing.Color.Yellow;
            this.f_3.Location = new System.Drawing.Point(9, 90);
            this.f_3.Name = "f_3";
            this.f_3.Size = new System.Drawing.Size(89, 24);
            this.f_3.TabIndex = 12;
            this.f_3.TabStop = true;
            this.f_3.Text = "y = x^2";
            this.f_3.UseVisualStyleBackColor = true;
            this.f_3.CheckedChanged += new System.EventHandler(this.f_3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.C);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Controls.Add(this.Max);
            this.groupBox1.Controls.Add(this.Min);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 228);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "c";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(52, 183);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(100, 27);
            this.C.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.f_13);
            this.groupBox2.Controls.Add(this.f_12);
            this.groupBox2.Controls.Add(this.f_11);
            this.groupBox2.Controls.Add(this.f_10);
            this.groupBox2.Controls.Add(this.f_9);
            this.groupBox2.Controls.Add(this.f_8);
            this.groupBox2.Controls.Add(this.f_7);
            this.groupBox2.Controls.Add(this.f_6);
            this.groupBox2.Controls.Add(this.f_4);
            this.groupBox2.Controls.Add(this.f_5);
            this.groupBox2.Controls.Add(this.f_3);
            this.groupBox2.Controls.Add(this.f_2);
            this.groupBox2.Controls.Add(this.f_1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(12, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 235);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Функции";
            // 
            // f_13
            // 
            this.f_13.AutoSize = true;
            this.f_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_13.ForeColor = System.Drawing.Color.Yellow;
            this.f_13.Location = new System.Drawing.Point(202, 144);
            this.f_13.Name = "f_13";
            this.f_13.Size = new System.Drawing.Size(115, 24);
            this.f_13.TabIndex = 22;
            this.f_13.TabStop = true;
            this.f_13.Text = "y = cos(x)";
            this.f_13.UseVisualStyleBackColor = true;
            this.f_13.CheckedChanged += new System.EventHandler(this.f_13_CheckedChanged);
            // 
            // f_12
            // 
            this.f_12.AutoSize = true;
            this.f_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_12.ForeColor = System.Drawing.Color.Yellow;
            this.f_12.Location = new System.Drawing.Point(202, 117);
            this.f_12.Name = "f_12";
            this.f_12.Size = new System.Drawing.Size(110, 24);
            this.f_12.TabIndex = 21;
            this.f_12.TabStop = true;
            this.f_12.Text = "y = sin(x)";
            this.f_12.UseVisualStyleBackColor = true;
            this.f_12.CheckedChanged += new System.EventHandler(this.f_12_CheckedChanged);
            // 
            // f_11
            // 
            this.f_11.AutoSize = true;
            this.f_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_11.ForeColor = System.Drawing.Color.Yellow;
            this.f_11.Location = new System.Drawing.Point(202, 90);
            this.f_11.Name = "f_11";
            this.f_11.Size = new System.Drawing.Size(89, 24);
            this.f_11.TabIndex = 20;
            this.f_11.TabStop = true;
            this.f_11.Text = "y = e^x";
            this.f_11.UseVisualStyleBackColor = true;
            this.f_11.CheckedChanged += new System.EventHandler(this.f_11_CheckedChanged);
            // 
            // f_10
            // 
            this.f_10.AutoSize = true;
            this.f_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_10.ForeColor = System.Drawing.Color.Yellow;
            this.f_10.Location = new System.Drawing.Point(202, 63);
            this.f_10.Name = "f_10";
            this.f_10.Size = new System.Drawing.Size(89, 24);
            this.f_10.TabIndex = 19;
            this.f_10.TabStop = true;
            this.f_10.Text = "y = a^x";
            this.f_10.UseVisualStyleBackColor = true;
            this.f_10.CheckedChanged += new System.EventHandler(this.f_10_CheckedChanged);
            // 
            // f_9
            // 
            this.f_9.AutoSize = true;
            this.f_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_9.ForeColor = System.Drawing.Color.Yellow;
            this.f_9.Location = new System.Drawing.Point(202, 36);
            this.f_9.Name = "f_9";
            this.f_9.Size = new System.Drawing.Size(120, 24);
            this.f_9.TabIndex = 18;
            this.f_9.TabStop = true;
            this.f_9.Text = "y = loga(x)";
            this.f_9.UseVisualStyleBackColor = true;
            this.f_9.CheckedChanged += new System.EventHandler(this.f_9_CheckedChanged);
            // 
            // f_8
            // 
            this.f_8.AutoSize = true;
            this.f_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_8.ForeColor = System.Drawing.Color.Yellow;
            this.f_8.Location = new System.Drawing.Point(202, 171);
            this.f_8.Name = "f_8";
            this.f_8.Size = new System.Drawing.Size(100, 24);
            this.f_8.TabIndex = 17;
            this.f_8.TabStop = true;
            this.f_8.Text = "y = ln(x)";
            this.f_8.UseVisualStyleBackColor = true;
            this.f_8.CheckedChanged += new System.EventHandler(this.f_8_CheckedChanged);
            // 
            // f_7
            // 
            this.f_7.AutoSize = true;
            this.f_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_7.ForeColor = System.Drawing.Color.Yellow;
            this.f_7.Location = new System.Drawing.Point(9, 198);
            this.f_7.Name = "f_7";
            this.f_7.Size = new System.Drawing.Size(87, 24);
            this.f_7.TabIndex = 16;
            this.f_7.TabStop = true;
            this.f_7.Text = "y = a/x";
            this.f_7.UseVisualStyleBackColor = true;
            this.f_7.CheckedChanged += new System.EventHandler(this.f_7_CheckedChanged);
            // 
            // f_6
            // 
            this.f_6.AutoSize = true;
            this.f_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_6.ForeColor = System.Drawing.Color.Yellow;
            this.f_6.Location = new System.Drawing.Point(9, 171);
            this.f_6.Name = "f_6";
            this.f_6.Size = new System.Drawing.Size(105, 24);
            this.f_6.TabIndex = 15;
            this.f_6.TabStop = true;
            this.f_6.Text = "y = x^1/2";
            this.f_6.UseVisualStyleBackColor = true;
            this.f_6.CheckedChanged += new System.EventHandler(this.f_6_CheckedChanged);
            // 
            // f_4
            // 
            this.f_4.AutoSize = true;
            this.f_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_4.ForeColor = System.Drawing.Color.Yellow;
            this.f_4.Location = new System.Drawing.Point(9, 117);
            this.f_4.Name = "f_4";
            this.f_4.Size = new System.Drawing.Size(165, 24);
            this.f_4.TabIndex = 14;
            this.f_4.TabStop = true;
            this.f_4.Text = "y = ax^2 + b + c";
            this.f_4.UseVisualStyleBackColor = true;
            this.f_4.CheckedChanged += new System.EventHandler(this.f_4_CheckedChanged);
            // 
            // f_5
            // 
            this.f_5.AutoSize = true;
            this.f_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_5.ForeColor = System.Drawing.Color.Yellow;
            this.f_5.Location = new System.Drawing.Point(9, 144);
            this.f_5.Name = "f_5";
            this.f_5.Size = new System.Drawing.Size(89, 24);
            this.f_5.TabIndex = 13;
            this.f_5.TabStop = true;
            this.f_5.Text = "y = x^3";
            this.f_5.UseVisualStyleBackColor = true;
            this.f_5.CheckedChanged += new System.EventHandler(this.f_5_CheckedChanged);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.DimGray;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.ForeColor = System.Drawing.Color.Yellow;
            this.Clear.Location = new System.Drawing.Point(12, 533);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(343, 40);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Очистить поле для графика";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Many_Corner
            // 
            this.Many_Corner.BackColor = System.Drawing.Color.DimGray;
            this.Many_Corner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Many_Corner.ForeColor = System.Drawing.Color.Yellow;
            this.Many_Corner.Location = new System.Drawing.Point(12, 579);
            this.Many_Corner.Name = "Many_Corner";
            this.Many_Corner.Size = new System.Drawing.Size(343, 40);
            this.Many_Corner.TabIndex = 16;
            this.Many_Corner.Text = "Построить многоугольник";
            this.Many_Corner.UseVisualStyleBackColor = false;
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.DimGray;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Help.ForeColor = System.Drawing.Color.Yellow;
            this.Help.Location = new System.Drawing.Point(192, 200);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(163, 40);
            this.Help.TabIndex = 17;
            this.Help.Text = "Помощь";
            this.Help.UseVisualStyleBackColor = false;
            // 
            // Zr
            // 
            this.Zr.BackColor = System.Drawing.Color.DimGray;
            this.Zr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zr.ForeColor = System.Drawing.Color.Yellow;
            this.Zr.Location = new System.Drawing.Point(192, 152);
            this.Zr.Name = "Zr";
            this.Zr.Size = new System.Drawing.Size(163, 40);
            this.Zr.TabIndex = 18;
            this.Zr.Text = "Отзеркалить";
            this.Zr.UseVisualStyleBackColor = false;
            this.Zr.Click += new System.EventHandler(this.Zr_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(192, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 19;
            // 
            // Save_png
            // 
            this.Save_png.BackColor = System.Drawing.Color.DimGray;
            this.Save_png.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_png.ForeColor = System.Drawing.Color.Yellow;
            this.Save_png.Location = new System.Drawing.Point(192, 82);
            this.Save_png.Name = "Save_png";
            this.Save_png.Size = new System.Drawing.Size(163, 64);
            this.Save_png.TabIndex = 20;
            this.Save_png.Text = "Сохранить график в png";
            this.Save_png.UseVisualStyleBackColor = false;
            this.Save_png.Click += new System.EventHandler(this.Save_png_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1206, 634);
            this.Controls.Add(this.Save_png);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Zr);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Many_Corner);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Op);
            this.Controls.Add(this.Graph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VikGraph";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.RadioButton f_1;
        private System.Windows.Forms.Button Op;
        private System.Windows.Forms.RadioButton f_2;
        private System.Windows.Forms.RadioButton f_3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.RadioButton f_5;
        private System.Windows.Forms.RadioButton f_4;
        private System.Windows.Forms.RadioButton f_6;
        private System.Windows.Forms.RadioButton f_7;
        private System.Windows.Forms.RadioButton f_8;
        private System.Windows.Forms.RadioButton f_9;
        private System.Windows.Forms.RadioButton f_10;
        private System.Windows.Forms.RadioButton f_11;
        private System.Windows.Forms.RadioButton f_12;
        private System.Windows.Forms.RadioButton f_13;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Many_Corner;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Zr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Save_png;
    }
}

