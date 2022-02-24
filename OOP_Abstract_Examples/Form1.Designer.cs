
namespace OOP_Abstract_Examples
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
            this.gitarBtn = new System.Windows.Forms.Button();
            this.bateriBtn = new System.Windows.Forms.Button();
            this.flutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gitarBtn
            // 
            this.gitarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gitarBtn.Location = new System.Drawing.Point(258, 73);
            this.gitarBtn.Name = "gitarBtn";
            this.gitarBtn.Size = new System.Drawing.Size(239, 90);
            this.gitarBtn.TabIndex = 0;
            this.gitarBtn.Text = "Gitar";
            this.gitarBtn.UseVisualStyleBackColor = true;
            this.gitarBtn.Click += new System.EventHandler(this.gitarBtn_Click);
            // 
            // bateriBtn
            // 
            this.bateriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bateriBtn.Location = new System.Drawing.Point(258, 185);
            this.bateriBtn.Name = "bateriBtn";
            this.bateriBtn.Size = new System.Drawing.Size(239, 90);
            this.bateriBtn.TabIndex = 1;
            this.bateriBtn.Text = "Bateri";
            this.bateriBtn.UseVisualStyleBackColor = true;
            this.bateriBtn.Click += new System.EventHandler(this.bateriBtn_Click);
            // 
            // flutBtn
            // 
            this.flutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flutBtn.Location = new System.Drawing.Point(258, 304);
            this.flutBtn.Name = "flutBtn";
            this.flutBtn.Size = new System.Drawing.Size(239, 90);
            this.flutBtn.TabIndex = 2;
            this.flutBtn.Text = "Yan Flut";
            this.flutBtn.UseVisualStyleBackColor = true;
            this.flutBtn.Click += new System.EventHandler(this.flutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flutBtn);
            this.Controls.Add(this.bateriBtn);
            this.Controls.Add(this.gitarBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gitarBtn;
        private System.Windows.Forms.Button bateriBtn;
        private System.Windows.Forms.Button flutBtn;
    }
}

