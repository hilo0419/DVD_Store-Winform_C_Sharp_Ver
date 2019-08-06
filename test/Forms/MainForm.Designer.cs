namespace test.Forms
{
    partial class MainForm
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnDvd = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("휴먼편지체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnCustomer.Location = new System.Drawing.Point(0, 84);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(166, 151);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Custoemr";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // btnDvd
            // 
            this.btnDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDvd.FlatAppearance.BorderSize = 0;
            this.btnDvd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDvd.Font = new System.Drawing.Font("휴먼편지체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDvd.ForeColor = System.Drawing.Color.Black;
            this.btnDvd.Location = new System.Drawing.Point(172, 84);
            this.btnDvd.Name = "btnDvd";
            this.btnDvd.Size = new System.Drawing.Size(166, 151);
            this.btnDvd.TabIndex = 1;
            this.btnDvd.Text = "DVD";
            this.btnDvd.UseVisualStyleBackColor = false;
            this.btnDvd.Click += new System.EventHandler(this.BtnDvd_Click);
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRent.FlatAppearance.BorderSize = 0;
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.Font = new System.Drawing.Font("휴먼편지체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRent.Location = new System.Drawing.Point(344, 84);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(166, 151);
            this.btnRent.TabIndex = 2;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.BtnRent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼편지체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(176, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "DVD Store";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnDvd);
            this.Controls.Add(this.btnCustomer);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnDvd;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label label1;
    }
}