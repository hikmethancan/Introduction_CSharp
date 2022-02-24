
namespace OOP_Struct
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
            this.structBtn = new System.Windows.Forms.Button();
            this.sealedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // structBtn
            // 
            this.structBtn.Location = new System.Drawing.Point(110, 142);
            this.structBtn.Name = "structBtn";
            this.structBtn.Size = new System.Drawing.Size(185, 137);
            this.structBtn.TabIndex = 0;
            this.structBtn.Text = "Struct Yapısı Ile";
            this.structBtn.UseVisualStyleBackColor = true;
            this.structBtn.Click += new System.EventHandler(this.structBtn_Click);
            // 
            // sealedBtn
            // 
            this.sealedBtn.Location = new System.Drawing.Point(469, 142);
            this.sealedBtn.Name = "sealedBtn";
            this.sealedBtn.Size = new System.Drawing.Size(185, 137);
            this.sealedBtn.TabIndex = 1;
            this.sealedBtn.Text = "Sealed Yapisi Ile";
            this.sealedBtn.UseVisualStyleBackColor = true;
            this.sealedBtn.Click += new System.EventHandler(this.sealedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sealedBtn);
            this.Controls.Add(this.structBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button structBtn;
        private System.Windows.Forms.Button sealedBtn;
    }
}

