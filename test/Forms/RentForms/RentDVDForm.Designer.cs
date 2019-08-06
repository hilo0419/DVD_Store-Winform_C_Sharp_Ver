namespace test.Forms.RentForms
{
    partial class RentDVDForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txbCusID = new System.Windows.Forms.TextBox();
            this.lblCusID = new System.Windows.Forms.Label();
            this.cbbTitle = new System.Windows.Forms.ComboBox();
            this.dVDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dVDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(141, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 33);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnRent
            // 
            this.btnRent.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRent.Location = new System.Drawing.Point(71, 140);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(64, 33);
            this.btnRent.TabIndex = 25;
            this.btnRent.Text = "대여";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.BtnRent_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnsearch.Location = new System.Drawing.Point(230, 38);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(47, 27);
            this.btnsearch.TabIndex = 24;
            this.btnsearch.Text = "조회";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.Btnsearch_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(50, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 17);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "제목 :  ";
            // 
            // txbCusID
            // 
            this.txbCusID.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbCusID.Location = new System.Drawing.Point(101, 38);
            this.txbCusID.Name = "txbCusID";
            this.txbCusID.Size = new System.Drawing.Size(104, 25);
            this.txbCusID.TabIndex = 21;
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCusID.Location = new System.Drawing.Point(28, 38);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(68, 17);
            this.lblCusID.TabIndex = 20;
            this.lblCusID.Text = "아이디 : ";
            // 
            // cbbTitle
            // 
            this.cbbTitle.DataSource = this.dVDBindingSource1;
            this.cbbTitle.DisplayMember = "Title";
            this.cbbTitle.FormattingEnabled = true;
            this.cbbTitle.Location = new System.Drawing.Point(101, 82);
            this.cbbTitle.Name = "cbbTitle";
            this.cbbTitle.Size = new System.Drawing.Size(104, 22);
            this.cbbTitle.TabIndex = 27;
            this.cbbTitle.ValueMember = "DvdID";
            // 
            // dVDBindingSource1
            // 
            this.dVDBindingSource1.DataSource = typeof(test.DVD);
            // 
            // dVDBindingSource
            // 
            this.dVDBindingSource.DataSource = typeof(test.DVD);
            // 
            // RentDVDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 219);
            this.Controls.Add(this.cbbTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txbCusID);
            this.Controls.Add(this.lblCusID);
            this.Font = new System.Drawing.Font("휴먼편지체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "RentDVDForm";
            this.Text = "RentDVDForm";
            this.Load += new System.EventHandler(this.RentDVDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txbCusID;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.ComboBox cbbTitle;
        private System.Windows.Forms.BindingSource dVDBindingSource;
        private System.Windows.Forms.BindingSource dVDBindingSource1;
    }
}