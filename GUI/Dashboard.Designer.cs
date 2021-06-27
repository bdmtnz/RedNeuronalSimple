namespace GUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbCarga = new System.Windows.Forms.PictureBox();
            this.BtnSimulation = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPausa = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.Embebed = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.TbFuncion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TbNeuronas = new System.Windows.Forms.TextBox();
            this.NbRata = new System.Windows.Forms.NumericUpDown();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.NbErrorMax = new System.Windows.Forms.NumericUpDown();
            this.NbIteracion = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnReiniciar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LbUmbral = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LbPeso = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LbEntrenado = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LbSalidas = new System.Windows.Forms.Label();
            this.LbPatrones = new System.Windows.Forms.Label();
            this.LbEntradas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarga)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbRata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbErrorMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbIteracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.PbCarga);
            this.panel1.Controls.Add(this.BtnSimulation);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnOpen);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnPausa);
            this.panel1.Controls.Add(this.BtnIniciar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(238, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 100);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // PbCarga
            // 
            this.PbCarga.Image = ((System.Drawing.Image)(resources.GetObject("PbCarga.Image")));
            this.PbCarga.Location = new System.Drawing.Point(265, 0);
            this.PbCarga.Name = "PbCarga";
            this.PbCarga.Size = new System.Drawing.Size(100, 100);
            this.PbCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCarga.TabIndex = 26;
            this.PbCarga.TabStop = false;
            this.PbCarga.Visible = false;
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
            this.BtnSimulation.Location = new System.Drawing.Point(622, 62);
            this.BtnSimulation.Name = "BtnSimulation";
            this.BtnSimulation.Size = new System.Drawing.Size(30, 30);
            this.BtnSimulation.TabIndex = 24;
            this.BtnSimulation.UseVisualStyleBackColor = true;
            this.BtnSimulation.Click += new System.EventHandler(this.Simular);
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnSave.Location = new System.Drawing.Point(696, 62);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(30, 30);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.button4_Click);
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
            this.BtnOpen.Location = new System.Drawing.Point(737, 62);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(30, 30);
            this.BtnOpen.TabIndex = 21;
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label8.Location = new System.Drawing.Point(147, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "y";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.SystemColors.Control;
            this.linkLabel3.Location = new System.Drawing.Point(46, 47);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(101, 16);
            this.linkLabel3.TabIndex = 19;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Gerson Moreno";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenLink);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label17.Location = new System.Drawing.Point(19, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "Por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Gracias a";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.Control;
            this.linkLabel2.Location = new System.Drawing.Point(82, 67);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(92, 16);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Tony Jimenez";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenLink);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.Location = new System.Drawing.Point(163, 47);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 16);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Brayan Martinez";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenLink);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Red madaline";
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
            this.BtnPausa.Location = new System.Drawing.Point(660, 63);
            this.BtnPausa.Name = "BtnPausa";
            this.BtnPausa.Size = new System.Drawing.Size(30, 30);
            this.BtnPausa.TabIndex = 25;
            this.BtnPausa.UseVisualStyleBackColor = true;
            this.BtnPausa.Click += new System.EventHandler(this.BtnPausa_Click);
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
            this.BtnIniciar.Location = new System.Drawing.Point(660, 61);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(30, 30);
            this.BtnIniciar.TabIndex = 23;
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.Entrenar);
            // 
            // Embebed
            // 
            this.Embebed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.Embebed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Embebed.Location = new System.Drawing.Point(238, 100);
            this.Embebed.Name = "Embebed";
            this.Embebed.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Embebed.Size = new System.Drawing.Size(777, 420);
            this.Embebed.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.TbFuncion);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.TbNeuronas);
            this.panel3.Controls.Add(this.NbRata);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.NbErrorMax);
            this.panel3.Controls.Add(this.NbIteracion);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.BtnReiniciar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 540);
            this.panel3.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(28, 440);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(185, 1);
            this.panel9.TabIndex = 74;
            // 
            // TbFuncion
            // 
            this.TbFuncion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.TbFuncion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFuncion.ForeColor = System.Drawing.SystemColors.Control;
            this.TbFuncion.Location = new System.Drawing.Point(28, 419);
            this.TbFuncion.Name = "TbFuncion";
            this.TbFuncion.Size = new System.Drawing.Size(185, 19);
            this.TbFuncion.TabIndex = 73;
            this.TbFuncion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(24, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Funciones de activación";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(28, 356);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(185, 1);
            this.panel8.TabIndex = 71;
            // 
            // TbNeuronas
            // 
            this.TbNeuronas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.TbNeuronas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbNeuronas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNeuronas.ForeColor = System.Drawing.SystemColors.Control;
            this.TbNeuronas.Location = new System.Drawing.Point(28, 335);
            this.TbNeuronas.Name = "TbNeuronas";
            this.TbNeuronas.Size = new System.Drawing.Size(185, 19);
            this.TbNeuronas.TabIndex = 70;
            this.TbNeuronas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NbRata
            // 
            this.NbRata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.NbRata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbRata.DecimalPlaces = 2;
            this.NbRata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbRata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NbRata.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NbRata.Location = new System.Drawing.Point(138, 242);
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
            this.NbRata.Size = new System.Drawing.Size(75, 22);
            this.NbRata.TabIndex = 69;
            this.NbRata.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbRata.ValueChanged += new System.EventHandler(this.RaChange);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(138, 265);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(75, 1);
            this.panel7.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label11.Location = new System.Drawing.Point(134, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 67;
            this.label11.Text = "Rata";
            // 
            // NbErrorMax
            // 
            this.NbErrorMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.NbErrorMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbErrorMax.DecimalPlaces = 3;
            this.NbErrorMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbErrorMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NbErrorMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NbErrorMax.Location = new System.Drawing.Point(28, 242);
            this.NbErrorMax.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbErrorMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NbErrorMax.Name = "NbErrorMax";
            this.NbErrorMax.Size = new System.Drawing.Size(75, 22);
            this.NbErrorMax.TabIndex = 66;
            this.NbErrorMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NbErrorMax.ValueChanged += new System.EventHandler(this.EmChange);
            // 
            // NbIteracion
            // 
            this.NbIteracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.NbIteracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbIteracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbIteracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NbIteracion.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NbIteracion.Location = new System.Drawing.Point(28, 151);
            this.NbIteracion.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NbIteracion.Name = "NbIteracion";
            this.NbIteracion.Size = new System.Drawing.Size(185, 22);
            this.NbIteracion.TabIndex = 65;
            this.NbIteracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NbIteracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbIteracion.ValueChanged += new System.EventHandler(this.ItChange);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(28, 265);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 1);
            this.panel5.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(24, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Error máx";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(28, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 1);
            this.panel4.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(24, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Número de iteraciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(24, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Neuronas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Home);
            // 
            // BtnReiniciar
            // 
            this.BtnReiniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnReiniciar.BackgroundImage")));
            this.BtnReiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnReiniciar.FlatAppearance.BorderSize = 0;
            this.BtnReiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BtnReiniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnReiniciar.Location = new System.Drawing.Point(22, 490);
            this.BtnReiniciar.Name = "BtnReiniciar";
            this.BtnReiniciar.Size = new System.Drawing.Size(30, 30);
            this.BtnReiniciar.TabIndex = 58;
            this.BtnReiniciar.UseVisualStyleBackColor = true;
            this.BtnReiniciar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(0, 474);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label4.Size = new System.Drawing.Size(238, 66);
            this.label4.TabIndex = 75;
            this.label4.Text = "2021 - I";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.LbUmbral);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.LbPeso);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.LbEntrenado);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.LbSalidas);
            this.panel6.Controls.Add(this.LbPatrones);
            this.panel6.Controls.Add(this.LbEntradas);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(238, 520);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(777, 20);
            this.panel6.TabIndex = 4;
            // 
            // LbUmbral
            // 
            this.LbUmbral.AutoSize = true;
            this.LbUmbral.Location = new System.Drawing.Point(748, 2);
            this.LbUmbral.Name = "LbUmbral";
            this.LbUmbral.Size = new System.Drawing.Size(15, 16);
            this.LbUmbral.TabIndex = 11;
            this.LbUmbral.Text = "#";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label16.Location = new System.Drawing.Point(695, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Umbrales:";
            // 
            // LbPeso
            // 
            this.LbPeso.AutoSize = true;
            this.LbPeso.Location = new System.Drawing.Point(612, 2);
            this.LbPeso.Name = "LbPeso";
            this.LbPeso.Size = new System.Drawing.Size(15, 16);
            this.LbPeso.TabIndex = 9;
            this.LbPeso.Text = "#";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label14.Location = new System.Drawing.Point(572, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Pesos:";
            // 
            // LbEntrenado
            // 
            this.LbEntrenado.AutoSize = true;
            this.LbEntrenado.Location = new System.Drawing.Point(345, 2);
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
            this.label13.Location = new System.Drawing.Point(289, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Entrenado:";
            // 
            // LbSalidas
            // 
            this.LbSalidas.AutoSize = true;
            this.LbSalidas.Location = new System.Drawing.Point(478, 2);
            this.LbSalidas.Name = "LbSalidas";
            this.LbSalidas.Size = new System.Drawing.Size(15, 16);
            this.LbSalidas.TabIndex = 5;
            this.LbSalidas.Text = "#";
            // 
            // LbPatrones
            // 
            this.LbPatrones.AutoSize = true;
            this.LbPatrones.Location = new System.Drawing.Point(201, 2);
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
            this.label10.Location = new System.Drawing.Point(435, 4);
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
            this.label9.Location = new System.Drawing.Point(150, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Patrones: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label12.Location = new System.Drawing.Point(20, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Entradas: ";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1015, 540);
            this.Controls.Add(this.Embebed);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Madaline";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarga)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbRata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbErrorMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbIteracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Embebed;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button BtnReiniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox TbFuncion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox TbNeuronas;
        private System.Windows.Forms.NumericUpDown NbRata;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NbErrorMax;
        private System.Windows.Forms.NumericUpDown NbIteracion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSimulation;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPausa;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PbCarga;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LbUmbral;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LbPeso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LbEntrenado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LbSalidas;
        private System.Windows.Forms.Label LbPatrones;
        private System.Windows.Forms.Label LbEntradas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    }
}

