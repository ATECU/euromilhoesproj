namespace EuroMilhoes
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
            this.sairBtn = new System.Windows.Forms.Button();
            this.jogarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sairBtn
            // 
            this.sairBtn.Location = new System.Drawing.Point(197, 227);
            this.sairBtn.Name = "sairBtn";
            this.sairBtn.Size = new System.Drawing.Size(75, 23);
            this.sairBtn.TabIndex = 0;
            this.sairBtn.Text = "Sair";
            this.sairBtn.UseVisualStyleBackColor = true;
            this.sairBtn.Click += new System.EventHandler(this.sairBtn_Click);
            // 
            // jogarBtn
            // 
            this.jogarBtn.Location = new System.Drawing.Point(13, 227);
            this.jogarBtn.Name = "jogarBtn";
            this.jogarBtn.Size = new System.Drawing.Size(75, 23);
            this.jogarBtn.TabIndex = 1;
            this.jogarBtn.Text = "Jogar";
            this.jogarBtn.UseVisualStyleBackColor = true;
            this.jogarBtn.Click += new System.EventHandler(this.jogarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.jogarBtn);
            this.Controls.Add(this.sairBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sairBtn;
        private System.Windows.Forms.Button jogarBtn;
    }
}

