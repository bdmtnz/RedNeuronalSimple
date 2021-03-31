
namespace GUI
{
    partial class Generalizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generalizador));
            this.label6 = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbPatrones = new System.Windows.Forms.Label();
            this.LbError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LbIteraciones = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LbUmbral = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LbPesos = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LbPath = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(24, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Simulación";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIniciar.BackgroundImage")));
            this.BtnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BtnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnIniciar.Location = new System.Drawing.Point(126, 19);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(40, 39);
            this.BtnIniciar.TabIndex = 16;
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.Location = new System.Drawing.Point(674, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = " X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 162);
            this.dataGridView1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Path: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Patrones cargados: ";
            // 
            // LbPatrones
            // 
            this.LbPatrones.AutoSize = true;
            this.LbPatrones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPatrones.ForeColor = System.Drawing.SystemColors.Control;
            this.LbPatrones.Location = new System.Drawing.Point(123, 104);
            this.LbPatrones.Name = "LbPatrones";
            this.LbPatrones.Size = new System.Drawing.Size(15, 16);
            this.LbPatrones.TabIndex = 23;
            this.LbPatrones.Text = "#";
            // 
            // LbError
            // 
            this.LbError.AutoSize = true;
            this.LbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbError.ForeColor = System.Drawing.SystemColors.Control;
            this.LbError.Location = new System.Drawing.Point(124, 137);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(15, 16);
            this.LbError.TabIndex = 25;
            this.LbError.Text = "#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(25, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Error logrado: ";
            // 
            // LbIteraciones
            // 
            this.LbIteraciones.AutoSize = true;
            this.LbIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIteraciones.ForeColor = System.Drawing.SystemColors.Control;
            this.LbIteraciones.Location = new System.Drawing.Point(123, 170);
            this.LbIteraciones.Name = "LbIteraciones";
            this.LbIteraciones.Size = new System.Drawing.Size(15, 16);
            this.LbIteraciones.TabIndex = 27;
            this.LbIteraciones.Text = "#";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(24, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Iteraciones: ";
            // 
            // LbUmbral
            // 
            this.LbUmbral.AutoSize = true;
            this.LbUmbral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUmbral.ForeColor = System.Drawing.SystemColors.Control;
            this.LbUmbral.Location = new System.Drawing.Point(123, 206);
            this.LbUmbral.Name = "LbUmbral";
            this.LbUmbral.Size = new System.Drawing.Size(15, 16);
            this.LbUmbral.TabIndex = 29;
            this.LbUmbral.Text = "#";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(24, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Umbrales: ";
            // 
            // LbPesos
            // 
            this.LbPesos.AutoSize = true;
            this.LbPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPesos.ForeColor = System.Drawing.SystemColors.Control;
            this.LbPesos.Location = new System.Drawing.Point(124, 242);
            this.LbPesos.Name = "LbPesos";
            this.LbPesos.Size = new System.Drawing.Size(15, 16);
            this.LbPesos.TabIndex = 31;
            this.LbPesos.Text = "#";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(25, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Pesos: ";
            // 
            // LbPath
            // 
            this.LbPath.AutoSize = true;
            this.LbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPath.ForeColor = System.Drawing.SystemColors.Control;
            this.LbPath.Location = new System.Drawing.Point(59, 72);
            this.LbPath.Name = "LbPath";
            this.LbPath.Size = new System.Drawing.Size(15, 16);
            this.LbPath.TabIndex = 32;
            this.LbPath.Text = "#";
            // 
            // OFD
            // 
            this.OFD.Filter = "Archivo XML (*.XML)|*.XML";
            // 
            // FrmSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(705, 293);
            this.ControlBox = false;
            this.Controls.Add(this.LbPath);
            this.Controls.Add(this.LbPesos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LbUmbral);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LbIteraciones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LbError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbPatrones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSimulador";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbPatrones;
        private System.Windows.Forms.Label LbError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbIteraciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LbUmbral;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LbPesos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LbPath;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}