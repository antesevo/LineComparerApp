namespace LinesComparer
{
    partial class frmMain
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
            this.lblPath1 = new System.Windows.Forms.Label();
            this.lblPath2 = new System.Windows.Forms.Label();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.btnFile1WithFile2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.btnFile1 = new System.Windows.Forms.Button();
            this.btnFile2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPath1
            // 
            this.lblPath1.AutoSize = true;
            this.lblPath1.Location = new System.Drawing.Point(12, 9);
            this.lblPath1.Name = "lblPath1";
            this.lblPath1.Size = new System.Drawing.Size(74, 13);
            this.lblPath1.TabIndex = 0;
            this.lblPath1.Text = ".txt File Path 1";
            // 
            // lblPath2
            // 
            this.lblPath2.AutoSize = true;
            this.lblPath2.Location = new System.Drawing.Point(12, 39);
            this.lblPath2.Name = "lblPath2";
            this.lblPath2.Size = new System.Drawing.Size(74, 13);
            this.lblPath2.TabIndex = 1;
            this.lblPath2.Text = ".txt File Path 2";
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(92, 32);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(272, 20);
            this.txtPath2.TabIndex = 3;
            // 
            // btnFile1WithFile2
            // 
            this.btnFile1WithFile2.Location = new System.Drawing.Point(12, 58);
            this.btnFile1WithFile2.Name = "btnFile1WithFile2";
            this.btnFile1WithFile2.Size = new System.Drawing.Size(383, 23);
            this.btnFile1WithFile2.TabIndex = 4;
            this.btnFile1WithFile2.Text = "Compare File 1 With File 2";
            this.btnFile1WithFile2.UseVisualStyleBackColor = true;
            this.btnFile1WithFile2.Click += new System.EventHandler(this.btnFile1WithFile2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(92, 6);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(272, 20);
            this.txtPath1.TabIndex = 2;
            // 
            // btnFile1
            // 
            this.btnFile1.Location = new System.Drawing.Point(370, 4);
            this.btnFile1.Name = "btnFile1";
            this.btnFile1.Size = new System.Drawing.Size(25, 23);
            this.btnFile1.TabIndex = 5;
            this.btnFile1.Text = "...";
            this.btnFile1.UseVisualStyleBackColor = true;
            this.btnFile1.Click += new System.EventHandler(this.btnFile1_Click);
            // 
            // btnFile2
            // 
            this.btnFile2.Location = new System.Drawing.Point(370, 29);
            this.btnFile2.Name = "btnFile2";
            this.btnFile2.Size = new System.Drawing.Size(25, 23);
            this.btnFile2.TabIndex = 6;
            this.btnFile2.Text = "...";
            this.btnFile2.UseVisualStyleBackColor = true;
            this.btnFile2.Click += new System.EventHandler(this.btnFile2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 90);
            this.Controls.Add(this.btnFile2);
            this.Controls.Add(this.btnFile1);
            this.Controls.Add(this.btnFile1WithFile2);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.txtPath1);
            this.Controls.Add(this.lblPath2);
            this.Controls.Add(this.lblPath1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath1;
        private System.Windows.Forms.Label lblPath2;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Button btnFile1WithFile2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.Button btnFile1;
        private System.Windows.Forms.Button btnFile2;
    }
}

