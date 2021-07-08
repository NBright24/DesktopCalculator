
namespace Desktop_Calculator
{
    partial class HistoryWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryWindow));
            this.MemoryDisplay = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearBTN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClearBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // MemoryDisplay
            // 
            this.MemoryDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.MemoryDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MemoryDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MemoryDisplay.Location = new System.Drawing.Point(12, 12);
            this.MemoryDisplay.Name = "MemoryDisplay";
            this.MemoryDisplay.ReadOnly = true;
            this.MemoryDisplay.Size = new System.Drawing.Size(385, 391);
            this.MemoryDisplay.TabIndex = 0;
            this.MemoryDisplay.Text = "There\'s no history yet";
            this.MemoryDisplay.TextChanged += new System.EventHandler(this.MemoryDisplay_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearBTN
            // 
            this.ClearBTN.Image = ((System.Drawing.Image)(resources.GetObject("ClearBTN.Image")));
            this.ClearBTN.Location = new System.Drawing.Point(372, 409);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(25, 25);
            this.ClearBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClearBTN.TabIndex = 2;
            this.ClearBTN.TabStop = false;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // HistoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 437);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MemoryDisplay);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoryWindow";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            ((System.ComponentModel.ISupportInitialize)(this.ClearBTN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox MemoryDisplay;
        private System.Windows.Forms.PictureBox ClearBTN;
    }
}