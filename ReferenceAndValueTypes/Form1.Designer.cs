
namespace ReferenceAndValueTypes
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
            this.refBtn = new System.Windows.Forms.Button();
            this.valueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // refBtn
            // 
            this.refBtn.Location = new System.Drawing.Point(137, 135);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(208, 179);
            this.refBtn.TabIndex = 0;
            this.refBtn.Text = "REFERENCE";
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // valueBtn
            // 
            this.valueBtn.Location = new System.Drawing.Point(448, 135);
            this.valueBtn.Name = "valueBtn";
            this.valueBtn.Size = new System.Drawing.Size(208, 179);
            this.valueBtn.TabIndex = 1;
            this.valueBtn.Text = "VALUES";
            this.valueBtn.UseVisualStyleBackColor = true;
            this.valueBtn.Click += new System.EventHandler(this.valueBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valueBtn);
            this.Controls.Add(this.refBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button refBtn;
        private System.Windows.Forms.Button valueBtn;
    }
}

