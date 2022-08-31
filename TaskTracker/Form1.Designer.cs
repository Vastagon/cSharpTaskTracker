namespace TaskTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextDescription = new System.Windows.Forms.TextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.DateCompleteBy = new System.Windows.Forms.DateTimePicker();
            this.LabelCompleteBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(53, 48);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(264, 23);
            this.TextName.TabIndex = 0;
            this.TextName.TextChanged += new System.EventHandler(this.TextName_TextChanged);
            // 
            // TextDescription
            // 
            this.TextDescription.Location = new System.Drawing.Point(53, 121);
            this.TextDescription.Multiline = true;
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Size = new System.Drawing.Size(345, 178);
            this.TextDescription.TabIndex = 1;
            this.TextDescription.TextChanged += new System.EventHandler(this.TextDescription_TextChanged);
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(53, 103);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(67, 15);
            this.LabelDescription.TabIndex = 2;
            this.LabelDescription.Text = "Description";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(53, 30);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(39, 15);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "Name";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(622, 369);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(166, 69);
            this.ButtonSubmit.TabIndex = 4;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // DateCompleteBy
            // 
            this.DateCompleteBy.Location = new System.Drawing.Point(53, 356);
            this.DateCompleteBy.Name = "DateCompleteBy";
            this.DateCompleteBy.Size = new System.Drawing.Size(200, 23);
            this.DateCompleteBy.TabIndex = 5;
            // 
            // LabelCompleteBy
            // 
            this.LabelCompleteBy.AutoSize = true;
            this.LabelCompleteBy.Location = new System.Drawing.Point(53, 338);
            this.LabelCompleteBy.Name = "LabelCompleteBy";
            this.LabelCompleteBy.Size = new System.Drawing.Size(75, 15);
            this.LabelCompleteBy.TabIndex = 6;
            this.LabelCompleteBy.Text = "Complete By";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelCompleteBy);
            this.Controls.Add(this.DateCompleteBy);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.TextDescription);
            this.Controls.Add(this.TextName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextName;
        private TextBox TextDescription;
        private Label LabelDescription;
        private Label LabelName;
        private Button ButtonSubmit;
        private DateTimePicker DateCompleteBy;
        private Label LabelCompleteBy;
    }
}