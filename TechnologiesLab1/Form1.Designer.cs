namespace TechnologiesLab1
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
            this.labelN = new System.Windows.Forms.Label();
            this.labelThread = new System.Windows.Forms.Label();
            this.textBoxCountOfIntervals = new System.Windows.Forms.TextBox();
            this.textBoxThreads = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelN.Location = new System.Drawing.Point(12, 9);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(270, 25);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "Введіть кількість інтервалів";
            // 
            // labelThread
            // 
            this.labelThread.AutoSize = true;
            this.labelThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelThread.Location = new System.Drawing.Point(12, 52);
            this.labelThread.Name = "labelThread";
            this.labelThread.Size = new System.Drawing.Size(244, 25);
            this.labelThread.TabIndex = 1;
            this.labelThread.Text = "Введіть кількість потоків";
            // 
            // textBoxCountOfIntervals
            // 
            this.textBoxCountOfIntervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCountOfIntervals.Location = new System.Drawing.Point(288, 6);
            this.textBoxCountOfIntervals.Name = "textBoxCountOfIntervals";
            this.textBoxCountOfIntervals.Size = new System.Drawing.Size(500, 30);
            this.textBoxCountOfIntervals.TabIndex = 2;
            // 
            // textBoxThreads
            // 
            this.textBoxThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxThreads.Location = new System.Drawing.Point(262, 47);
            this.textBoxThreads.Name = "textBoxThreads";
            this.textBoxThreads.Size = new System.Drawing.Size(526, 30);
            this.textBoxThreads.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCalculate.Location = new System.Drawing.Point(308, 100);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(159, 55);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Обчислити";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelResult.Location = new System.Drawing.Point(257, 214);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 25);
            this.labelResult.TabIndex = 5;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTime.Location = new System.Drawing.Point(244, 276);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 25);
            this.labelTime.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxThreads);
            this.Controls.Add(this.textBoxCountOfIntervals);
            this.Controls.Add(this.labelThread);
            this.Controls.Add(this.labelN);
            this.Name = "Form1";
            this.Text = "Технології розподілених систем та паралельних обчислень 1 лабараторна";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelThread;
        private System.Windows.Forms.TextBox textBoxCountOfIntervals;
        private System.Windows.Forms.TextBox textBoxThreads;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelTime;
    }
}

