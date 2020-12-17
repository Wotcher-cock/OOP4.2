namespace OOP4._2
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
            this.EnterB = new System.Windows.Forms.Button();
            this.NUP = new System.Windows.Forms.NumericUpDown();
            this.PB = new System.Windows.Forms.ProgressBar();
            this.TB = new System.Windows.Forms.TextBox();
            this.TrB = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.NUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrB)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterB
            // 
            this.EnterB.Location = new System.Drawing.Point(165, 93);
            this.EnterB.Name = "EnterB";
            this.EnterB.Size = new System.Drawing.Size(103, 23);
            this.EnterB.TabIndex = 0;
            this.EnterB.Text = "Вывод";
            this.EnterB.UseVisualStyleBackColor = true;
            this.EnterB.Click += new System.EventHandler(this.EnterB_Click);
            // 
            // NUP
            // 
            this.NUP.Location = new System.Drawing.Point(12, 96);
            this.NUP.Name = "NUP";
            this.NUP.Size = new System.Drawing.Size(120, 20);
            this.NUP.TabIndex = 1;
            this.NUP.ValueChanged += new System.EventHandler(this.NUP_ValueChanged);
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(95, 12);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(228, 23);
            this.PB.TabIndex = 2;
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(304, 96);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(120, 20);
            this.TB.TabIndex = 3;
            this.TB.Text = "1";
            this.TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_KeyDown);
            // 
            // TrB
            // 
            this.TrB.Location = new System.Drawing.Point(95, 163);
            this.TrB.Maximum = 100;
            this.TrB.Name = "TrB";
            this.TrB.Size = new System.Drawing.Size(228, 45);
            this.TrB.TabIndex = 4;
            this.TrB.Scroll += new System.EventHandler(this.TrB_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 220);
            this.Controls.Add(this.TrB);
            this.Controls.Add(this.TB);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.NUP);
            this.Controls.Add(this.EnterB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterB;
        private System.Windows.Forms.NumericUpDown NUP;
        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.TrackBar TrB;
    }
}

