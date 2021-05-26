
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
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnIniciar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnIniciar.Location = new System.Drawing.Point(69, 43);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(69, 39);
            this.BtnIniciar.TabIndex = 16;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(69, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 244);
            this.dataGridView1.TabIndex = 20;
            // 
            // OFD
            // 
            this.OFD.Filter = "Archivo XML (*.XML)|*.XML";
            // 
            // Generalizador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(773, 407);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnIniciar);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Generalizador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}