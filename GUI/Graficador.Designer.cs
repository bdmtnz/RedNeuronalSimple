
namespace GUI
{
    partial class Graficador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafica1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NombreGrafica2 = new System.Windows.Forms.Label();
            this.LbIteracion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grafica2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica2)).BeginInit();
            this.SuspendLayout();
            // 
            // grafica1
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.grafica1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica1.Legends.Add(legend1);
            this.grafica1.Location = new System.Drawing.Point(18, 63);
            this.grafica1.Name = "grafica1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafica1.Series.Add(series1);
            this.grafica1.Size = new System.Drawing.Size(740, 140);
            this.grafica1.TabIndex = 0;
            this.grafica1.Text = "grafica1";
            // 
            // NombreGrafica2
            // 
            this.NombreGrafica2.BackColor = System.Drawing.Color.White;
            this.NombreGrafica2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreGrafica2.Location = new System.Drawing.Point(18, 219);
            this.NombreGrafica2.Name = "NombreGrafica2";
            this.NombreGrafica2.Size = new System.Drawing.Size(740, 19);
            this.NombreGrafica2.TabIndex = 3;
            this.NombreGrafica2.Text = "Error por salida";
            this.NombreGrafica2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbIteracion
            // 
            this.LbIteracion.AutoSize = true;
            this.LbIteracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbIteracion.ForeColor = System.Drawing.Color.Black;
            this.LbIteracion.Location = new System.Drawing.Point(106, 12);
            this.LbIteracion.Name = "LbIteracion";
            this.LbIteracion.Size = new System.Drawing.Size(18, 20);
            this.LbIteracion.TabIndex = 9;
            this.LbIteracion.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Iteraciones : ";
            // 
            // LbError
            // 
            this.LbError.AutoSize = true;
            this.LbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbError.ForeColor = System.Drawing.Color.Black;
            this.LbError.Location = new System.Drawing.Point(334, 12);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(18, 20);
            this.LbError.TabIndex = 13;
            this.LbError.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(284, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Error : ";
            // 
            // grafica2
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.grafica2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafica2.Legends.Add(legend2);
            this.grafica2.Location = new System.Drawing.Point(18, 238);
            this.grafica2.Name = "grafica2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.grafica2.Series.Add(series2);
            this.grafica2.Size = new System.Drawing.Size(740, 140);
            this.grafica2.TabIndex = 14;
            this.grafica2.Text = "chart1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Error IT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Graficador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreGrafica2);
            this.Controls.Add(this.grafica2);
            this.Controls.Add(this.LbError);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LbIteracion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grafica1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Graficador";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafica";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            ((System.ComponentModel.ISupportInitialize)(this.grafica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataVisualization.Charting.Chart grafica1;
        private System.Windows.Forms.Label NombreGrafica2;
        private System.Windows.Forms.Label LbIteracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbError;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataVisualization.Charting.Chart grafica2;
        private System.Windows.Forms.Label label1;
    }
}