namespace TaskTracker
{
    partial class Form2
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
            this.TextExpanded = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextExpanded
            // 
            this.TextExpanded.Location = new System.Drawing.Point(12, 60);
            this.TextExpanded.Multiline = true;
            this.TextExpanded.Name = "TextExpanded";
            this.TextExpanded.Size = new System.Drawing.Size(288, 183);
            this.TextExpanded.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 317);
            this.Controls.Add(this.TextExpanded);
            this.Name = "Form2";
            this.Text = "Expanded Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox TextExpanded;
    }
}