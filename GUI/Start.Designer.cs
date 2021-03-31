namespace GUI
{
    partial class Start
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnPausa = new System.Windows.Forms.Button();
            this.BtnSimulation = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PbCarga = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbEscalon = new System.Windows.Forms.PictureBox();
            this.PbLineal = new System.Windows.Forms.PictureBox();
            this.PbSigmoide = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LbEntrenado = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LbSalidas = new System.Windows.Forms.Label();
            this.LbPatrones = new System.Windows.Forms.Label();
            this.LbEntradas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NbRata = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.NbErrorMax = new System.Windows.Forms.NumericUpDown();
            this.NbIteracion = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbActivacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.Patrones = new System.Windows.Forms.DataGridView();
            this.SalidasEsperadas = new System.Windows.Forms.DataGridView();
            this.Pesos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.E1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarga)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbEscalon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLineal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSigmoide)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbRata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbErrorMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbIteracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Patrones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalidasEsperadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pesos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.BtnPausa);
            this.panel1.Controls.Add(this.BtnSimulation);
            this.panel1.Controls.Add(this.BtnIniciar);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.BtnOpen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PbCarga);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(202, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 105);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button3.Location = new System.Drawing.Point(410, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnPausa
            // 
            this.BtnPausa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPausa.BackgroundImage")));
            this.BtnPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPausa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPausa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnPausa.FlatAppearance.BorderSize = 0;
            this.BtnPausa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnPausa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BtnPausa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnPausa.Location = new System.Drawing.Point(484, 67);
            this.BtnPausa.Name = "BtnPausa";
            this.BtnPausa.Size = new System.Drawing.Size(30, 30);
            this.BtnPausa.TabIndex = 9;
            this.BtnPausa.UseVisualStyleBackColor = true;
            this.BtnPausa.Click += new System.EventHandler(this.BtnPausa_Click);
            // 
            // BtnSimulation
            // 
            this.BtnSimulation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSimulation.BackgroundImage")));
            this.BtnSimulation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSimulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSimulation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnSimulation.FlatAppearance.BorderSize = 0;
            this.BtnSimulation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnSimulation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BtnSimulation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnSimulation.Location = new System.Drawing.Point(448, 67);
            this.BtnSimulation.Name = "BtnSimulation";
            this.BtnSimulation.Size = new System.Drawing.Size(30, 30);
            this.BtnSimulation.TabIndex = 8;
            this.BtnSimulation.UseVisualStyleBackColor = true;
            this.BtnSimulation.Click += new System.EventHandler(this.Simular);
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
            this.BtnIniciar.Location = new System.Drawing.Point(486, 66);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(30, 30);
            this.BtnIniciar.TabIndex = 6;
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.Entrenar);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button4.Location = new System.Drawing.Point(522, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOpen.BackgroundImage")));
            this.BtnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnOpen.FlatAppearance.BorderSize = 0;
            this.BtnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BtnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnOpen.Location = new System.Drawing.Point(563, 67);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(30, 30);
            this.BtnOpen.TabIndex = 4;
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Simple";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Red perceptrón";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button2.Location = new System.Drawing.Point(532, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = " -";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Minimize);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.Location = new System.Drawing.Point(563, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = " X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Close);
            // 
            // PbCarga
            // 
            this.PbCarga.Image = ((System.Drawing.Image)(resources.GetObject("PbCarga.Image")));
            this.PbCarga.Location = new System.Drawing.Point(208, 0);
            this.PbCarga.Name = "PbCarga";
            this.PbCarga.Size = new System.Drawing.Size(100, 100);
            this.PbCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCarga.TabIndex = 7;
            this.PbCarga.TabStop = false;
            this.PbCarga.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Pesos);
            this.panel2.Controls.Add(this.SalidasEsperadas);
            this.panel2.Controls.Add(this.Patrones);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.PbEscalon);
            this.panel2.Controls.Add(this.PbLineal);
            this.panel2.Controls.Add(this.PbSigmoide);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(202, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 391);
            this.panel2.TabIndex = 1;
            // 
            // PbEscalon
            // 
            this.PbEscalon.BackColor = System.Drawing.Color.White;
            this.PbEscalon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbEscalon.BackgroundImage")));
            this.PbEscalon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbEscalon.Location = new System.Drawing.Point(298, 6);
            this.PbEscalon.Name = "PbEscalon";
            this.PbEscalon.Size = new System.Drawing.Size(43, 43);
            this.PbEscalon.TabIndex = 2;
            this.PbEscalon.TabStop = false;
            // 
            // PbLineal
            // 
            this.PbLineal.BackColor = System.Drawing.Color.White;
            this.PbLineal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbLineal.BackgroundImage")));
            this.PbLineal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbLineal.Location = new System.Drawing.Point(298, 6);
            this.PbLineal.Name = "PbLineal";
            this.PbLineal.Size = new System.Drawing.Size(43, 43);
            this.PbLineal.TabIndex = 4;
            this.PbLineal.TabStop = false;
            // 
            // PbSigmoide
            // 
            this.PbSigmoide.BackColor = System.Drawing.Color.White;
            this.PbSigmoide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbSigmoide.BackgroundImage")));
            this.PbSigmoide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbSigmoide.Location = new System.Drawing.Point(298, 6);
            this.PbSigmoide.Name = "PbSigmoide";
            this.PbSigmoide.Size = new System.Drawing.Size(43, 43);
            this.PbSigmoide.TabIndex = 3;
            this.PbSigmoide.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.LbEntrenado);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.LbSalidas);
            this.panel6.Controls.Add(this.LbPatrones);
            this.panel6.Controls.Add(this.LbEntradas);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 371);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(596, 20);
            this.panel6.TabIndex = 0;
            // 
            // LbEntrenado
            // 
            this.LbEntrenado.AutoSize = true;
            this.LbEntrenado.Location = new System.Drawing.Point(411, 2);
            this.LbEntrenado.Name = "LbEntrenado";
            this.LbEntrenado.Size = new System.Drawing.Size(15, 16);
            this.LbEntrenado.TabIndex = 7;
            this.LbEntrenado.Text = "#";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label13.Location = new System.Drawing.Point(355, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Entrenado:";
            // 
            // LbSalidas
            // 
            this.LbSalidas.AutoSize = true;
            this.LbSalidas.Location = new System.Drawing.Point(555, 2);
            this.LbSalidas.Name = "LbSalidas";
            this.LbSalidas.Size = new System.Drawing.Size(15, 16);
            this.LbSalidas.TabIndex = 5;
            this.LbSalidas.Text = "#";
            // 
            // LbPatrones
            // 
            this.LbPatrones.AutoSize = true;
            this.LbPatrones.Location = new System.Drawing.Point(247, 2);
            this.LbPatrones.Name = "LbPatrones";
            this.LbPatrones.Size = new System.Drawing.Size(15, 16);
            this.LbPatrones.TabIndex = 4;
            this.LbPatrones.Text = "#";
            // 
            // LbEntradas
            // 
            this.LbEntradas.AutoSize = true;
            this.LbEntradas.Location = new System.Drawing.Point(71, 2);
            this.LbEntradas.Name = "LbEntradas";
            this.LbEntradas.Size = new System.Drawing.Size(15, 16);
            this.LbEntradas.TabIndex = 3;
            this.LbEntradas.Text = "#";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label10.Location = new System.Drawing.Point(512, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Salidas: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label9.Location = new System.Drawing.Point(196, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Patrones: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label8.Location = new System.Drawing.Point(20, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Entradas: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.NbRata);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.NbErrorMax);
            this.panel3.Controls.Add(this.NbIteracion);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.CbActivacion);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 496);
            this.panel3.TabIndex = 2;
            // 
            // NbRata
            // 
            this.NbRata.BackColor = System.Drawing.Color.White;
            this.NbRata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbRata.DecimalPlaces = 2;
            this.NbRata.ForeColor = System.Drawing.Color.Black;
            this.NbRata.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NbRata.Location = new System.Drawing.Point(18, 297);
            this.NbRata.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbRata.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.NbRata.Name = "NbRata";
            this.NbRata.Size = new System.Drawing.Size(163, 18);
            this.NbRata.TabIndex = 15;
            this.NbRata.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbRata.ValueChanged += new System.EventHandler(this.RaChange);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label11.Location = new System.Drawing.Point(15, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Rata de aprendizaje";
            // 
            // NbErrorMax
            // 
            this.NbErrorMax.BackColor = System.Drawing.Color.White;
            this.NbErrorMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbErrorMax.DecimalPlaces = 2;
            this.NbErrorMax.ForeColor = System.Drawing.Color.Black;
            this.NbErrorMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NbErrorMax.Location = new System.Drawing.Point(18, 222);
            this.NbErrorMax.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbErrorMax.Name = "NbErrorMax";
            this.NbErrorMax.Size = new System.Drawing.Size(163, 18);
            this.NbErrorMax.TabIndex = 12;
            this.NbErrorMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NbErrorMax.ValueChanged += new System.EventHandler(this.EmChange);
            // 
            // NbIteracion
            // 
            this.NbIteracion.BackColor = System.Drawing.Color.White;
            this.NbIteracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbIteracion.ForeColor = System.Drawing.Color.Black;
            this.NbIteracion.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NbIteracion.Location = new System.Drawing.Point(18, 142);
            this.NbIteracion.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NbIteracion.Name = "NbIteracion";
            this.NbIteracion.Size = new System.Drawing.Size(163, 18);
            this.NbIteracion.TabIndex = 11;
            this.NbIteracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbIteracion.ValueChanged += new System.EventHandler(this.ItChange);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(15, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Error máximo permitido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(15, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número de iteraciones";
            // 
            // CbActivacion
            // 
            this.CbActivacion.BackColor = System.Drawing.Color.White;
            this.CbActivacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbActivacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbActivacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbActivacion.ForeColor = System.Drawing.Color.Black;
            this.CbActivacion.FormattingEnabled = true;
            this.CbActivacion.Location = new System.Drawing.Point(19, 371);
            this.CbActivacion.Name = "CbActivacion";
            this.CbActivacion.Size = new System.Drawing.Size(163, 24);
            this.CbActivacion.TabIndex = 4;
            this.CbActivacion.SelectedIndexChanged += new System.EventHandler(this.CambiarActivacion);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(15, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Función de activación";
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(98, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "FUNCIÓN DE ACTIVACIÓN:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Patrones
            // 
            this.Patrones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Patrones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.E1});
            this.Patrones.Location = new System.Drawing.Point(6, 130);
            this.Patrones.Name = "Patrones";
            this.Patrones.Size = new System.Drawing.Size(192, 235);
            this.Patrones.TabIndex = 6;
            // 
            // SalidasEsperadas
            // 
            this.SalidasEsperadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalidasEsperadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Salida});
            this.SalidasEsperadas.Location = new System.Drawing.Point(202, 130);
            this.SalidasEsperadas.Name = "SalidasEsperadas";
            this.SalidasEsperadas.Size = new System.Drawing.Size(192, 235);
            this.SalidasEsperadas.TabIndex = 7;
            // 
            // Pesos
            // 
            this.Pesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pesos.Location = new System.Drawing.Point(398, 130);
            this.Pesos.Name = "Pesos";
            this.Pesos.Size = new System.Drawing.Size(192, 235);
            this.Pesos.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(52, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Patrones";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Cornsilk;
            this.label12.Location = new System.Drawing.Point(236, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Salidas esperadas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Cornsilk;
            this.label14.Location = new System.Drawing.Point(467, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "Pesos";
            // 
            // E1
            // 
            this.E1.HeaderText = "E1";
            this.E1.Name = "E1";
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Salida";
            this.Salida.Name = "Salida";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Start";
            this.Opacity = 0.98D;
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarga)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbEscalon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLineal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSigmoide)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbRata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbErrorMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbIteracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Patrones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalidasEsperadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pesos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NbErrorMax;
        private System.Windows.Forms.NumericUpDown NbIteracion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbActivacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.PictureBox PbCarga;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox PbEscalon;
        private System.Windows.Forms.PictureBox PbLineal;
        private System.Windows.Forms.PictureBox PbSigmoide;
        private System.Windows.Forms.Label LbPatrones;
        private System.Windows.Forms.Label LbEntradas;
        private System.Windows.Forms.NumericUpDown NbRata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSimulation;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button BtnPausa;
        private System.Windows.Forms.Label LbEntrenado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LbSalidas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Pesos;
        private System.Windows.Forms.DataGridView SalidasEsperadas;
        private System.Windows.Forms.DataGridView Patrones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn E1;
    }
}

