namespace Task_Manager_Kids
{
    partial class TelaInicial
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
            this.FilhoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ResponsavelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FilhoBtn
            // 
            this.FilhoBtn.BorderRadius = 10;
            this.FilhoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FilhoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FilhoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FilhoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FilhoBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FilhoBtn.ForeColor = System.Drawing.Color.White;
            this.FilhoBtn.Location = new System.Drawing.Point(31, 163);
            this.FilhoBtn.Name = "FilhoBtn";
            this.FilhoBtn.Size = new System.Drawing.Size(369, 59);
            this.FilhoBtn.TabIndex = 4;
            this.FilhoBtn.Text = "Filho(a)";
            this.FilhoBtn.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // ResponsavelBtn
            // 
            this.ResponsavelBtn.BorderRadius = 10;
            this.ResponsavelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResponsavelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResponsavelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResponsavelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResponsavelBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ResponsavelBtn.ForeColor = System.Drawing.Color.White;
            this.ResponsavelBtn.Location = new System.Drawing.Point(31, 79);
            this.ResponsavelBtn.Name = "ResponsavelBtn";
            this.ResponsavelBtn.Size = new System.Drawing.Size(369, 59);
            this.ResponsavelBtn.TabIndex = 5;
            this.ResponsavelBtn.Text = "Responsável";
            this.ResponsavelBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(139, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha um item";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(433, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResponsavelBtn);
            this.Controls.Add(this.FilhoBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button FilhoBtn;
        private Guna.UI2.WinForms.Guna2Button ResponsavelBtn;
        private System.Windows.Forms.Label label1;
    }
}