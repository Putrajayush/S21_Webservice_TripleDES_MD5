
namespace Triple_DES_Encryption
{
    partial class Form1
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
            this.FileText = new System.Windows.Forms.Label();
            this.KeyText = new System.Windows.Forms.Label();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.FileBtn = new System.Windows.Forms.Button();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileText
            // 
            this.FileText.AutoSize = true;
            this.FileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileText.Location = new System.Drawing.Point(36, 56);
            this.FileText.Name = "FileText";
            this.FileText.Size = new System.Drawing.Size(88, 42);
            this.FileText.TabIndex = 0;
            this.FileText.Text = "File:";
            // 
            // KeyText
            // 
            this.KeyText.AutoSize = true;
            this.KeyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyText.Location = new System.Drawing.Point(38, 115);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(93, 42);
            this.KeyText.TabIndex = 1;
            this.KeyText.Text = "Key:";
            // 
            // FileTextBox
            // 
            this.FileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileTextBox.Location = new System.Drawing.Point(130, 53);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(498, 49);
            this.FileTextBox.TabIndex = 2;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTextBox.Location = new System.Drawing.Point(130, 115);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(339, 49);
            this.KeyTextBox.TabIndex = 3;
            // 
            // FileBtn
            // 
            this.FileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileBtn.Location = new System.Drawing.Point(647, 53);
            this.FileBtn.Name = "FileBtn";
            this.FileBtn.Size = new System.Drawing.Size(131, 49);
            this.FileBtn.TabIndex = 4;
            this.FileBtn.Text = "...";
            this.FileBtn.UseVisualStyleBackColor = true;
            this.FileBtn.Click += new System.EventHandler(this.FileBtn_Click);
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptBtn.Location = new System.Drawing.Point(487, 115);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(141, 52);
            this.EncryptBtn.TabIndex = 5;
            this.EncryptBtn.Text = "Encrypt";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptBtn.Location = new System.Drawing.Point(647, 115);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(131, 52);
            this.DecryptBtn.TabIndex = 6;
            this.DecryptBtn.Text = "Decrypt";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 229);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.FileBtn);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.KeyText);
            this.Controls.Add(this.FileText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileText;
        private System.Windows.Forms.Label KeyText;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Button FileBtn;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Button DecryptBtn;
    }
}

