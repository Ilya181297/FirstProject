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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataManagerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bloggerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.InsertBlogger = new System.Windows.Forms.Button();
            this.DeleteBlogger = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloggerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colPost});
            this.dataGridView1.Location = new System.Drawing.Point(26, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Номер";
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
            this.textBoxId.Location = new System.Drawing.Point(391, 37);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.PlaceholderText = "Введите Номер";
            this.textBoxId.Size = new System.Drawing.Size(100, 23);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.Tag = "Введите номер";
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged_1);
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(391, 66);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Введите Имя";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxId_TextChanged_1);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(391, 95);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.PlaceholderText = "Введите Пост";
            this.textBoxPost.Size = new System.Drawing.Size(100, 23);
            this.textBoxPost.TabIndex = 3;
            this.textBoxPost.TextChanged += new System.EventHandler(this.textBoxId_TextChanged_1);
            // 
            // InsertBlogger
            // 
            this.InsertBlogger.Location = new System.Drawing.Point(391, 124);
            this.InsertBlogger.Name = "InsertBlogger";
            this.InsertBlogger.Size = new System.Drawing.Size(75, 23);
            this.InsertBlogger.TabIndex = 4;
            this.InsertBlogger.Text = "Добавить";
            this.InsertBlogger.UseVisualStyleBackColor = true;
            this.InsertBlogger.Click += new System.EventHandler(this.InsertBlogger_Click);
            // 
            // DeleteBlogger
            // 
            this.DeleteBlogger.Location = new System.Drawing.Point(26, 12);
            this.DeleteBlogger.Name = "DeleteBlogger";
            this.DeleteBlogger.Size = new System.Drawing.Size(75, 23);
            this.DeleteBlogger.TabIndex = 5;
            this.DeleteBlogger.Text = "Удалить";
            this.DeleteBlogger.UseVisualStyleBackColor = true;
            this.DeleteBlogger.Click += new System.EventHandler(this.DeleteBlogger_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 241);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteBlogger);
            this.Controls.Add(this.InsertBlogger);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fmMain";
            this.Text = "fmMain";
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloggerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource dataManagerBindingSource;
        private BindingSource dataManagerBindingSource1;
        private BindingSource bloggerBindingSource;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private TextBox textBoxPost;
        private Button InsertBlogger;
        private Button DeleteBlogger;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPost;
        private Button button1;
    }
}