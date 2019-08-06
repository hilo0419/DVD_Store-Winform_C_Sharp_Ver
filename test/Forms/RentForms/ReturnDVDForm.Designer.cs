namespace test.Forms.RentForms
{
    partial class ReturnDVDForm
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
            this.cbbTitle = new System.Windows.Forms.ComboBox();
            this.dVDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbTitle
            // 
            this.cbbTitle.DataSource = this.dVDBindingSource;
            this.cbbTitle.DisplayMember = "Title";
            this.cbbTitle.FormattingEnabled = true;
            this.cbbTitle.Location = new System.Drawing.Point(112, 62);
            this.cbbTitle.Name = "cbbTitle";
            this.cbbTitle.Size = new System.Drawing.Size(104, 22);
            this.cbbTitle.TabIndex = 31;
            this.cbbTitle.ValueMember = "DvdID";
            // 
            // dVDBindingSource
            // 
            this.dVDBindingSource.DataSource = typeof(test.DVD);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(152, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 33);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReturn.Location = new System.Drawing.Point(82, 135);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(64, 33);
            this.btnReturn.TabIndex = 29;
            this.btnReturn.Text = "반납";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(49, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 22);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "제목 :  ";
            // 
            // ReturnDVDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 219);
            this.Controls.Add(this.cbbTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("휴먼편지체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "ReturnDVDForm";
            this.Text = "ReturnDVDForm";
            this.Load += new System.EventHandler(this.ReturnDVDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource dVDBindingSource;
    }
}