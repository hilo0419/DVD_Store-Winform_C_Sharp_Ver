namespace test.Forms.CustoemrForms
{
    partial class UpdateInfoForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.Location = new System.Drawing.Point(126, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 28);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnsearch.Location = new System.Drawing.Point(222, 37);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(47, 23);
            this.btnsearch.TabIndex = 10;
            this.btnsearch.Text = "조회";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.Btnsearch_Click);
            // 
            // txbNumber
            // 
            this.txbNumber.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbNumber.Location = new System.Drawing.Point(101, 75);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(139, 25);
            this.txbNumber.TabIndex = 9;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNumber.Location = new System.Drawing.Point(58, 73);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(58, 17);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "번호 :  ";
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbID.Location = new System.Drawing.Point(101, 39);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(100, 25);
            this.txbID.TabIndex = 7;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.Location = new System.Drawing.Point(42, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 17);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "아이디 : ";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(207, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // UpdateInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 193);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblID);
            this.Name = "UpdateInfoForm";
            this.Text = "UpdateInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCancel;
    }
}