namespace test.Forms
{
    partial class DVDForm
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
            this.btnSearchDVD = new System.Windows.Forms.Button();
            this.btnUpdateDVDInfo = new System.Windows.Forms.Button();
            this.btnDVDInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchDVD
            // 
            this.btnSearchDVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearchDVD.FlatAppearance.BorderSize = 0;
            this.btnSearchDVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDVD.Font = new System.Drawing.Font("휴먼편지체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchDVD.Location = new System.Drawing.Point(221, 0);
            this.btnSearchDVD.Name = "btnSearchDVD";
            this.btnSearchDVD.Size = new System.Drawing.Size(104, 92);
            this.btnSearchDVD.TabIndex = 5;
            this.btnSearchDVD.Text = "DVD조회";
            this.btnSearchDVD.UseVisualStyleBackColor = false;
            this.btnSearchDVD.Click += new System.EventHandler(this.BtnSearchDVD_Click);
            // 
            // btnUpdateDVDInfo
            // 
            this.btnUpdateDVDInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdateDVDInfo.FlatAppearance.BorderSize = 0;
            this.btnUpdateDVDInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDVDInfo.Font = new System.Drawing.Font("휴먼편지체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdateDVDInfo.Location = new System.Drawing.Point(111, 0);
            this.btnUpdateDVDInfo.Name = "btnUpdateDVDInfo";
            this.btnUpdateDVDInfo.Size = new System.Drawing.Size(104, 92);
            this.btnUpdateDVDInfo.TabIndex = 4;
            this.btnUpdateDVDInfo.Text = " DVD   정보수정";
            this.btnUpdateDVDInfo.UseVisualStyleBackColor = false;
            this.btnUpdateDVDInfo.Click += new System.EventHandler(this.BtnUpdateDVDInfo_Click);
            // 
            // btnDVDInsert
            // 
            this.btnDVDInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDVDInsert.FlatAppearance.BorderSize = 0;
            this.btnDVDInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDVDInsert.Font = new System.Drawing.Font("휴먼편지체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDVDInsert.Location = new System.Drawing.Point(1, 0);
            this.btnDVDInsert.Name = "btnDVDInsert";
            this.btnDVDInsert.Size = new System.Drawing.Size(104, 92);
            this.btnDVDInsert.TabIndex = 3;
            this.btnDVDInsert.Text = "DVD등록";
            this.btnDVDInsert.UseVisualStyleBackColor = false;
            this.btnDVDInsert.Click += new System.EventHandler(this.BtnDVDInsert_Click);
            // 
            // DVDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 92);
            this.Controls.Add(this.btnSearchDVD);
            this.Controls.Add(this.btnUpdateDVDInfo);
            this.Controls.Add(this.btnDVDInsert);
            this.Name = "DVDForm";
            this.Text = "DVDForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDVD;
        private System.Windows.Forms.Button btnUpdateDVDInfo;
        private System.Windows.Forms.Button btnDVDInsert;
    }
}