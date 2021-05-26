﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafica1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NombreGrafica2 = new System.Windows.Forms.Label();
            this.grafica2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LbError = new System.Windows.Forms.Label();
            this.LbIteracion = new System.Windows.Forms.Label();
            this.BtnPausa = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica2)).BeginInit();
            this.SuspendLayout();
            // 
            // grafica1
            // 
            chartArea11.AxisX.IsLabelAutoFit = false;
            chartArea11.AxisX.LineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea11.AxisX.MajorGrid.Enabled = false;
            chartArea11.AxisX.MajorTickMark.Enabled = false;
            chartArea11.AxisY.IsLabelAutoFit = false;
            chartArea11.AxisY.LineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea11.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea11.AxisY.MajorTickMark.Enabled = false;
            chartArea11.Name = "ChartArea1";
            this.grafica1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.grafica1.Legends.Add(legend11);
            this.grafica1.Location = new System.Drawing.Point(485, 105);
            this.grafica1.Name = "grafica1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.grafica1.Series.Add(series11);
            this.grafica1.Size = new System.Drawing.Size(459, 281);
            this.grafica1.TabIndex = 0;
            this.grafica1.Text = "grafica1";
            // 
            // NombreGrafica2
            // 
            this.NombreGrafica2.BackColor = System.Drawing.Color.White;
            this.NombreGrafica2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreGrafica2.Location = new System.Drawing.Point(20, 31);
            this.NombreGrafica2.Name = "NombreGrafica2";
            this.NombreGrafica2.Size = new System.Drawing.Size(365, 19);
            this.NombreGrafica2.TabIndex = 3;
            this.NombreGrafica2.Text = "Error por salida";
            this.NombreGrafica2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grafica2
            // 
            chartArea12.AxisX.IsLabelAutoFit = false;
            chartArea12.AxisX.LineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea12.AxisX.MajorGrid.Enabled = false;
            chartArea12.AxisX.MajorTickMark.Enabled = false;
            chartArea12.AxisY.IsLabelAutoFit = false;
            chartArea12.AxisY.LineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea12.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea12.AxisY.MajorTickMark.Enabled = false;
            chartArea12.Name = "ChartArea1";
            this.grafica2.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.grafica2.Legends.Add(legend12);
            this.grafica2.Location = new System.Drawing.Point(20, 105);
            this.grafica2.Name = "grafica2";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.grafica2.Series.Add(series12);
            this.grafica2.Size = new System.Drawing.Size(459, 281);
            this.grafica2.TabIndex = 14;
            this.grafica2.Text = "chart1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Error IT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(45, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 1);
            this.panel1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(508, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 1);
            this.panel2.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(45, 420);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 1);
            this.panel3.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Error:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbError
            // 
            this.LbError.BackColor = System.Drawing.Color.White;
            this.LbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbError.Location = new System.Drawing.Point(113, 451);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(272, 19);
            this.LbError.TabIndex = 58;
            this.LbError.Text = "#";
            this.LbError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbIteracion
            // 
            this.LbIteracion.BackColor = System.Drawing.Color.White;
            this.LbIteracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIteracion.Location = new System.Drawing.Point(877, 450);
            this.LbIteracion.Name = "LbIteracion";
            this.LbIteracion.Size = new System.Drawing.Size(68, 19);
            this.LbIteracion.TabIndex = 59;
            this.LbIteracion.Text = "#";
            this.LbIteracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPausa
            // 
            this.BtnPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPausa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPausa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnPausa.FlatAppearance.BorderSize = 0;
            this.BtnPausa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnPausa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPausa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnPausa.Location = new System.Drawing.Point(455, 443);
            this.BtnPausa.Name = "BtnPausa";
            this.BtnPausa.Size = new System.Drawing.Size(66, 35);
            this.BtnPausa.TabIndex = 60;
            this.BtnPausa.Text = "Pausar";
            this.BtnPausa.UseVisualStyleBackColor = true;
            this.BtnPausa.Click += new System.EventHandler(this.BtnPausa_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnIniciar.Location = new System.Drawing.Point(452, 443);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(80, 35);
            this.BtnIniciar.TabIndex = 61;
            this.BtnIniciar.Text = "Reanudar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(951, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 62;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Close);
            // 
            // Graficador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 506);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LbIteracion);
            this.Controls.Add(this.LbError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreGrafica2);
            this.Controls.Add(this.grafica2);
            this.Controls.Add(this.grafica1);
            this.Controls.Add(this.BtnPausa);
            this.Controls.Add(this.BtnIniciar);
            this.MaximizeBox = false;
            this.Name = "Graficador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            ((System.ComponentModel.ISupportInitialize)(this.grafica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataVisualization.Charting.Chart grafica1;
        private System.Windows.Forms.Label NombreGrafica2;
        public System.Windows.Forms.DataVisualization.Charting.Chart grafica2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbError;
        private System.Windows.Forms.Label LbIteracion;
        private System.Windows.Forms.Button BtnPausa;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button button1;
    }
}