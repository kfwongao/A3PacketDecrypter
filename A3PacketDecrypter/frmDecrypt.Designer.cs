namespace A3PacketDecrypter
{
    partial class frmDecrypt
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
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.rb562 = new System.Windows.Forms.RadioButton();
            this.rbReturns = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(99, 65);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(65, 32);
            this.btnDecrypt.TabIndex = 0;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select file to decrypt the packet";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // rb562
            // 
            this.rb562.AutoSize = true;
            this.rb562.Location = new System.Drawing.Point(61, 35);
            this.rb562.Name = "rb562";
            this.rb562.Size = new System.Drawing.Size(43, 17);
            this.rb562.TabIndex = 2;
            this.rb562.TabStop = true;
            this.rb562.Text = "562";
            this.rb562.UseVisualStyleBackColor = true;
            // 
            // rbReturns
            // 
            this.rbReturns.AutoSize = true;
            this.rbReturns.Location = new System.Drawing.Point(158, 35);
            this.rbReturns.Name = "rbReturns";
            this.rbReturns.Size = new System.Drawing.Size(62, 17);
            this.rbReturns.TabIndex = 3;
            this.rbReturns.TabStop = true;
            this.rbReturns.Text = "Returns";
            this.rbReturns.UseVisualStyleBackColor = true;
            // 
            // frmDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 107);
            this.Controls.Add(this.rbReturns);
            this.Controls.Add(this.rb562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmDecrypt";
            this.Text = "Packet Decrypter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.RadioButton rb562;
        private System.Windows.Forms.RadioButton rbReturns;
    }
}

