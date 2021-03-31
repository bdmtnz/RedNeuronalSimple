
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafica1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreGrafica2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LbIteracion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbUmbral = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LbWs = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // grafica1
            // 
            chartArea3.Name = "ChartArea1";
            this.grafica1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grafica1.Legends.Add(legend3);
            this.grafica1.Location = new System.Drawing.Point(12, 15);
            this.grafica1.Name = "grafica1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.grafica1.Series.Add(series3);
            this.grafica1.Size = new System.Drawing.Size(346, 155);
            this.grafica1.TabIndex = 0;
            this.grafica1.Text = "grafica1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(12, 190);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(346, 155);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // NombreGrafica2
            // 
            this.NombreGrafica2.AutoSize = true;
            this.NombreGrafica2.BackColor = System.Drawing.SystemColors.Control;
            this.NombreGrafica2.Location = new System.Drawing.Point(106, 183);
            this.NombreGrafica2.Name = "NombreGrafica2";
            this.NombreGrafica2.Size = new System.Drawing.Size(90, 13);
            this.NombreGrafica2.TabIndex = 3;
            this.NombreGrafica2.Text = "Error por iteración";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(127, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Error YR";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(548, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = " X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbIteracion
            // 
            this.LbIteracion.AutoSize = true;
            this.LbIteracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbIteracion.ForeColor = System.Drawing.SystemColors.Control;
            this.LbIteracion.Location = new System.Drawing.Point(497, 104);
            this.LbIteracion.Name = "LbIteracion";
            this.LbIteracion.Size = new System.Drawing.Size(18, 20);
            this.LbIteracion.TabIndex = 9;
            this.LbIteracion.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(403, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Iteraciones : ";
            // 
            // LbUmbral
            // 
            this.LbUmbral.AutoSize = true;
            this.LbUmbral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbUmbral.ForeColor = System.Drawing.SystemColors.Control;
            this.LbUmbral.Location = new System.Drawing.Point(497, 128);
            this.LbUmbral.Name = "LbUmbral";
            this.LbUmbral.Size = new System.Drawing.Size(18, 20);
            this.LbUmbral.TabIndex = 11;
            this.LbUmbral.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(431, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Umbral : ";
            // 
            // LbError
            // 
            this.LbError.AutoSize = true;
            this.LbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbError.ForeColor = System.Drawing.SystemColors.Control;
            this.LbError.Location = new System.Drawing.Point(497, 152);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(18, 20);
            this.LbError.TabIndex = 13;
            this.LbError.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(447, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Error : ";
            // 
            // LbWs
            // 
            this.LbWs.AutoSize = true;
            this.LbWs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbWs.ForeColor = System.Drawing.SystemColors.Control;
            this.LbWs.Location = new System.Drawing.Point(376, 227);
            this.LbWs.Name = "LbWs";
            this.LbWs.Size = new System.Drawing.Size(18, 20);
            this.LbWs.TabIndex = 15;
            this.LbWs.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(375, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Pesos logrados : ";
            // 
            // Grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(580, 357);
            this.Controls.Add(this.LbWs);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LbError);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LbUmbral);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LbIteracion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreGrafica2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.grafica1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grafica";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafica";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            ((System.ComponentModel.ISupportInitialize)(this.grafica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataVisualization.Charting.Chart grafica1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label NombreGrafica2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LbIteracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbUmbral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LbWs;
        private System.Windows.Forms.Label label10;
    }
}