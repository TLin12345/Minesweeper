
namespace MineSweeper
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.CancelClick = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.colLabel = new System.Windows.Forms.Label();
            this.mineLabel = new System.Windows.Forms.Label();
            this.rowLabel = new System.Windows.Forms.Label();
            this.mines = new System.Windows.Forms.NumericUpDown();
            this.col = new System.Windows.Forms.NumericUpDown();
            this.row = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.mines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.row)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelClick
            // 
            this.CancelClick.Location = new System.Drawing.Point(279, 210);
            this.CancelClick.Margin = new System.Windows.Forms.Padding(7);
            this.CancelClick.Name = "CancelClick";
            this.CancelClick.Size = new System.Drawing.Size(94, 30);
            this.CancelClick.TabIndex = 15;
            this.CancelClick.Text = "Cancel";
            this.CancelClick.UseVisualStyleBackColor = true;
            this.CancelClick.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(129, 210);
            this.OK.Margin = new System.Windows.Forms.Padding(7);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(92, 30);
            this.OK.TabIndex = 14;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // colLabel
            // 
            this.colLabel.AutoSize = true;
            this.colLabel.Location = new System.Drawing.Point(156, 98);
            this.colLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(25, 15);
            this.colLabel.TabIndex = 13;
            this.colLabel.Text = "Col";
            // 
            // mineLabel
            // 
            this.mineLabel.AutoSize = true;
            this.mineLabel.Location = new System.Drawing.Point(117, 156);
            this.mineLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.mineLabel.Name = "mineLabel";
            this.mineLabel.Size = new System.Drawing.Size(64, 15);
            this.mineLabel.TabIndex = 12;
            this.mineLabel.Text = "# of Mines";
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Location = new System.Drawing.Point(149, 40);
            this.rowLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(32, 15);
            this.rowLabel.TabIndex = 11;
            this.rowLabel.Text = "Row";
            // 
            // mines
            // 
            this.mines.Location = new System.Drawing.Point(188, 154);
            this.mines.Margin = new System.Windows.Forms.Padding(7);
            this.mines.Name = "mines";
            this.mines.Size = new System.Drawing.Size(128, 21);
            this.mines.TabIndex = 10;
            this.mines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // col
            // 
            this.col.Location = new System.Drawing.Point(188, 96);
            this.col.Margin = new System.Windows.Forms.Padding(7);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(128, 21);
            this.col.TabIndex = 9;
            this.col.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(188, 38);
            this.row.Margin = new System.Windows.Forms.Padding(7);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(128, 21);
            this.row.TabIndex = 8;
            this.row.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(514, 302);
            this.Controls.Add(this.CancelClick);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.colLabel);
            this.Controls.Add(this.mineLabel);
            this.Controls.Add(this.rowLabel);
            this.Controls.Add(this.mines);
            this.Controls.Add(this.col);
            this.Controls.Add(this.row);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Custom Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.mines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.row)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelClick;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label colLabel;
        private System.Windows.Forms.Label mineLabel;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.NumericUpDown mines;
        private System.Windows.Forms.NumericUpDown col;
        private System.Windows.Forms.NumericUpDown row;
    }
}