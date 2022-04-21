namespace BloggersClient
{
    partial class fmMain
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
            this.dgvBloggers = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataManagerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bloggerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.btnNewBlogger = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloggers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloggerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBloggers
            // 
            this.dgvBloggers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBloggers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBloggers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBloggers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colPost});
            this.dgvBloggers.Location = new System.Drawing.Point(26, 46);
            this.dgvBloggers.Name = "dgvBloggers";
            this.dgvBloggers.RowTemplate.Height = 25;
            this.dgvBloggers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBloggers.Size = new System.Drawing.Size(343, 183);
            this.dgvBloggers.TabIndex = 0;
            this.dgvBloggers.SelectionChanged += new System.EventHandler(this.dgvBloggers_SelectionChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Идентификатор";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Имя";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPost
            // 
            this.colPost.DataPropertyName = "Post";
            this.colPost.HeaderText = "Пост";
            this.colPost.Name = "colPost";
            this.colPost.ReadOnly = true;
            // 
            // dataManagerBindingSource
            // 
            this.dataManagerBindingSource.DataSource = typeof(Bloggers.DataManager);
            // 
            // dataManagerBindingSource1
            // 
            this.dataManagerBindingSource1.DataSource = typeof(Bloggers.DataManager);
            // 
            // bloggerBindingSource
            // 
            this.bloggerBindingSource.DataSource = typeof(Bloggers.Models.Blogger);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(375, 46);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.PlaceholderText = "Введите Номер";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(129, 23);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.Tag = "Введите номер";
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxes_Changed);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(375, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Введите Имя";
            this.textBoxName.Size = new System.Drawing.Size(129, 23);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxes_Changed);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(375, 104);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.PlaceholderText = "Введите Пост";
            this.textBoxPost.Size = new System.Drawing.Size(129, 23);
            this.textBoxPost.TabIndex = 3;
            this.textBoxPost.TextChanged += new System.EventHandler(this.textBoxes_Changed);
            // 
            // btnNewBlogger
            // 
            this.btnNewBlogger.Location = new System.Drawing.Point(375, 17);
            this.btnNewBlogger.Name = "btnNewBlogger";
            this.btnNewBlogger.Size = new System.Drawing.Size(129, 23);
            this.btnNewBlogger.TabIndex = 4;
            this.btnNewBlogger.Text = "Новый блогер";
            this.btnNewBlogger.UseVisualStyleBackColor = true;
            this.btnNewBlogger.Click += new System.EventHandler(this.btnNewBlogger_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(294, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeleteBlogger_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(375, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 241);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewBlogger);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dgvBloggers);
            this.Name = "fmMain";
            this.Text = "fmMain";
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloggers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloggerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBloggers;
        private BindingSource dataManagerBindingSource;
        private BindingSource dataManagerBindingSource1;
        private BindingSource bloggerBindingSource;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private TextBox textBoxPost;
        private Button btnNewBlogger;
        private Button btnDelete;
        private Button btnSave;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPost;
    }
}