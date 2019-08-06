namespace test.Forms
{
    partial class RentForm
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
            this.btnReturnDVD = new System.Windows.Forms.Button();
            this.btnRentDVD = new System.Windows.Forms.Button();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchDVD
            // 
            this.btnSearchDVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearchDVD.FlatAppearance.BorderSize = 0;
            this.btnSearchDVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDVD.Font = new System.Drawing.Font("휴먼편지체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchDVD.Location = new System.Drawing.Point(219, 0);
            this.btnSearchDVD.Name = "btnSearchDVD";
            this.btnSearchDVD.Size = new System.Drawing.Size(104, 92);
            this.btnSearchDVD.TabIndex = 5;
            this.btnSearchDVD.Text = "  DVD   정보조회";
            this.btnSearchDVD.UseVisualStyleBackColor = false;
            this.btnSearchDVD.Click += new System.EventHandler(this.BtnSearchDVD_Click);
            // 
            // btnReturnDVD
            // 
            this.btnReturnDVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReturnDVD.FlatAppearance.BorderSize = 0;
            this.btnReturnDVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnDVD.Font = new System.Drawing.Font("휴먼편지체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReturnDVD.Location = new System.Drawing.Point(109, 0);
            this.btnReturnDVD.Name = "btnReturnDVD";
            this.btnReturnDVD.Size = new System.Drawing.Size(104, 92);
            this.btnReturnDVD.TabIndex = 4;
            this.btnReturnDVD.Text = "DVD반납";
            this.btnReturnDVD.UseVisualStyleBackColor = false;
            this.btnReturnDVD.Click += new System.EventHandler(this.BtnReturnDVD_Click);
            // 
            // btnRentDVD
            // 
            this.btnRentDVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRentDVD.FlatAppearance.BorderSize = 0;
            this.btnRentDVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentDVD.Font = new System.Drawing.Font("휴먼편지체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRentDVD.Location = new System.Drawing.Point(-1, 0);
            this.btnRentDVD.Name = "btnRentDVD";
            this.btnRentDVD.Size = new System.Drawing.Size(104, 92);
            this.btnRentDVD.TabIndex = 3;
            this.btnRentDVD.Text = "DVD대여";
            this.btnRentDVD.UseVisualStyleBackColor = false;
            this.btnRentDVD.Click += new System.EventHandler(this.BtnRentDVD_Click);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearchDate.FlatAppearance.BorderSize = 0;
            this.btnSearchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDate.Font = new System.Drawing.Font("휴먼편지체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchDate.Location = new System.Drawing.Point(329, 0);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(113, 92);
            this.btnSearchDate.TabIndex = 6;
            this.btnSearchDate.Text = "   DVD   날짜별조회";
            this.btnSearchDate.UseVisualStyleBackColor = false;
            this.btnSearchDate.Click += new System.EventHandler(this.BtnSearchDate_Click);
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 93);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.btnSearchDVD);
            this.Controls.Add(this.btnReturnDVD);
            this.Controls.Add(this.btnRentDVD);
            this.Name = "RentForm";
            this.Text = "RentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDVD;
        private System.Windows.Forms.Button btnReturnDVD;
        private System.Windows.Forms.Button btnRentDVD;
        private System.Windows.Forms.Button btnSearchDate;
    }
}