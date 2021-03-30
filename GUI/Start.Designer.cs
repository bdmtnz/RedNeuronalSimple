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
            this.BtnPausa = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.NbErrorMax = new System.Windows.Forms.NumericUpDown();
            this.NbIteracion = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CbActivacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LbResultado = new System.Windows.Forms.Label();
            this.LbResutado = new System.Windows.Forms.Label();
            this.TbPatron = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSimulation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbRata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbErrorMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbIteracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.LbResultado);
            this.panel1.Controls.Add(this.LbResutado);
            this.panel1.Controls.Add(this.TbPatron);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 100);
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
            this.BtnPausa.Location = new System.Drawing.Point(65, 448);
            this.BtnPausa.Name = "BtnPausa";
            this.BtnPausa.Size = new System.Drawing.Size(30, 30);
            this.BtnPausa.TabIndex = 9;
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
            this.BtnIniciar.Location = new System.Drawing.Point(65, 448);
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
            this.button4.Location = new System.Drawing.Point(103, 448);
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
            this.BtnOpen.Location = new System.Drawing.Point(144, 448);
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
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gerson Moreno Castillo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Red neuronal";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.Location = new System.Drawing.Point(763, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = " X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Close);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(2, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 396);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel6.Controls.Add(this.LbEntrenado);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.LbSalidas);
            this.panel6.Controls.Add(this.LbPatrones);
            this.panel6.Controls.Add(this.LbEntradas);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(596, 20);
            this.panel6.TabIndex = 0;
            // 
            // LbEntrenado
            // 
            this.LbEntrenado.AutoSize = true;
            this.LbEntrenado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.LbEntrenado.ForeColor = System.Drawing.Color.White;
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
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(355, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Entrenado:";
            // 
            // LbSalidas
            // 
            this.LbSalidas.AutoSize = true;
            this.LbSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.LbSalidas.ForeColor = System.Drawing.Color.White;
            this.LbSalidas.Location = new System.Drawing.Point(555, 2);
            this.LbSalidas.Name = "LbSalidas";
            this.LbSalidas.Size = new System.Drawing.Size(15, 16);
            this.LbSalidas.TabIndex = 5;
            this.LbSalidas.Text = "#";
            // 
            // LbPatrones
            // 
            this.LbPatrones.AutoSize = true;
            this.LbPatrones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.LbPatrones.ForeColor = System.Drawing.Color.White;
            this.LbPatrones.Location = new System.Drawing.Point(247, 2);
            this.LbPatrones.Name = "LbPatrones";
            this.LbPatrones.Size = new System.Drawing.Size(15, 16);
            this.LbPatrones.TabIndex = 4;
            this.LbPatrones.Text = "#";
            // 
            // LbEntradas
            // 
            this.LbEntradas.AutoSize = true;
            this.LbEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.LbEntradas.ForeColor = System.Drawing.Color.White;
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
            this.label10.ForeColor = System.Drawing.Color.White;
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
            this.label9.ForeColor = System.Drawing.Color.White;
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
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Entradas: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel3.Controls.Add(this.BtnPausa);
            this.panel3.Controls.Add(this.NbRata);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.BtnSimulation);
            this.panel3.Controls.Add(this.BtnIniciar);
            this.panel3.Controls.Add(this.NbErrorMax);
            this.panel3.Controls.Add(this.NbIteracion);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.BtnOpen);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.CbActivacion);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(598, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 496);
            this.panel3.TabIndex = 2;
            // 
            // NbRata
            // 
            this.NbRata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.NbRata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbRata.DecimalPlaces = 10;
            this.NbRata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NbRata.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NbRata.Location = new System.Drawing.Point(18, 305);
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
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel7.Location = new System.Drawing.Point(18, 327);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(163, 1);
            this.panel7.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label11.Location = new System.Drawing.Point(15, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Rata de aprendizaje";
            // 
            // NbErrorMax
            // 
            this.NbErrorMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.NbErrorMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbErrorMax.DecimalPlaces = 10;
            this.NbErrorMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NbErrorMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NbErrorMax.Location = new System.Drawing.Point(18, 230);
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
            this.NbIteracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.NbIteracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbIteracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NbIteracion.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NbIteracion.Location = new System.Drawing.Point(18, 148);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel5.Location = new System.Drawing.Point(18, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(163, 1);
            this.panel5.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(15, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Error máximo permitido";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel4.Location = new System.Drawing.Point(18, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 1);
            this.panel4.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(15, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número de iteraciones";
            // 
            // CbActivacion
            // 
            this.CbActivacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.CbActivacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbActivacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbActivacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbActivacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CbActivacion.FormattingEnabled = true;
            this.CbActivacion.Location = new System.Drawing.Point(19, 379);
            this.CbActivacion.Name = "CbActivacion";
            this.CbActivacion.Size = new System.Drawing.Size(163, 24);
            this.CbActivacion.TabIndex = 4;
            this.CbActivacion.SelectedIndexChanged += new System.EventHandler(this.CambiarActivacion);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(15, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Función de activación";
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(24, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(549, 333);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // LbResultado
            // 
            this.LbResultado.AutoSize = true;
            this.LbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LbResultado.Location = new System.Drawing.Point(346, 72);
            this.LbResultado.Name = "LbResultado";
            this.LbResultado.Size = new System.Drawing.Size(20, 24);
            this.LbResultado.TabIndex = 25;
            this.LbResultado.Text = "?";
            // 
            // LbResutado
            // 
            this.LbResutado.AutoSize = true;
            this.LbResutado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResutado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LbResutado.Location = new System.Drawing.Point(246, 72);
            this.LbResutado.Name = "LbResutado";
            this.LbResutado.Size = new System.Drawing.Size(104, 24);
            this.LbResutado.TabIndex = 24;
            this.LbResutado.Text = "Resultado: ";
            // 
            // TbPatron
            // 
            this.TbPatron.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TbPatron.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbPatron.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPatron.ForeColor = System.Drawing.Color.White;
            this.TbPatron.Location = new System.Drawing.Point(250, 31);
            this.TbPatron.Name = "TbPatron";
            this.TbPatron.Size = new System.Drawing.Size(228, 22);
            this.TbPatron.TabIndex = 22;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel8.Location = new System.Drawing.Point(250, 59);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(228, 1);
            this.panel8.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(247, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Patron";
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
            this.BtnSimulation.Location = new System.Drawing.Point(29, 448);
            this.BtnSimulation.Name = "BtnSimulation";
            this.BtnSimulation.Size = new System.Drawing.Size(30, 30);
            this.BtnSimulation.TabIndex = 8;
            this.BtnSimulation.UseVisualStyleBackColor = true;
            this.BtnSimulation.Click += new System.EventHandler(this.Simular);
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
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbRata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbErrorMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbIteracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NbErrorMax;
        private System.Windows.Forms.NumericUpDown NbIteracion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbActivacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LbSalidas;
        private System.Windows.Forms.Label LbPatrones;
        private System.Windows.Forms.Label LbEntradas;
        private System.Windows.Forms.NumericUpDown NbRata;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button BtnPausa;
        private System.Windows.Forms.Label LbEntrenado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LbResultado;
        private System.Windows.Forms.Label LbResutado;
        private System.Windows.Forms.TextBox TbPatron;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSimulation;
    }
}

