namespace TTCSDL_Module_4
{
    partial class Main
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
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.btnQLDT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLKH
            // 
            this.btnQLKH.Location = new System.Drawing.Point(108, 80);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(81, 74);
            this.btnQLKH.TabIndex = 0;
            this.btnQLKH.Text = "Quản lí khách hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnThemPT
            // 
            this.btnThemPT.Location = new System.Drawing.Point(195, 80);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(75, 74);
            this.btnThemPT.TabIndex = 1;
            this.btnThemPT.Text = "Thêm phiếu trả";
            this.btnThemPT.UseVisualStyleBackColor = true;
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            // 
            // btnQLDT
            // 
            this.btnQLDT.Location = new System.Drawing.Point(108, 160);
            this.btnQLDT.Name = "btnQLDT";
            this.btnQLDT.Size = new System.Drawing.Size(162, 74);
            this.btnQLDT.TabIndex = 2;
            this.btnQLDT.Text = "Quản lí nghiệp vụ đổi trả";
            this.btnQLDT.UseVisualStyleBackColor = true;
            this.btnQLDT.Click += new System.EventHandler(this.btnQLDT_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 313);
            this.Controls.Add(this.btnQLDT);
            this.Controls.Add(this.btnThemPT);
            this.Controls.Add(this.btnQLKH);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnThemPT;
        private System.Windows.Forms.Button btnQLDT;
    }
}