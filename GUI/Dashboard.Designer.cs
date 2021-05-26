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
            this.BtnPausa = new System.Windows.Forms.Button();
            this.BtnSimulation = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.Embebed = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnReiniciar = new System.Windows.Forms.Button();
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
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbRata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbErrorMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbIteracion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnReiniciar);
            this.panel1.Controls.Add(this.BtnPausa);
            this.panel1.Controls.Add(this.BtnSimulation);
            this.panel1.Controls.Add(this.BtnIniciar);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(202, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 100);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
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
            this.BtnPausa.Location = new System.Drawing.Point(659, 65);
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
            this.BtnSimulation.Location = new System.Drawing.Point(621, 64);
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
            this.BtnIniciar.Location = new System.Drawing.Point(659, 63);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(30, 30);
            this.BtnIniciar.TabIndex = 6;
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.Entrenar);
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
            this.BtnSave.Location = new System.Drawing.Point(695, 64);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(30, 30);
            this.BtnSave.TabIndex = 5;
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
            this.BtnOpen.Location = new System.Drawing.Point(736, 64);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(30, 30);
            this.BtnOpen.TabIndex = 4;
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // Embebed
            // 
            this.Embebed.BackColor = System.Drawing.Color.White;
            this.Embebed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Embebed.Location = new System.Drawing.Point(202, 102);
            this.Embebed.Name = "Embebed";
            this.Embebed.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Embebed.Size = new System.Drawing.Size(776, 416);
            this.Embebed.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 516);
            this.panel3.TabIndex = 2;
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
            this.BtnReiniciar.Location = new System.Drawing.Point(585, 65);
            this.BtnReiniciar.Name = "BtnReiniciar";
            this.BtnReiniciar.Size = new System.Drawing.Size(30, 30);
            this.BtnReiniciar.TabIndex = 10;
            this.BtnReiniciar.UseVisualStyleBackColor = true;
            this.BtnReiniciar.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel9.ForeColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(18, 411);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(163, 1);
            this.panel9.TabIndex = 20;
            // 
            // TbFuncion
            // 
            this.TbFuncion.BackColor = System.Drawing.Color.SkyBlue;
            this.TbFuncion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbFuncion.ForeColor = System.Drawing.Color.White;
            this.TbFuncion.Location = new System.Drawing.Point(18, 392);
            this.TbFuncion.Name = "TbFuncion";
            this.TbFuncion.Size = new System.Drawing.Size(163, 15);
            this.TbFuncion.TabIndex = 19;
            this.TbFuncion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Funciones de activación";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(18, 343);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(163, 1);
            this.panel8.TabIndex = 17;
            // 
            // TbNeuronas
            // 
            this.TbNeuronas.BackColor = System.Drawing.Color.SkyBlue;
            this.TbNeuronas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbNeuronas.ForeColor = System.Drawing.Color.White;
            this.TbNeuronas.Location = new System.Drawing.Point(18, 324);
            this.TbNeuronas.Name = "TbNeuronas";
            this.TbNeuronas.Size = new System.Drawing.Size(163, 15);
            this.TbNeuronas.TabIndex = 16;
            this.TbNeuronas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NbRata
            // 
            this.NbRata.BackColor = System.Drawing.Color.SkyBlue;
            this.NbRata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbRata.DecimalPlaces = 2;
            this.NbRata.ForeColor = System.Drawing.Color.White;
            this.NbRata.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NbRata.Location = new System.Drawing.Point(117, 246);
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
            this.NbRata.Size = new System.Drawing.Size(64, 18);
            this.NbRata.TabIndex = 15;
            this.NbRata.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbRata.ValueChanged += new System.EventHandler(this.RaChange);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(117, 268);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(64, 1);
            this.panel7.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(114, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Rata";
            // 
            // NbErrorMax
            // 
            this.NbErrorMax.BackColor = System.Drawing.Color.SkyBlue;
            this.NbErrorMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbErrorMax.DecimalPlaces = 2;
            this.NbErrorMax.ForeColor = System.Drawing.Color.White;
            this.NbErrorMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NbErrorMax.Location = new System.Drawing.Point(18, 246);
            this.NbErrorMax.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbErrorMax.Name = "NbErrorMax";
            this.NbErrorMax.Size = new System.Drawing.Size(64, 18);
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
            this.NbIteracion.BackColor = System.Drawing.Color.SkyBlue;
            this.NbIteracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbIteracion.ForeColor = System.Drawing.Color.White;
            this.NbIteracion.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NbIteracion.Location = new System.Drawing.Point(18, 164);
            this.NbIteracion.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NbIteracion.Name = "NbIteracion";
            this.NbIteracion.Size = new System.Drawing.Size(163, 18);
            this.NbIteracion.TabIndex = 11;
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
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(18, 268);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(64, 1);
            this.panel5.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Error máx";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(18, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 1);
            this.panel4.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número de iteraciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Neuronas";
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Alberto Rojas Guerra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Javier Cardenas Salcedo";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(980, 520);
            this.Controls.Add(this.Embebed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Opacity = 0.98D;
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbRata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbErrorMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbIteracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Embebed;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown NbErrorMax;
        private System.Windows.Forms.NumericUpDown NbIteracion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.NumericUpDown NbRata;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSimulation;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button BtnPausa;
        private System.Windows.Forms.Button BtnReiniciar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox TbFuncion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox TbNeuronas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

