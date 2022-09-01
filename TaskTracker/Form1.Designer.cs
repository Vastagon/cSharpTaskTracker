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
            this.components = new System.ComponentModel.Container();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextDescription = new System.Windows.Forms.TextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.DateCompleteBy = new System.Windows.Forms.DateTimePicker();
            this.LabelCompleteBy = new System.Windows.Forms.Label();
            this.TextQuery = new System.Windows.Forms.TextBox();
            this.ButtonQuery = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.coderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.coderBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridTasks = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coderBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coderBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coderBindingSource4)).BeginInit();
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
            // TextQuery
            // 
            this.TextQuery.Location = new System.Drawing.Point(337, 356);
            this.TextQuery.Name = "TextQuery";
            this.TextQuery.Size = new System.Drawing.Size(100, 23);
            this.TextQuery.TabIndex = 8;
            this.TextQuery.Text = "Query";
            // 
            // ButtonQuery
            // 
            this.ButtonQuery.Location = new System.Drawing.Point(362, 385);
            this.ButtonQuery.Name = "ButtonQuery";
            this.ButtonQuery.Size = new System.Drawing.Size(75, 23);
            this.ButtonQuery.TabIndex = 9;
            this.ButtonQuery.Text = "Submit";
            this.ButtonQuery.UseVisualStyleBackColor = true;
            this.ButtonQuery.Click += new System.EventHandler(this.ButtonQuery_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(TaskTracker.Form1);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(TaskTracker.Form1);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(497, 330);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 10;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // coderBindingSource
            // 
            this.coderBindingSource.DataSource = typeof(TaskTracker.Coder);
            // 
            // coderBindingSource1
            // 
            this.coderBindingSource1.DataSource = typeof(TaskTracker.Coder);
            // 
            // coderBindingSource2
            // 
            this.coderBindingSource2.DataSource = typeof(TaskTracker.Coder);
            // 
            // coderBindingSource3
            // 
            this.coderBindingSource3.DataSource = typeof(TaskTracker.Coder);
            // 
            // DataGridTasks
            // 
            this.DataGridTasks.AutoGenerateColumns = false;
            this.DataGridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.startedAtDataGridViewTextBoxColumn,
            this.finishByDataGridViewTextBoxColumn});
            this.DataGridTasks.DataSource = this.coderBindingSource4;
            this.DataGridTasks.Location = new System.Drawing.Point(440, 48);
            this.DataGridTasks.Name = "DataGridTasks";
            this.DataGridTasks.RowTemplate.Height = 25;
            this.DataGridTasks.Size = new System.Drawing.Size(326, 251);
            this.DataGridTasks.TabIndex = 11;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // startedAtDataGridViewTextBoxColumn
            // 
            this.startedAtDataGridViewTextBoxColumn.DataPropertyName = "startedAt";
            this.startedAtDataGridViewTextBoxColumn.HeaderText = "startedAt";
            this.startedAtDataGridViewTextBoxColumn.Name = "startedAtDataGridViewTextBoxColumn";
            // 
            // finishByDataGridViewTextBoxColumn
            // 
            this.finishByDataGridViewTextBoxColumn.DataPropertyName = "finishBy";
            this.finishByDataGridViewTextBoxColumn.HeaderText = "finishBy";
            this.finishByDataGridViewTextBoxColumn.Name = "finishByDataGridViewTextBoxColumn";
            // 
            // coderBindingSource4
            // 
            this.coderBindingSource4.DataSource = typeof(TaskTracker.Coder);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridTasks);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.ButtonQuery);
            this.Controls.Add(this.TextQuery);
            this.Controls.Add(this.LabelCompleteBy);
            this.Controls.Add(this.DateCompleteBy);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.TextDescription);
            this.Controls.Add(this.TextName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coderBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coderBindingSource4)).EndInit();
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
        private TextBox TextQuery;
        private Button ButtonQuery;
        private BindingSource form1BindingSource;
        private BindingSource form1BindingSource1;
        private Button ButtonConnect;
        private BindingSource coderBindingSource;
        private BindingSource coderBindingSource1;
        private BindingSource coderBindingSource2;
        private BindingSource coderBindingSource3;
        private DataGridView DataGridTasks;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startedAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finishByDataGridViewTextBoxColumn;
        private BindingSource coderBindingSource4;
    }


    public class Coder
    {
        public string name { get; set; }
        public string description { get; set; }
        public string startedAt { get; set; }
        public string finishBy { get; set; }
    }
}