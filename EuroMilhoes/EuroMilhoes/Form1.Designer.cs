﻿namespace EuroMilhoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SairBtn = new System.Windows.Forms.Button();
            this.JogarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SairBtn
            // 
            this.SairBtn.BackColor = System.Drawing.Color.LightGray;
            this.SairBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SairBtn.FlatAppearance.BorderSize = 0;
            this.SairBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.SairBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SairBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SairBtn.Location = new System.Drawing.Point(434, 314);
            this.SairBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SairBtn.Name = "SairBtn";
            this.SairBtn.Size = new System.Drawing.Size(139, 37);
            this.SairBtn.TabIndex = 0;
            this.SairBtn.Text = "SAIR";
            this.SairBtn.UseVisualStyleBackColor = false;
            this.SairBtn.Click += new System.EventHandler(this.SairBtn_Click);
            // 
            // JogarBtn
            // 
            this.JogarBtn.BackColor = System.Drawing.Color.LightGray;
            this.JogarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JogarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.JogarBtn.FlatAppearance.BorderSize = 0;
            this.JogarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.JogarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JogarBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JogarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JogarBtn.Location = new System.Drawing.Point(433, 254);
            this.JogarBtn.Name = "JogarBtn";
            this.JogarBtn.Size = new System.Drawing.Size(139, 37);
            this.JogarBtn.TabIndex = 1;
            this.JogarBtn.Text = "JOGAR";
            this.JogarBtn.UseVisualStyleBackColor = false;
            this.JogarBtn.Click += new System.EventHandler(this.JogarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EuroMilhoes.Properties.Resources.transferir;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.JogarBtn);
            this.Controls.Add(this.SairBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Euro Milhões";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SairBtn;
        private System.Windows.Forms.Button JogarBtn;
    }
}

