
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
            this.SuspendLayout();
            // 
            // MemoryDisplay
            // 
            this.MemoryDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.MemoryDisplay.Location = new System.Drawing.Point(3, 5);
            this.MemoryDisplay.Name = "MemoryDisplay";
            this.MemoryDisplay.ReadOnly = true;
            this.MemoryDisplay.Size = new System.Drawing.Size(403, 398);
            this.MemoryDisplay.TabIndex = 0;
            this.MemoryDisplay.Text = "";
            this.MemoryDisplay.TextChanged += new System.EventHandler(this.MemoryDisplay_TextChanged);
            // 
            // HistoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 437);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Memory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MemoryDisplay;
    }
}