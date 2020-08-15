namespace CursorTools
{
    partial class CursorTool
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CursorPositionLabel = new System.Windows.Forms.Label();
            this.CursorColorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.nonSelectableButton1 = new YourNamespace.NonSelectableButton();
            this.Measuring = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 106);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.CursorPositionLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CursorColorLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Measuring, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(176, 106);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // CursorPositionLabel
            // 
            this.CursorPositionLabel.AutoSize = true;
            this.CursorPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CursorPositionLabel.Location = new System.Drawing.Point(3, 0);
            this.CursorPositionLabel.Name = "CursorPositionLabel";
            this.CursorPositionLabel.Size = new System.Drawing.Size(170, 35);
            this.CursorPositionLabel.TabIndex = 1;
            this.CursorPositionLabel.Text = "Position: Not measured.";
            this.CursorPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CursorColorLabel
            // 
            this.CursorColorLabel.AutoSize = true;
            this.CursorColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CursorColorLabel.Location = new System.Drawing.Point(3, 35);
            this.CursorColorLabel.Name = "CursorColorLabel";
            this.CursorColorLabel.Size = new System.Drawing.Size(170, 35);
            this.CursorColorLabel.TabIndex = 0;
            this.CursorColorLabel.Text = "Color: Not measured.";
            this.CursorColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.HelpLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.nonSelectableButton1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(176, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(176, 106);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpLabel.Location = new System.Drawing.Point(3, 0);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(170, 51);
            this.HelpLabel.TabIndex = 0;
            this.HelpLabel.Text = "Press [SPACE] to measure!";
            this.HelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nonSelectableButton1
            // 
            this.nonSelectableButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nonSelectableButton1.Location = new System.Drawing.Point(3, 54);
            this.nonSelectableButton1.Name = "nonSelectableButton1";
            this.nonSelectableButton1.Size = new System.Drawing.Size(170, 49);
            this.nonSelectableButton1.TabIndex = 1;
            this.nonSelectableButton1.Text = "Copy Measurements";
            this.nonSelectableButton1.UseVisualStyleBackColor = true;
            this.nonSelectableButton1.Click += new System.EventHandler(this.nonSelectableButton1_Click);
            // 
            // Measuring
            // 
            this.Measuring.AutoSize = true;
            this.Measuring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Measuring.Location = new System.Drawing.Point(3, 70);
            this.Measuring.Name = "Measuring";
            this.Measuring.Size = new System.Drawing.Size(170, 36);
            this.Measuring.TabIndex = 2;
            this.Measuring.Text = "Measuring: False";
            this.Measuring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CursorTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 106);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CursorTool";
            this.Text = "Cursor Tools - by Enebz";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Label CursorPositionLabel;
        private System.Windows.Forms.Label CursorColorLabel;
        private YourNamespace.NonSelectableButton nonSelectableButton1;
        private System.Windows.Forms.Label Measuring;
    }
}

