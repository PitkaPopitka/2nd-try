
namespace life
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.edge = new System.Windows.Forms.CheckBox();
            this.delay = new System.Windows.Forms.TextBox();
            this.stop_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.resolution = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel1.Controls.Add(this.settingsBtn);
            this.splitContainer1.Panel1.Controls.Add(this.save_btn);
            this.splitContainer1.Panel1.Controls.Add(this.edge);
            this.splitContainer1.Panel1.Controls.Add(this.delay);
            this.splitContainer1.Panel1.Controls.Add(this.stop_btn);
            this.splitContainer1.Panel1.Controls.Add(this.start_btn);
            this.splitContainer1.Panel1.Controls.Add(this.resolution);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(917, 508);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 0;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(13, 361);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(121, 42);
            this.settingsBtn.TabIndex = 13;
            this.settingsBtn.Text = "настройки";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(13, 450);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(119, 44);
            this.save_btn.TabIndex = 10;
            this.save_btn.Text = "сохранить изображение";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // edge
            // 
            this.edge.AutoSize = true;
            this.edge.Location = new System.Drawing.Point(13, 224);
            this.edge.Name = "edge";
            this.edge.Size = new System.Drawing.Size(93, 17);
            this.edge.TabIndex = 9;
            this.edge.Text = "грани клеток";
            this.edge.UseVisualStyleBackColor = true;
            this.edge.CheckedChanged += new System.EventHandler(this.edge_CheckedChanged);
            // 
            // delay
            // 
            this.delay.Location = new System.Drawing.Point(3, 59);
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(69, 20);
            this.delay.TabIndex = 8;
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(13, 315);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(121, 40);
            this.stop_btn.TabIndex = 7;
            this.stop_btn.Text = "стоп";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(13, 247);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(119, 43);
            this.start_btn.TabIndex = 6;
            this.start_btn.Text = "старт";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // resolution
            // 
            this.resolution.Location = new System.Drawing.Point(3, 20);
            this.resolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(68, 20);
            this.resolution.TabIndex = 3;
            this.resolution.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "задержка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "разрешение";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 504);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 508);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.NumericUpDown resolution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox delay;
        private System.Windows.Forms.CheckBox edge;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button settingsBtn;
    }
}

