namespace Graph_Function
{
    partial class Graph_fun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph_fun));
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
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
            this.f_14 = new System.Windows.Forms.RadioButton();
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
            this.Help = new System.Windows.Forms.Button();
            this.Zr = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Save_png = new System.Windows.Forms.Button();
            this.aut = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.TextBox();
            this.Cr = new System.Windows.Forms.TextBox();
            this.Area = new System.Windows.Forms.Button();
            this.Bis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(52, 63);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 27);
            this.A.TabIndex = 2;
            this.A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.A_KeyPress);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(52, 113);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 27);
            this.B.TabIndex = 3;
            this.B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.B_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "b";
            // 
            // Graph
            // 
            this.Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graph.Legends.Add(legend1);
            this.Graph.Location = new System.Drawing.Point(361, 12);
            this.Graph.Name = "Graph";
            this.Graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.Graph.Series.Add(series1);
            this.Graph.Series.Add(series2);
            this.Graph.Size = new System.Drawing.Size(918, 836);
            this.Graph.TabIndex = 8;
            this.Graph.Text = "chart1";
            // 
            // f_1
            // 
            this.f_1.AutoSize = true;
            this.f_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_1.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.Op.BackColor = System.Drawing.Color.Black;
            this.Op.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Op.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Op.Location = new System.Drawing.Point(12, 640);
            this.Op.Name = "Op";
            this.Op.Size = new System.Drawing.Size(343, 40);
            this.Op.TabIndex = 10;
            this.Op.Text = "Построить";
            this.Op.UseVisualStyleBackColor = false;
            this.Op.Click += new System.EventHandler(this.Op_Click);
            // 
            // f_2
            // 
            this.f_2.AutoSize = true;
            this.f_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_2.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.f_3.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 231);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных для графиков";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "c";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(52, 164);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(100, 27);
            this.C.TabIndex = 8;
            this.C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.C_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.f_14);
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
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 235);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Что вы хотите построить?";
            // 
            // f_14
            // 
            this.f_14.AutoSize = true;
            this.f_14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.f_14.Location = new System.Drawing.Point(152, 198);
            this.f_14.Name = "f_14";
            this.f_14.Size = new System.Drawing.Size(170, 24);
            this.f_14.TabIndex = 23;
            this.f_14.TabStop = true;
            this.f_14.Text = "Многоугольник";
            this.f_14.UseVisualStyleBackColor = true;
            this.f_14.CheckedChanged += new System.EventHandler(this.f_14_CheckedChanged);
            // 
            // f_13
            // 
            this.f_13.AutoSize = true;
            this.f_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_13.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.f_12.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.f_11.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.f_10.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.f_9.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.f_8.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.f_7.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.f_6.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.f_4.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.f_5.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.Clear.BackColor = System.Drawing.Color.Black;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Clear.Location = new System.Drawing.Point(12, 686);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(343, 40);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Очистить поле для графика";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Black;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Help.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Help.Location = new System.Drawing.Point(192, 201);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(163, 40);
            this.Help.TabIndex = 17;
            this.Help.Text = "Помощь";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Zr
            // 
            this.Zr.BackColor = System.Drawing.Color.Black;
            this.Zr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Zr.Location = new System.Drawing.Point(192, 153);
            this.Zr.Name = "Zr";
            this.Zr.Size = new System.Drawing.Size(163, 40);
            this.Zr.TabIndex = 18;
            this.Zr.Text = "Отзеркалить";
            this.Zr.UseVisualStyleBackColor = false;
            this.Zr.Click += new System.EventHandler(this.Zr_Click);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(192, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 19;
            // 
            // Save_png
            // 
            this.Save_png.BackColor = System.Drawing.Color.Black;
            this.Save_png.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_png.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Save_png.Location = new System.Drawing.Point(192, 83);
            this.Save_png.Name = "Save_png";
            this.Save_png.Size = new System.Drawing.Size(163, 64);
            this.Save_png.TabIndex = 20;
            this.Save_png.Text = "Сохранить в png";
            this.Save_png.UseVisualStyleBackColor = false;
            this.Save_png.Click += new System.EventHandler(this.Save_png_Click);
            // 
            // aut
            // 
            this.aut.BackColor = System.Drawing.SystemColors.Desktop;
            this.aut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aut.ForeColor = System.Drawing.SystemColors.Highlight;
            this.aut.Location = new System.Drawing.Point(192, 13);
            this.aut.Name = "aut";
            this.aut.Size = new System.Drawing.Size(163, 64);
            this.aut.TabIndex = 21;
            this.aut.Text = "Об авторе";
            this.aut.UseVisualStyleBackColor = false;
            this.aut.Click += new System.EventHandler(this.aut_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.L);
            this.groupBox3.Controls.Add(this.Cr);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(10, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 146);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ввод данных для многоугольника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Длина стороны";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество углов";
            // 
            // L
            // 
            this.L.Location = new System.Drawing.Point(204, 100);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(115, 27);
            this.L.TabIndex = 2;
            this.L.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.length_KeyPress);
            // 
            // Cr
            // 
            this.Cr.Location = new System.Drawing.Point(204, 48);
            this.Cr.Name = "Cr";
            this.Cr.Size = new System.Drawing.Size(115, 27);
            this.Cr.TabIndex = 1;
            this.Cr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.count_KeyPress);
            // 
            // Area
            // 
            this.Area.BackColor = System.Drawing.Color.Black;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Area.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Area.Location = new System.Drawing.Point(12, 732);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(343, 55);
            this.Area.TabIndex = 23;
            this.Area.Text = "Вычислить площадь многоугольника";
            this.Area.UseVisualStyleBackColor = false;
            this.Area.Click += new System.EventHandler(this.Area_Click);
            // 
            // Bis
            // 
            this.Bis.BackColor = System.Drawing.Color.Black;
            this.Bis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bis.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Bis.Location = new System.Drawing.Point(12, 793);
            this.Bis.Name = "Bis";
            this.Bis.Size = new System.Drawing.Size(343, 55);
            this.Bis.TabIndex = 24;
            this.Bis.Text = "Построить биссектрису угла многоугольника\r\n";
            this.Bis.UseVisualStyleBackColor = false;
            this.Bis.Click += new System.EventHandler(this.Bis_Click);
            // 
            // Graph_fun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1291, 860);
            this.Controls.Add(this.Bis);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.aut);
            this.Controls.Add(this.Save_png);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Zr);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Op);
            this.Controls.Add(this.Graph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graph_fun";
            this.Text = "VikGraph";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
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
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Zr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Save_png;
        private System.Windows.Forms.Button aut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox L;
        private System.Windows.Forms.TextBox Cr;
        private System.Windows.Forms.RadioButton f_14;
        private System.Windows.Forms.Button Area;
        private System.Windows.Forms.Button Bis;
    }
}

