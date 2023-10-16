namespace jeuDesLumière
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnOK = new Button();
            btnQuitter = new Button();
            groupBox1 = new GroupBox();
            rbTresRapide = new RadioButton();
            rbRapide = new RadioButton();
            rbSimple = new RadioButton();
            groupBox2 = new GroupBox();
            rbArrondis = new RadioButton();
            rbRctangles = new RadioButton();
            rbRonds = new RadioButton();
            btnC1 = new Button();
            btnC2 = new Button();
            btnC3 = new Button();
            btnC6 = new Button();
            btnC5 = new Button();
            btnC4 = new Button();
            btnC9 = new Button();
            btnC8 = new Button();
            btnC7 = new Button();
            tmrJeu = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.FromArgb(128, 255, 128);
            btnOK.Location = new Point(173, 271);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 43);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.BackColor = Color.FromArgb(255, 128, 128);
            btnQuitter.Location = new Point(11, 271);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(75, 43);
            btnQuitter.TabIndex = 1;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbTresRapide);
            groupBox1.Controls.Add(rbRapide);
            groupBox1.Controls.Add(rbSimple);
            groupBox1.Location = new Point(264, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(147, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Difficulté";
            // 
            // rbTresRapide
            // 
            rbTresRapide.AutoSize = true;
            rbTresRapide.Location = new Point(15, 72);
            rbTresRapide.Name = "rbTresRapide";
            rbTresRapide.Size = new Size(81, 19);
            rbTresRapide.TabIndex = 2;
            rbTresRapide.TabStop = true;
            rbTresRapide.Text = "Très rapide";
            rbTresRapide.UseVisualStyleBackColor = true;
            // 
            // rbRapide
            // 
            rbRapide.AutoSize = true;
            rbRapide.Location = new Point(15, 47);
            rbRapide.Name = "rbRapide";
            rbRapide.Size = new Size(61, 19);
            rbRapide.TabIndex = 1;
            rbRapide.TabStop = true;
            rbRapide.Text = "Rapide";
            rbRapide.UseVisualStyleBackColor = true;
            // 
            // rbSimple
            // 
            rbSimple.AutoSize = true;
            rbSimple.Location = new Point(15, 22);
            rbSimple.Name = "rbSimple";
            rbSimple.Size = new Size(61, 19);
            rbSimple.TabIndex = 0;
            rbSimple.TabStop = true;
            rbSimple.Text = "Simple";
            rbSimple.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbArrondis);
            groupBox2.Controls.Add(rbRctangles);
            groupBox2.Controls.Add(rbRonds);
            groupBox2.Location = new Point(264, 117);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(147, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Style";
            // 
            // rbArrondis
            // 
            rbArrondis.AutoSize = true;
            rbArrondis.Location = new Point(15, 72);
            rbArrondis.Name = "rbArrondis";
            rbArrondis.Size = new Size(70, 19);
            rbArrondis.TabIndex = 2;
            rbArrondis.TabStop = true;
            rbArrondis.Text = "Arrondis";
            rbArrondis.UseVisualStyleBackColor = true;
            // 
            // rbRctangles
            // 
            rbRctangles.AutoSize = true;
            rbRctangles.Location = new Point(15, 47);
            rbRctangles.Name = "rbRctangles";
            rbRctangles.Size = new Size(82, 19);
            rbRctangles.TabIndex = 1;
            rbRctangles.TabStop = true;
            rbRctangles.Text = "Rectangles";
            rbRctangles.UseVisualStyleBackColor = true;
            // 
            // rbRonds
            // 
            rbRonds.AutoSize = true;
            rbRonds.Location = new Point(15, 22);
            rbRonds.Name = "rbRonds";
            rbRonds.Size = new Size(58, 19);
            rbRonds.TabIndex = 0;
            rbRonds.TabStop = true;
            rbRonds.Text = "Ronds";
            rbRonds.UseVisualStyleBackColor = true;
            // 
            // btnC1
            // 
            btnC1.BackColor = Color.FromArgb(224, 224, 224);
            btnC1.Location = new Point(11, 11);
            btnC1.Name = "btnC1";
            btnC1.Size = new Size(75, 75);
            btnC1.TabIndex = 4;
            btnC1.UseVisualStyleBackColor = false;
            btnC1.Click += btnC1_Click;
            // 
            // btnC2
            // 
            btnC2.BackColor = Color.FromArgb(224, 224, 224);
            btnC2.Location = new Point(92, 11);
            btnC2.Name = "btnC2";
            btnC2.Size = new Size(75, 75);
            btnC2.TabIndex = 5;
            btnC2.UseVisualStyleBackColor = false;
            btnC2.Click += btnC2_Click;
            // 
            // btnC3
            // 
            btnC3.BackColor = Color.FromArgb(224, 224, 224);
            btnC3.Location = new Point(173, 11);
            btnC3.Name = "btnC3";
            btnC3.Size = new Size(75, 75);
            btnC3.TabIndex = 6;
            btnC3.UseVisualStyleBackColor = false;
            btnC3.Click += btnC3_Click;
            // 
            // btnC6
            // 
            btnC6.BackColor = Color.FromArgb(224, 224, 224);
            btnC6.Location = new Point(173, 92);
            btnC6.Name = "btnC6";
            btnC6.Size = new Size(75, 75);
            btnC6.TabIndex = 9;
            btnC6.UseVisualStyleBackColor = false;
            btnC6.Click += btnC6_Click;
            // 
            // btnC5
            // 
            btnC5.BackColor = Color.FromArgb(224, 224, 224);
            btnC5.Location = new Point(92, 92);
            btnC5.Name = "btnC5";
            btnC5.Size = new Size(75, 75);
            btnC5.TabIndex = 8;
            btnC5.UseVisualStyleBackColor = false;
            btnC5.Click += btnC5_Click;
            // 
            // btnC4
            // 
            btnC4.BackColor = Color.FromArgb(224, 224, 224);
            btnC4.Location = new Point(11, 92);
            btnC4.Name = "btnC4";
            btnC4.Size = new Size(75, 75);
            btnC4.TabIndex = 7;
            btnC4.UseVisualStyleBackColor = false;
            btnC4.Click += btnC4_Click;
            // 
            // btnC9
            // 
            btnC9.BackColor = Color.FromArgb(224, 224, 224);
            btnC9.Location = new Point(173, 171);
            btnC9.Name = "btnC9";
            btnC9.Size = new Size(75, 75);
            btnC9.TabIndex = 12;
            btnC9.UseVisualStyleBackColor = false;
            btnC9.Click += btnC9_Click;
            // 
            // btnC8
            // 
            btnC8.BackColor = Color.FromArgb(224, 224, 224);
            btnC8.Location = new Point(92, 171);
            btnC8.Name = "btnC8";
            btnC8.Size = new Size(75, 75);
            btnC8.TabIndex = 11;
            btnC8.UseVisualStyleBackColor = false;
            btnC8.Click += btnC8_Click;
            // 
            // btnC7
            // 
            btnC7.BackColor = Color.FromArgb(224, 224, 224);
            btnC7.Location = new Point(11, 171);
            btnC7.Name = "btnC7";
            btnC7.Size = new Size(75, 75);
            btnC7.TabIndex = 10;
            btnC7.UseVisualStyleBackColor = false;
            btnC7.Click += btnC7_Click;
            // 
            // tmrJeu
            // 
            tmrJeu.Interval = 1000;
            tmrJeu.Tick += tmrJeu_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 329);
            Controls.Add(btnC9);
            Controls.Add(btnC8);
            Controls.Add(btnC7);
            Controls.Add(btnC6);
            Controls.Add(btnC5);
            Controls.Add(btnC4);
            Controls.Add(btnC3);
            Controls.Add(btnC2);
            Controls.Add(btnC1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnQuitter);
            Controls.Add(btnOK);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOK;
        private Button btnQuitter;
        private GroupBox groupBox1;
        private RadioButton rbTresRapide;
        private RadioButton rbRapide;
        private RadioButton rbSimple;
        private GroupBox groupBox2;
        private RadioButton rbArrondis;
        private RadioButton rbRctangles;
        private RadioButton rbRonds;
        private Button btnC1;
        private Button btnC2;
        private Button btnC3;
        private Button btnC6;
        private Button btnC5;
        private Button btnC4;
        private Button btnC9;
        private Button btnC8;
        private Button btnC7;
        private System.Windows.Forms.Timer tmrJeu;
    }
}