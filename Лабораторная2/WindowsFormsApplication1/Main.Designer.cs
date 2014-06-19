namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxParabola = new System.Windows.Forms.TextBox();
            this.textBoxStraight = new System.Windows.Forms.TextBox();
            this.textBoxSinusoid = new System.Windows.Forms.TextBox();
            this.textboxCollision = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 334);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(162, 56);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.method1);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(548, 15);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Парабола";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Прямая";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Синусоида";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Посторонние объекты";
            series4.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(646, 443);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // textBoxParabola
            // 
            this.textBoxParabola.Location = new System.Drawing.Point(13, 13);
            this.textBoxParabola.Multiline = true;
            this.textBoxParabola.Name = "textBoxParabola";
            this.textBoxParabola.Size = new System.Drawing.Size(162, 293);
            this.textBoxParabola.TabIndex = 3;
            // 
            // textBoxStraight
            // 
            this.textBoxStraight.Location = new System.Drawing.Point(182, 13);
            this.textBoxStraight.Multiline = true;
            this.textBoxStraight.Name = "textBoxStraight";
            this.textBoxStraight.Size = new System.Drawing.Size(168, 293);
            this.textBoxStraight.TabIndex = 4;
            // 
            // textBoxSinusoid
            // 
            this.textBoxSinusoid.Location = new System.Drawing.Point(356, 15);
            this.textBoxSinusoid.Multiline = true;
            this.textBoxSinusoid.Name = "textBoxSinusoid";
            this.textBoxSinusoid.Size = new System.Drawing.Size(174, 291);
            this.textBoxSinusoid.TabIndex = 5;
            // 
            // textboxCollision
            // 
            this.textboxCollision.Location = new System.Drawing.Point(182, 334);
            this.textboxCollision.Multiline = true;
            this.textboxCollision.Name = "textboxCollision";
            this.textboxCollision.Size = new System.Drawing.Size(348, 124);
            this.textboxCollision.TabIndex = 6;
            this.textboxCollision.Text = "Точки столкновения:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 470);
            this.Controls.Add(this.textboxCollision);
            this.Controls.Add(this.textBoxSinusoid);
            this.Controls.Add(this.textBoxStraight);
            this.Controls.Add(this.textBoxParabola);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Программа BelongPoints";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.TextBox textBoxParabola;
        public System.Windows.Forms.TextBox textBoxStraight;
        public System.Windows.Forms.TextBox textBoxSinusoid;
        public System.Windows.Forms.TextBox textboxCollision;
    }
}

