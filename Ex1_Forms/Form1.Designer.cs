namespace Ex1_Forms
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LineATextBox = new System.Windows.Forms.TextBox();
            this.LineBTextBox = new System.Windows.Forms.TextBox();
            this.AddLineButton = new System.Windows.Forms.Button();
            this.AddParabolaButton = new System.Windows.Forms.Button();
            this.ParBTextBox = new System.Windows.Forms.TextBox();
            this.ParATextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ParCTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HyperButton = new System.Windows.Forms.Button();
            this.HyperBTextBox = new System.Windows.Forms.TextBox();
            this.HyperATextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ResultButton = new System.Windows.Forms.Button();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(369, 206);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddLineButton);
            this.tabPage1.Controls.Add(this.LineBTextBox);
            this.tabPage1.Controls.Add(this.LineATextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(361, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Прямая";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ParCTextBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.AddParabolaButton);
            this.tabPage2.Controls.Add(this.ParBTextBox);
            this.tabPage2.Controls.Add(this.ParATextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(361, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Парабола";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.HyperButton);
            this.tabPage3.Controls.Add(this.HyperBTextBox);
            this.tabPage3.Controls.Add(this.HyperATextBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(361, 180);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Гипербола";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите коэфициент A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите коэфициент B:";
            // 
            // LineATextBox
            // 
            this.LineATextBox.Location = new System.Drawing.Point(140, 16);
            this.LineATextBox.Name = "LineATextBox";
            this.LineATextBox.Size = new System.Drawing.Size(100, 20);
            this.LineATextBox.TabIndex = 2;
            // 
            // LineBTextBox
            // 
            this.LineBTextBox.Location = new System.Drawing.Point(140, 43);
            this.LineBTextBox.Name = "LineBTextBox";
            this.LineBTextBox.Size = new System.Drawing.Size(100, 20);
            this.LineBTextBox.TabIndex = 3;
            // 
            // AddLineButton
            // 
            this.AddLineButton.Location = new System.Drawing.Point(11, 84);
            this.AddLineButton.Name = "AddLineButton";
            this.AddLineButton.Size = new System.Drawing.Size(75, 23);
            this.AddLineButton.TabIndex = 4;
            this.AddLineButton.Text = " Добавить";
            this.AddLineButton.UseVisualStyleBackColor = true;
            this.AddLineButton.Click += new System.EventHandler(this.AddLineButton_Click);
            // 
            // AddParabolaButton
            // 
            this.AddParabolaButton.Location = new System.Drawing.Point(11, 92);
            this.AddParabolaButton.Name = "AddParabolaButton";
            this.AddParabolaButton.Size = new System.Drawing.Size(75, 23);
            this.AddParabolaButton.TabIndex = 9;
            this.AddParabolaButton.Text = " Добавить";
            this.AddParabolaButton.UseVisualStyleBackColor = true;
            this.AddParabolaButton.Click += new System.EventHandler(this.AddParabolaButton_Click);
            // 
            // ParBTextBox
            // 
            this.ParBTextBox.Location = new System.Drawing.Point(140, 37);
            this.ParBTextBox.Name = "ParBTextBox";
            this.ParBTextBox.Size = new System.Drawing.Size(100, 20);
            this.ParBTextBox.TabIndex = 8;
            // 
            // ParATextBox
            // 
            this.ParATextBox.Location = new System.Drawing.Point(140, 10);
            this.ParATextBox.Name = "ParATextBox";
            this.ParATextBox.Size = new System.Drawing.Size(100, 20);
            this.ParATextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите коэфициент B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите коэфициент A:";
            // 
            // ParCTextBox
            // 
            this.ParCTextBox.Location = new System.Drawing.Point(140, 64);
            this.ParCTextBox.Name = "ParCTextBox";
            this.ParCTextBox.Size = new System.Drawing.Size(100, 20);
            this.ParCTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите коэфициент C:";
            // 
            // HyperButton
            // 
            this.HyperButton.Location = new System.Drawing.Point(11, 78);
            this.HyperButton.Name = "HyperButton";
            this.HyperButton.Size = new System.Drawing.Size(75, 23);
            this.HyperButton.TabIndex = 9;
            this.HyperButton.Text = " Добавить";
            this.HyperButton.UseVisualStyleBackColor = true;
            this.HyperButton.Click += new System.EventHandler(this.HyperButton_Click);
            // 
            // HyperBTextBox
            // 
            this.HyperBTextBox.Location = new System.Drawing.Point(140, 37);
            this.HyperBTextBox.Name = "HyperBTextBox";
            this.HyperBTextBox.Size = new System.Drawing.Size(100, 20);
            this.HyperBTextBox.TabIndex = 8;
            // 
            // HyperATextBox
            // 
            this.HyperATextBox.Location = new System.Drawing.Point(140, 10);
            this.HyperATextBox.Name = "HyperATextBox";
            this.HyperATextBox.Size = new System.Drawing.Size(100, 20);
            this.HyperATextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Введите коэфициент B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Введите коэфициент A:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.XTextBox);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.ResultButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(361, 180);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Результат";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(8, 48);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(75, 23);
            this.ResultButton.TabIndex = 6;
            this.ResultButton.Text = "Результат";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(106, 16);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(100, 20);
            this.XTextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Введите точку X:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 206);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button AddLineButton;
        private System.Windows.Forms.TextBox LineBTextBox;
        private System.Windows.Forms.TextBox LineATextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ParCTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddParabolaButton;
        private System.Windows.Forms.TextBox ParBTextBox;
        private System.Windows.Forms.TextBox ParATextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button HyperButton;
        private System.Windows.Forms.TextBox HyperBTextBox;
        private System.Windows.Forms.TextBox HyperATextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ResultButton;
    }
}

