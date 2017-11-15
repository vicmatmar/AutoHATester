namespace AutoHATester
{
    partial class Form1
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
            this.Go_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.COM_textBox = new System.Windows.Forms.TextBox();
            this.Color_textBox = new System.Windows.Forms.TextBox();
            this.Product_textBox = new System.Windows.Forms.TextBox();
            this.Status_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Go_button
            // 
            this.Go_button.Location = new System.Drawing.Point(137, 211);
            this.Go_button.Name = "Go_button";
            this.Go_button.Size = new System.Drawing.Size(75, 23);
            this.Go_button.TabIndex = 1;
            this.Go_button.Text = "Go";
            this.Go_button.UseVisualStyleBackColor = true;
            this.Go_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.COM_textBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Color_textBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Product_textBox, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 87);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // COM_textBox
            // 
            this.COM_textBox.Location = new System.Drawing.Point(62, 3);
            this.COM_textBox.Name = "COM_textBox";
            this.COM_textBox.Size = new System.Drawing.Size(100, 20);
            this.COM_textBox.TabIndex = 5;
            // 
            // Color_textBox
            // 
            this.Color_textBox.Location = new System.Drawing.Point(62, 29);
            this.Color_textBox.Name = "Color_textBox";
            this.Color_textBox.Size = new System.Drawing.Size(100, 20);
            this.Color_textBox.TabIndex = 6;
            // 
            // Product_textBox
            // 
            this.Product_textBox.Location = new System.Drawing.Point(62, 55);
            this.Product_textBox.Name = "Product_textBox";
            this.Product_textBox.Size = new System.Drawing.Size(175, 20);
            this.Product_textBox.TabIndex = 7;
            // 
            // Status_label
            // 
            this.Status_label.Location = new System.Drawing.Point(12, 119);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(439, 61);
            this.Status_label.TabIndex = 6;
            this.Status_label.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 301);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Go_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Go_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox COM_textBox;
        private System.Windows.Forms.TextBox Color_textBox;
        private System.Windows.Forms.TextBox Product_textBox;
        private System.Windows.Forms.Label Status_label;
    }
}

