namespace AppPDI
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btApplyRed = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeCinzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminosityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularNivelDeCinzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.melhorarContrasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqrtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efeitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espelhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.button6 = new System.Windows.Forms.Button();
            this.destinoPictureBox = new System.Windows.Forms.PictureBox();
            this.originImagePictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imagem de Origem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Imagem de Destino:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(15, 493);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(513, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickFrequency = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Red (R)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Green (G)";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(15, 544);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(513, 45);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.TickFrequency = 8;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Blue (B)";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(15, 594);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(513, 45);
            this.trackBar3.TabIndex = 10;
            this.trackBar3.TickFrequency = 8;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Aplicar RGB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 579);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Estado";
            // 
            // btApplyRed
            // 
            this.btApplyRed.AutoSize = true;
            this.btApplyRed.BackColor = System.Drawing.Color.LightCoral;
            this.btApplyRed.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btApplyRed.FlatAppearance.BorderSize = 5;
            this.btApplyRed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btApplyRed.Location = new System.Drawing.Point(219, 472);
            this.btApplyRed.Name = "btApplyRed";
            this.btApplyRed.Size = new System.Drawing.Size(75, 27);
            this.btApplyRed.TabIndex = 16;
            this.btApplyRed.Text = "Aplicar R";
            this.btApplyRed.UseVisualStyleBackColor = false;
            this.btApplyRed.Click += new System.EventHandler(this.btApplyRed_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGreen;
            this.button4.Location = new System.Drawing.Point(219, 523);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Aplicar G";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.Location = new System.Drawing.Point(219, 574);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Aplicar B";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(15, 630);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 44);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(295, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(47, 17);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Blue";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(158, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Green (G)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(30, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Red (R)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrchid;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrosToolStripMenuItem,
            this.efeitosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1143, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escalaDeCinzaToolStripMenuItem,
            this.calcularNivelDeCinzaToolStripMenuItem,
            this.thresholdToolStripMenuItem,
            this.melhorarContrasteToolStripMenuItem});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // escalaDeCinzaToolStripMenuItem
            // 
            this.escalaDeCinzaToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.escalaDeCinzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightnessToolStripMenuItem,
            this.avgToolStripMenuItem,
            this.luminosityToolStripMenuItem});
            this.escalaDeCinzaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.escalaDeCinzaToolStripMenuItem.Name = "escalaDeCinzaToolStripMenuItem";
            this.escalaDeCinzaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.escalaDeCinzaToolStripMenuItem.Text = "Escala de Cinza";
            // 
            // lightnessToolStripMenuItem
            // 
            this.lightnessToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.lightnessToolStripMenuItem.Name = "lightnessToolStripMenuItem";
            this.lightnessToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.lightnessToolStripMenuItem.Text = "Lightness";
            this.lightnessToolStripMenuItem.Click += new System.EventHandler(this.lightnessToolStripMenuItem_Click);
            // 
            // avgToolStripMenuItem
            // 
            this.avgToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.avgToolStripMenuItem.Name = "avgToolStripMenuItem";
            this.avgToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.avgToolStripMenuItem.Text = "Avg";
            this.avgToolStripMenuItem.Click += new System.EventHandler(this.avgToolStripMenuItem_Click);
            // 
            // luminosityToolStripMenuItem
            // 
            this.luminosityToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.luminosityToolStripMenuItem.Name = "luminosityToolStripMenuItem";
            this.luminosityToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.luminosityToolStripMenuItem.Text = "Luminosity";
            this.luminosityToolStripMenuItem.Click += new System.EventHandler(this.luminosityToolStripMenuItem_Click);
            // 
            // calcularNivelDeCinzaToolStripMenuItem
            // 
            this.calcularNivelDeCinzaToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.calcularNivelDeCinzaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.calcularNivelDeCinzaToolStripMenuItem.Name = "calcularNivelDeCinzaToolStripMenuItem";
            this.calcularNivelDeCinzaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.calcularNivelDeCinzaToolStripMenuItem.Text = "Negativo da Imagem";
            this.calcularNivelDeCinzaToolStripMenuItem.Click += new System.EventHandler(this.calcularNivelDeCinzaToolStripMenuItem_Click);
            // 
            // thresholdToolStripMenuItem
            // 
            this.thresholdToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.thresholdToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.thresholdToolStripMenuItem.Name = "thresholdToolStripMenuItem";
            this.thresholdToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.thresholdToolStripMenuItem.Text = "Threshold";
            this.thresholdToolStripMenuItem.Click += new System.EventHandler(this.thresholdToolStripMenuItem_Click);
            // 
            // melhorarContrasteToolStripMenuItem
            // 
            this.melhorarContrasteToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.melhorarContrasteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.expToolStripMenuItem,
            this.sqrtToolStripMenuItem});
            this.melhorarContrasteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.melhorarContrasteToolStripMenuItem.Name = "melhorarContrasteToolStripMenuItem";
            this.melhorarContrasteToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.melhorarContrasteToolStripMenuItem.Text = "Melhorar Contraste";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.logToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // expToolStripMenuItem
            // 
            this.expToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.expToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.expToolStripMenuItem.Name = "expToolStripMenuItem";
            this.expToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.expToolStripMenuItem.Text = "Exp";
            this.expToolStripMenuItem.Click += new System.EventHandler(this.expToolStripMenuItem_Click);
            // 
            // sqrtToolStripMenuItem
            // 
            this.sqrtToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.sqrtToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sqrtToolStripMenuItem.Name = "sqrtToolStripMenuItem";
            this.sqrtToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.sqrtToolStripMenuItem.Text = "Sqrt";
            this.sqrtToolStripMenuItem.Click += new System.EventHandler(this.sqrtToolStripMenuItem_Click);
            // 
            // efeitosToolStripMenuItem
            // 
            this.efeitosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.espelhamentoToolStripMenuItem});
            this.efeitosToolStripMenuItem.Name = "efeitosToolStripMenuItem";
            this.efeitosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.efeitosToolStripMenuItem.Text = "Efeitos";
            // 
            // espelhamentoToolStripMenuItem
            // 
            this.espelhamentoToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.espelhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.espelhamentoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.espelhamentoToolStripMenuItem.Name = "espelhamentoToolStripMenuItem";
            this.espelhamentoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.espelhamentoToolStripMenuItem.Text = "Espelhamento";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.horizontalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.verticalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkOrchid;
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(618, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 53);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fonte da Imagem:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(91, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Destino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Origem";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.chart1.Images;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(618, 552);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(409, 116);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.Image = global::AppPDI.Properties.Resources.save;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(1033, 552);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 52);
            this.button6.TabIndex = 24;
            this.button6.Text = "Salvar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // destinoPictureBox
            // 
            this.destinoPictureBox.AccessibleName = "destinoPictureBox";
            this.destinoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.destinoPictureBox.Image = global::AppPDI.Properties.Resources.lena;
            this.destinoPictureBox.Location = new System.Drawing.Point(618, 40);
            this.destinoPictureBox.Name = "destinoPictureBox";
            this.destinoPictureBox.Size = new System.Drawing.Size(513, 426);
            this.destinoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.destinoPictureBox.TabIndex = 4;
            this.destinoPictureBox.TabStop = false;
            // 
            // originImagePictureBox
            // 
            this.originImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.originImagePictureBox.Image = global::AppPDI.Properties.Resources.lena;
            this.originImagePictureBox.Location = new System.Drawing.Point(15, 40);
            this.originImagePictureBox.Name = "originImagePictureBox";
            this.originImagePictureBox.Size = new System.Drawing.Size(512, 426);
            this.originImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originImagePictureBox.TabIndex = 1;
            this.originImagePictureBox.TabStop = false;
            this.originImagePictureBox.Click += new System.EventHandler(this.originImagePictureBox_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1033, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(1143, 686);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btApplyRed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinoPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.originImagePictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1159, 725);
            this.MinimumSize = new System.Drawing.Size(1159, 725);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App PDI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox originImagePictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox destinoPictureBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btApplyRed;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeCinzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luminosityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efeitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espelhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ToolStripMenuItem calcularNivelDeCinzaToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem thresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem melhorarContrasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem expToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sqrtToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

