
namespace TriangulationOnConicalSurfaceApp
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
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCalculatePoints = new System.Windows.Forms.Button();
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSegmentsNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCalculateSurfaceNormals = new System.Windows.Forms.Button();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.textBoxNormals = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSegmentsNum)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.DecimalPlaces = 1;
            this.numericUpDownHeight.Location = new System.Drawing.Point(12, 25);
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(167, 20);
            this.numericUpDownHeight.TabIndex = 0;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Высота конуса";
            // 
            // buttonCalculatePoints
            // 
            this.buttonCalculatePoints.Location = new System.Drawing.Point(531, 22);
            this.buttonCalculatePoints.Name = "buttonCalculatePoints";
            this.buttonCalculatePoints.Size = new System.Drawing.Size(224, 23);
            this.buttonCalculatePoints.TabIndex = 2;
            this.buttonCalculatePoints.Text = "Рассчитать точки";
            this.buttonCalculatePoints.UseVisualStyleBackColor = true;
            this.buttonCalculatePoints.Click += new System.EventHandler(this.buttonCalculatePoints_Click);
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.DecimalPlaces = 1;
            this.numericUpDownRadius.Location = new System.Drawing.Point(185, 25);
            this.numericUpDownRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(167, 20);
            this.numericUpDownRadius.TabIndex = 3;
            this.numericUpDownRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownSegmentsNum
            // 
            this.numericUpDownSegmentsNum.Location = new System.Drawing.Point(358, 25);
            this.numericUpDownSegmentsNum.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownSegmentsNum.Name = "numericUpDownSegmentsNum";
            this.numericUpDownSegmentsNum.Size = new System.Drawing.Size(167, 20);
            this.numericUpDownSegmentsNum.TabIndex = 4;
            this.numericUpDownSegmentsNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Радиус конуса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество сегментов";
            // 
            // buttonCalculateSurfaceNormals
            // 
            this.buttonCalculateSurfaceNormals.Enabled = false;
            this.buttonCalculateSurfaceNormals.Location = new System.Drawing.Point(761, 22);
            this.buttonCalculateSurfaceNormals.Name = "buttonCalculateSurfaceNormals";
            this.buttonCalculateSurfaceNormals.Size = new System.Drawing.Size(240, 23);
            this.buttonCalculateSurfaceNormals.TabIndex = 7;
            this.buttonCalculateSurfaceNormals.Text = "Рассчитать векторы нормали";
            this.buttonCalculateSurfaceNormals.UseVisualStyleBackColor = true;
            this.buttonCalculateSurfaceNormals.Click += new System.EventHandler(this.buttonCalculateSurfaceNormals_Click);
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(18, 57);
            this.textBoxPoints.Multiline = true;
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPoints.Size = new System.Drawing.Size(552, 448);
            this.textBoxPoints.TabIndex = 8;
            // 
            // textBoxNormals
            // 
            this.textBoxNormals.Location = new System.Drawing.Point(576, 57);
            this.textBoxNormals.Multiline = true;
            this.textBoxNormals.Name = "textBoxNormals";
            this.textBoxNormals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNormals.Size = new System.Drawing.Size(425, 448);
            this.textBoxNormals.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 517);
            this.Controls.Add(this.textBoxNormals);
            this.Controls.Add(this.textBoxPoints);
            this.Controls.Add(this.buttonCalculateSurfaceNormals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownSegmentsNum);
            this.Controls.Add(this.numericUpDownRadius);
            this.Controls.Add(this.buttonCalculatePoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownHeight);
            this.Name = "MainForm";
            this.Text = "Triangulation on a conical surface";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSegmentsNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalculatePoints;
        private System.Windows.Forms.NumericUpDown numericUpDownRadius;
        private System.Windows.Forms.NumericUpDown numericUpDownSegmentsNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCalculateSurfaceNormals;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.TextBox textBoxNormals;
    }
}

