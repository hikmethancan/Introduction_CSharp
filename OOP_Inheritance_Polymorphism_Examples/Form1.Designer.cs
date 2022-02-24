
namespace OOP_Inheritance_Polymorphism_Examples
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
            this.nokiaBtn = new System.Windows.Forms.Button();
            this.samsungBtn = new System.Windows.Forms.Button();
            this.iphoneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nokiaBtn
            // 
            this.nokiaBtn.Location = new System.Drawing.Point(257, 45);
            this.nokiaBtn.Name = "nokiaBtn";
            this.nokiaBtn.Size = new System.Drawing.Size(212, 94);
            this.nokiaBtn.TabIndex = 0;
            this.nokiaBtn.Text = "NOKIA";
            this.nokiaBtn.UseVisualStyleBackColor = true;
            this.nokiaBtn.Click += new System.EventHandler(this.nokiaBtn_Click);
            // 
            // samsungBtn
            // 
            this.samsungBtn.Location = new System.Drawing.Point(257, 170);
            this.samsungBtn.Name = "samsungBtn";
            this.samsungBtn.Size = new System.Drawing.Size(212, 94);
            this.samsungBtn.TabIndex = 1;
            this.samsungBtn.Text = "SAMSUNG";
            this.samsungBtn.UseVisualStyleBackColor = true;
            this.samsungBtn.Click += new System.EventHandler(this.samsungBtn_Click);
            // 
            // iphoneBtn
            // 
            this.iphoneBtn.Location = new System.Drawing.Point(257, 302);
            this.iphoneBtn.Name = "iphoneBtn";
            this.iphoneBtn.Size = new System.Drawing.Size(212, 94);
            this.iphoneBtn.TabIndex = 2;
            this.iphoneBtn.Text = "IPHONE";
            this.iphoneBtn.UseVisualStyleBackColor = true;
            this.iphoneBtn.Click += new System.EventHandler(this.iphoneBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iphoneBtn);
            this.Controls.Add(this.samsungBtn);
            this.Controls.Add(this.nokiaBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nokiaBtn;
        private System.Windows.Forms.Button samsungBtn;
        private System.Windows.Forms.Button iphoneBtn;
    }
}

