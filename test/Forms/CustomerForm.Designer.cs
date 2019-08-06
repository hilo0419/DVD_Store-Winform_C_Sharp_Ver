namespace test.Forms
{
    partial class CustomerForm
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
            this.btnCusInsert = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnSearchCus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCusInsert
            // 
            this.btnCusInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCusInsert.FlatAppearance.BorderSize = 0;
            this.btnCusInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusInsert.Font = new System.Drawing.Font("휴먼편지체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCusInsert.Location = new System.Drawing.Point(0, 0);
            this.btnCusInsert.Name = "btnCusInsert";
            this.btnCusInsert.Size = new System.Drawing.Size(104, 92);
            this.btnCusInsert.TabIndex = 0;
            this.btnCusInsert.Text = "신규가입";
            this.btnCusInsert.UseVisualStyleBackColor = false;
            this.btnCusInsert.Click += new System.EventHandler(this.BtnCusInsert_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdateInfo.FlatAppearance.BorderSize = 0;
            this.btnUpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInfo.Font = new System.Drawing.Font("휴먼편지체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(110, 0);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(104, 92);
            this.btnUpdateInfo.TabIndex = 1;
            this.btnUpdateInfo.Text = "정보수정";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.BtnUpdateInfo_Click);
            // 
            // btnSearchCus
            // 
            this.btnSearchCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearchCus.FlatAppearance.BorderSize = 0;
            this.btnSearchCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCus.Font = new System.Drawing.Font("휴먼편지체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchCus.Location = new System.Drawing.Point(220, 0);
            this.btnSearchCus.Name = "btnSearchCus";
            this.btnSearchCus.Size = new System.Drawing.Size(104, 92);
            this.btnSearchCus.TabIndex = 2;
            this.btnSearchCus.Text = "회원조회";
            this.btnSearchCus.UseVisualStyleBackColor = false;
            this.btnSearchCus.Click += new System.EventHandler(this.BtnSearchCus_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(326, 92);
            this.Controls.Add(this.btnSearchCus);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.btnCusInsert);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCusInsert;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnSearchCus;
    }
}