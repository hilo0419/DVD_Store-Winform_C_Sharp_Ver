namespace test.Forms.RentForms
{
    partial class SearchRentForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAllSearch = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.cbbTitle = new System.Windows.Forms.ComboBox();
            this.dVDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.dvdIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAllSearch);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.cbbTitle);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAllSearch
            // 
            this.btnAllSearch.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAllSearch.Location = new System.Drawing.Point(270, 36);
            this.btnAllSearch.Name = "btnAllSearch";
            this.btnAllSearch.Size = new System.Drawing.Size(51, 53);
            this.btnAllSearch.TabIndex = 35;
            this.btnAllSearch.Text = "전체조회";
            this.btnAllSearch.UseVisualStyleBackColor = true;
            this.btnAllSearch.Click += new System.EventHandler(this.BtnAllSearch_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnsearch.Location = new System.Drawing.Point(187, 42);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(58, 40);
            this.btnsearch.TabIndex = 34;
            this.btnsearch.Text = "조회";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.Btnsearch_Click);
            // 
            // cbbTitle
            // 
            this.cbbTitle.DataSource = this.dVDBindingSource;
            this.cbbTitle.DisplayMember = "Title";
            this.cbbTitle.FormattingEnabled = true;
            this.cbbTitle.Location = new System.Drawing.Point(66, 54);
            this.cbbTitle.Name = "cbbTitle";
            this.cbbTitle.Size = new System.Drawing.Size(104, 22);
            this.cbbTitle.TabIndex = 33;
            this.cbbTitle.ValueMember = "DvdID";
            // 
            // dVDBindingSource
            // 
            this.dVDBindingSource.DataSource = typeof(test.DVD);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(12, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(47, 19);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "제목 :";
            // 
            // dgvList
            // 
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvdIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.rentStatusDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.dVDBindingSource;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 117);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(333, 299);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvList_CellFormatting);
            // 
            // dvdIDDataGridViewTextBoxColumn
            // 
            this.dvdIDDataGridViewTextBoxColumn.DataPropertyName = "DvdID";
            this.dvdIDDataGridViewTextBoxColumn.HeaderText = "DvdID";
            this.dvdIDDataGridViewTextBoxColumn.Name = "dvdIDDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // rentStatusDataGridViewTextBoxColumn
            // 
            this.rentStatusDataGridViewTextBoxColumn.DataPropertyName = "RentStatus";
            this.rentStatusDataGridViewTextBoxColumn.HeaderText = "RentStatus";
            this.rentStatusDataGridViewTextBoxColumn.Name = "rentStatusDataGridViewTextBoxColumn";
            // 
            // SearchRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 416);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("휴먼편지체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "SearchRentForm";
            this.Text = "SearchRentForm";
            this.Load += new System.EventHandler(this.SearchRentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAllSearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvdIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dVDBindingSource;
    }
}