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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.C = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(40, 37);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(100, 22);
            this.Min.TabIndex = 0;
            this.Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Min_KeyPress);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(40, 65);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(100, 22);
            this.Max.TabIndex = 1;
            this.Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Max_KeyPress);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(40, 93);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 22);
            this.A.TabIndex = 2;
            this.A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.A_KeyPress);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(40, 121);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 22);
            this.B.TabIndex = 3;
            this.B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.B_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "b";
            // 
            // Graph
            // 
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graph.Legends.Add(legend1);
            this.Graph.Location = new System.Drawing.Point(174, 12);
            this.Graph.Name = "Graph";
            this.Graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Graph.Series.Add(series1);
            this.Graph.Size = new System.Drawing.Size(688, 480);
            this.Graph.TabIndex = 8;
            this.Graph.Text = "chart1";
            // 
            // f_1
            // 
            this.f_1.AutoSize = true;
            this.f_1.ForeColor = System.Drawing.Color.Yellow;
            this.f_1.Location = new System.Drawing.Point(37, 36);
            this.f_1.Name = "f_1";
            this.f_1.Size = new System.Drawing.Size(66, 21);
            this.f_1.TabIndex = 9;
            this.f_1.TabStop = true;
            this.f_1.Text = "y = ax";
            this.f_1.UseVisualStyleBackColor = true;
            this.f_1.CheckedChanged += new System.EventHandler(this.f_1_CheckedChanged);
            // 
            // Op
            // 
            this.Op.BackColor = System.Drawing.Color.DimGray;
            this.Op.ForeColor = System.Drawing.Color.Yellow;
            this.Op.Location = new System.Drawing.Point(12, 458);
            this.Op.Name = "Op";
            this.Op.Size = new System.Drawing.Size(159, 34);
            this.Op.TabIndex = 10;
            this.Op.Text = "Построить";
            this.Op.UseVisualStyleBackColor = false;
            this.Op.Click += new System.EventHandler(this.Op_Click);
            // 
            // f_2
            // 
            this.f_2.AutoSize = true;
            this.f_2.ForeColor = System.Drawing.Color.Yellow;
            this.f_2.Location = new System.Drawing.Point(37, 63);
            this.f_2.Name = "f_2";
            this.f_2.Size = new System.Drawing.Size(90, 21);
            this.f_2.TabIndex = 11;
            this.f_2.TabStop = true;
            this.f_2.Text = "y = ax + b";
            this.f_2.UseVisualStyleBackColor = true;
            this.f_2.CheckedChanged += new System.EventHandler(this.f_2_CheckedChanged);
            // 
            // f_3
            // 
            this.f_3.AutoSize = true;
            this.f_3.ForeColor = System.Drawing.Color.Yellow;
            this.f_3.Location = new System.Drawing.Point(37, 90);
            this.f_3.Name = "f_3";
            this.f_3.Size = new System.Drawing.Size(73, 21);
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
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 197);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.f_3);
            this.groupBox2.Controls.Add(this.f_2);
            this.groupBox2.Controls.Add(this.f_1);
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 237);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Функции";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(40, 149);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(100, 22);
            this.C.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "c";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(874, 504);
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
    }
}

