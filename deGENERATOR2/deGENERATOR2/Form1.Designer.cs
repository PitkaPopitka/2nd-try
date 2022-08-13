
namespace deGENERATOR2
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
            this.number = new System.Windows.Forms.Button();
            this.downL = new System.Windows.Forms.Button();
            this.upL = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.combination = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.copy = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.deGenerate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(12, 273);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(118, 49);
            this.number.TabIndex = 19;
            this.number.Text = "1";
            this.number.UseVisualStyleBackColor = true;
            this.number.Click += new System.EventHandler(this.number_Click);
            this.number.MouseHover += new System.EventHandler(this.number_MouseHover);
            // 
            // downL
            // 
            this.downL.Location = new System.Drawing.Point(12, 207);
            this.downL.Name = "downL";
            this.downL.Size = new System.Drawing.Size(118, 49);
            this.downL.TabIndex = 18;
            this.downL.Text = "q";
            this.downL.UseVisualStyleBackColor = true;
            this.downL.Click += new System.EventHandler(this.downL_Click);
            this.downL.MouseHover += new System.EventHandler(this.downL_MouseHover);
            // 
            // upL
            // 
            this.upL.Location = new System.Drawing.Point(12, 142);
            this.upL.Name = "upL";
            this.upL.Size = new System.Drawing.Size(118, 49);
            this.upL.TabIndex = 17;
            this.upL.Text = "Q";
            this.upL.UseVisualStyleBackColor = true;
            this.upL.Click += new System.EventHandler(this.upL_Click);
            this.upL.MouseHover += new System.EventHandler(this.upL_MouseHover);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(12, 76);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(118, 49);
            this.down.TabIndex = 16;
            this.down.Text = "a";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            this.down.MouseHover += new System.EventHandler(this.down_MouseHover);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(12, 12);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(118, 49);
            this.up.TabIndex = 15;
            this.up.Text = "A";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            this.up.MouseHover += new System.EventHandler(this.up_MouseHover);
            // 
            // combination
            // 
            this.combination.Location = new System.Drawing.Point(240, 34);
            this.combination.Name = "combination";
            this.combination.Size = new System.Drawing.Size(196, 20);
            this.combination.TabIndex = 14;
            this.combination.MouseHover += new System.EventHandler(this.combination_MouseHover);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(316, 8);
            this.quantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(120, 20);
            this.quantity.TabIndex = 13;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(512, 421);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(98, 49);
            this.copy.TabIndex = 12;
            this.copy.Text = "copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            this.copy.MouseHover += new System.EventHandler(this.copy_MouseHover);
            // 
            // result
            // 
            this.result.FormattingEnabled = true;
            this.result.Location = new System.Drawing.Point(442, 8);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(222, 407);
            this.result.TabIndex = 10;
            this.result.MouseHover += new System.EventHandler(this.result_MouseHover);
            // 
            // deGenerate
            // 
            this.deGenerate.Location = new System.Drawing.Point(316, 86);
            this.deGenerate.Name = "deGenerate";
            this.deGenerate.Size = new System.Drawing.Size(120, 39);
            this.deGenerate.TabIndex = 20;
            this.deGenerate.Text = "generate";
            this.deGenerate.UseVisualStyleBackColor = true;
            this.deGenerate.Click += new System.EventHandler(this.deGenerate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(316, 142);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(120, 39);
            this.clear.TabIndex = 21;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 490);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.deGenerate);
            this.Controls.Add(this.number);
            this.Controls.Add(this.downL);
            this.Controls.Add(this.upL);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.combination);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button number;
        private System.Windows.Forms.Button downL;
        private System.Windows.Forms.Button upL;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.TextBox combination;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.ListBox result;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button deGenerate;
        private System.Windows.Forms.Button clear;
    }
}

