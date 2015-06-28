namespace ExamForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.OutputRTB = new System.Windows.Forms.RichTextBox();
            this.FizzTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuzzTextBox = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HintLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionLabel.Location = new System.Drawing.Point(263, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.tableLayoutPanel1.SetRowSpan(this.DescriptionLabel, 2);
            this.DescriptionLabel.Size = new System.Drawing.Size(603, 50);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = resources.GetString("DescriptionLabel.Text");
            // 
            // OutputRTB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.OutputRTB, 3);
            this.OutputRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputRTB.Location = new System.Drawing.Point(3, 78);
            this.OutputRTB.Name = "OutputRTB";
            this.OutputRTB.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.OutputRTB, 3);
            this.OutputRTB.Size = new System.Drawing.Size(863, 402);
            this.OutputRTB.TabIndex = 4;
            this.OutputRTB.Text = "<Output should go here and each number should be on a new line>";
            // 
            // FizzTextBox
            // 
            this.FizzTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FizzTextBox.Location = new System.Drawing.Point(133, 28);
            this.FizzTextBox.Name = "FizzTextBox";
            this.FizzTextBox.Size = new System.Drawing.Size(124, 20);
            this.FizzTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buzz: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fizz: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BuzzTextBox
            // 
            this.BuzzTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuzzTextBox.Location = new System.Drawing.Point(133, 3);
            this.BuzzTextBox.Name = "BuzzTextBox";
            this.BuzzTextBox.Size = new System.Drawing.Size(124, 20);
            this.BuzzTextBox.TabIndex = 1;
            // 
            // GoButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.GoButton, 2);
            this.GoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoButton.Location = new System.Drawing.Point(3, 53);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(254, 19);
            this.GoButton.TabIndex = 3;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OutputRTB, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GoButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BuzzTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FizzTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.HintLabel, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(869, 483);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HintLabel.Location = new System.Drawing.Point(263, 50);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(603, 25);
            this.HintLabel.TabIndex = 7;
            this.HintLabel.Text = "Hint: You can double click on a control in the designer to create an event handle" +
    "r.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Exam";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.RichTextBox OutputRTB;
        private System.Windows.Forms.TextBox FizzTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BuzzTextBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label HintLabel;
    }
}

