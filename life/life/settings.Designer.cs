
namespace life
{
    partial class setting
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
            this.huntersDensity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.density = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.cellsDeathNeigbours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cellsLifeNeighbours = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.huntersDeathNeighbour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.huntersLifeNeighbours = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.huntersCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.preyCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.recommendBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.huntersDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.density)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsDeathNeigbours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsLifeNeighbours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huntersDeathNeighbour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huntersLifeNeighbours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huntersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyCount)).BeginInit();
            this.SuspendLayout();
            // 
            // huntersDensity
            // 
            this.huntersDensity.Location = new System.Drawing.Point(12, 57);
            this.huntersDensity.Name = "huntersDensity";
            this.huntersDensity.Size = new System.Drawing.Size(68, 20);
            this.huntersDensity.TabIndex = 17;
            this.huntersDensity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "плотность охотников";
            // 
            // density
            // 
            this.density.Location = new System.Drawing.Point(12, 23);
            this.density.Name = "density";
            this.density.Size = new System.Drawing.Size(68, 20);
            this.density.TabIndex = 15;
            this.density.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "плотность добычи";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 342);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(109, 36);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cellsDeathNeigbours
            // 
            this.cellsDeathNeigbours.Location = new System.Drawing.Point(12, 137);
            this.cellsDeathNeigbours.Name = "cellsDeathNeigbours";
            this.cellsDeathNeigbours.Size = new System.Drawing.Size(68, 20);
            this.cellsDeathNeigbours.TabIndex = 22;
            this.cellsDeathNeigbours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "кол-во соседей для гибели клетки";
            // 
            // cellsLifeNeighbours
            // 
            this.cellsLifeNeighbours.Location = new System.Drawing.Point(12, 95);
            this.cellsLifeNeighbours.Name = "cellsLifeNeighbours";
            this.cellsLifeNeighbours.Size = new System.Drawing.Size(68, 20);
            this.cellsLifeNeighbours.TabIndex = 20;
            this.cellsLifeNeighbours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "кол-во соседей для зарождения жизни клетки";
            // 
            // huntersDeathNeighbour
            // 
            this.huntersDeathNeighbour.Location = new System.Drawing.Point(12, 265);
            this.huntersDeathNeighbour.Name = "huntersDeathNeighbour";
            this.huntersDeathNeighbour.Size = new System.Drawing.Size(68, 20);
            this.huntersDeathNeighbour.TabIndex = 26;
            this.huntersDeathNeighbour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "кол-во соседей для гибели охотника";
            // 
            // huntersLifeNeighbours
            // 
            this.huntersLifeNeighbours.Location = new System.Drawing.Point(12, 223);
            this.huntersLifeNeighbours.Name = "huntersLifeNeighbours";
            this.huntersLifeNeighbours.Size = new System.Drawing.Size(68, 20);
            this.huntersLifeNeighbours.TabIndex = 24;
            this.huntersLifeNeighbours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "кол-во соседей для зарождения охотника";
            // 
            // huntersCount
            // 
            this.huntersCount.Location = new System.Drawing.Point(12, 183);
            this.huntersCount.Name = "huntersCount";
            this.huntersCount.Size = new System.Drawing.Size(68, 20);
            this.huntersCount.TabIndex = 28;
            this.huntersCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "кол-во охотников для гибели клетки";
            // 
            // preyCount
            // 
            this.preyCount.Location = new System.Drawing.Point(12, 306);
            this.preyCount.Name = "preyCount";
            this.preyCount.Size = new System.Drawing.Size(68, 20);
            this.preyCount.TabIndex = 30;
            this.preyCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "кол-во добычи для гибели охотника";
            // 
            // recommendBtn
            // 
            this.recommendBtn.Location = new System.Drawing.Point(171, 342);
            this.recommendBtn.Name = "recommendBtn";
            this.recommendBtn.Size = new System.Drawing.Size(109, 36);
            this.recommendBtn.TabIndex = 31;
            this.recommendBtn.Text = "оптимальные значения";
            this.recommendBtn.UseVisualStyleBackColor = true;
            this.recommendBtn.Click += new System.EventHandler(this.recommendBtn_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 387);
            this.Controls.Add(this.recommendBtn);
            this.Controls.Add(this.preyCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.huntersCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.huntersDeathNeighbour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.huntersLifeNeighbours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cellsDeathNeigbours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cellsLifeNeighbours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.huntersDensity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.density);
            this.Controls.Add(this.label2);
            this.Name = "setting";
            this.Text = "setting";
            ((System.ComponentModel.ISupportInitialize)(this.huntersDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.density)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsDeathNeigbours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsLifeNeighbours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huntersDeathNeighbour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huntersLifeNeighbours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huntersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown huntersDensity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown density;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.NumericUpDown cellsDeathNeigbours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cellsLifeNeighbours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown huntersDeathNeighbour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown huntersLifeNeighbours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown huntersCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown preyCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button recommendBtn;
    }
}