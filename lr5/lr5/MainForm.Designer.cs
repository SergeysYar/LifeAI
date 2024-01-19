namespace lr5
{
    partial class MainForm
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
            this.worldPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.outRichTextBox = new System.Windows.Forms.RichTextBox();
            this.iterateOnceButton = new System.Windows.Forms.Button();
            this.IterationFive = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxPlant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // worldPictureBox
            // 
            this.worldPictureBox.Location = new System.Drawing.Point(12, 12);
            this.worldPictureBox.Name = "worldPictureBox";
            this.worldPictureBox.Size = new System.Drawing.Size(772, 447);
            this.worldPictureBox.TabIndex = 0;
            this.worldPictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 465);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(138, 58);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Инициализация";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // outRichTextBox
            // 
            this.outRichTextBox.Location = new System.Drawing.Point(791, 13);
            this.outRichTextBox.Name = "outRichTextBox";
            this.outRichTextBox.Size = new System.Drawing.Size(168, 446);
            this.outRichTextBox.TabIndex = 3;
            this.outRichTextBox.Text = "";
            // 
            // iterateOnceButton
            // 
            this.iterateOnceButton.Location = new System.Drawing.Point(332, 465);
            this.iterateOnceButton.Name = "iterateOnceButton";
            this.iterateOnceButton.Size = new System.Drawing.Size(87, 58);
            this.iterateOnceButton.TabIndex = 9;
            this.iterateOnceButton.Text = "Одно нажатие";
            this.iterateOnceButton.UseVisualStyleBackColor = true;
            this.iterateOnceButton.Click += new System.EventHandler(this.iterateOnceButton_Click);
            // 
            // IterationFive
            // 
            this.IterationFive.Location = new System.Drawing.Point(531, 465);
            this.IterationFive.Name = "IterationFive";
            this.IterationFive.Size = new System.Drawing.Size(87, 58);
            this.IterationFive.TabIndex = 10;
            this.IterationFive.Text = "Несколько нажатий";
            this.IterationFive.UseVisualStyleBackColor = true;
            this.IterationFive.Click += new System.EventHandler(this.IterationFive_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(425, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPlant
            // 
            this.textBoxPlant.Location = new System.Drawing.Point(684, 465);
            this.textBoxPlant.Name = "textBoxPlant";
            this.textBoxPlant.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlant.TabIndex = 12;
            this.textBoxPlant.Text = "200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(799, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Расстения";
            // 
            // textBoxHB
            // 
            this.textBoxHB.Location = new System.Drawing.Point(684, 493);
            this.textBoxHB.Name = "textBoxHB";
            this.textBoxHB.Size = new System.Drawing.Size(100, 22);
            this.textBoxHB.TabIndex = 14;
            this.textBoxHB.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(799, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Травоядные";
            // 
            // textBoxPD
            // 
            this.textBoxPD.Location = new System.Drawing.Point(684, 521);
            this.textBoxPD.Name = "textBoxPD";
            this.textBoxPD.Size = new System.Drawing.Size(100, 22);
            this.textBoxPD.TabIndex = 16;
            this.textBoxPD.Text = "200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(799, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Хищники";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlant);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IterationFive);
            this.Controls.Add(this.iterateOnceButton);
            this.Controls.Add(this.outRichTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.worldPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №5";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worldPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox worldPictureBox;
        private System.Windows.Forms.Button startButton;
        public System.Windows.Forms.RichTextBox outRichTextBox;
        private System.Windows.Forms.Button iterateOnceButton;
        private System.Windows.Forms.Button IterationFive;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxPlant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPD;
        private System.Windows.Forms.Label label3;
    }
}

