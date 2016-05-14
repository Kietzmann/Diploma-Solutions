namespace DiplomaSolutions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Parameters = new System.Windows.Forms.TabPage();
            this.Results = new System.Windows.Forms.TabPage();
            this.CalculationScheme = new System.Windows.Forms.TabPage();
            this.CalculationMethod = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.CalculationMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Parameters);
            this.tabControl1.Controls.Add(this.Results);
            this.tabControl1.Controls.Add(this.CalculationScheme);
            this.tabControl1.Controls.Add(this.CalculationMethod);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(709, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // Parameters
            // 
            this.Parameters.Location = new System.Drawing.Point(4, 22);
            this.Parameters.Name = "Parameters";
            this.Parameters.Padding = new System.Windows.Forms.Padding(3);
            this.Parameters.Size = new System.Drawing.Size(701, 378);
            this.Parameters.TabIndex = 0;
            this.Parameters.Text = "Вхідні дані";
            this.Parameters.UseVisualStyleBackColor = true;
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(4, 22);
            this.Results.Name = "Results";
            this.Results.Padding = new System.Windows.Forms.Padding(3);
            this.Results.Size = new System.Drawing.Size(701, 378);
            this.Results.TabIndex = 1;
            this.Results.Text = "Результати розрахунку";
            this.Results.UseVisualStyleBackColor = true;
            // 
            // CalculationScheme
            // 
            this.CalculationScheme.Location = new System.Drawing.Point(4, 22);
            this.CalculationScheme.Name = "CalculationScheme";
            this.CalculationScheme.Size = new System.Drawing.Size(701, 378);
            this.CalculationScheme.TabIndex = 2;
            this.CalculationScheme.Text = "Схема розрахунку";
            this.CalculationScheme.UseVisualStyleBackColor = true;
            // 
            // CalculationMethod
            // 
            this.CalculationMethod.Controls.Add(this.tableLayoutPanel1);
            this.CalculationMethod.Location = new System.Drawing.Point(4, 22);
            this.CalculationMethod.Name = "CalculationMethod";
            this.CalculationMethod.Size = new System.Drawing.Size(701, 378);
            this.CalculationMethod.TabIndex = 3;
            this.CalculationMethod.Text = "Методика розрахунку";
            this.CalculationMethod.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 18;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 408);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.CalculationMethod.ResumeLayout(false);
            this.CalculationMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Parameters;
        private System.Windows.Forms.TabPage Results;
        private System.Windows.Forms.TabPage CalculationScheme;
        private System.Windows.Forms.TabPage CalculationMethod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

