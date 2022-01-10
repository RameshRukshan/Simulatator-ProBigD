
namespace Simulatator_ProBigD
{
    partial class Error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_errorMessage = new System.Windows.Forms.Label();
            this.btn_ok = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_errorMessage
            // 
            this.lbl_errorMessage.AutoSize = true;
            this.lbl_errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorMessage.Location = new System.Drawing.Point(47, 151);
            this.lbl_errorMessage.Name = "lbl_errorMessage";
            this.lbl_errorMessage.Size = new System.Drawing.Size(355, 29);
            this.lbl_errorMessage.TabIndex = 1;
            this.lbl_errorMessage.Text = "Oopz! Something went wrong";
            // 
            // btn_ok
            // 
            this.btn_ok.Animated = true;
            this.btn_ok.AutoRoundedCorners = true;
            this.btn_ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_ok.BorderRadius = 21;
            this.btn_ok.CheckedState.Parent = this.btn_ok;
            this.btn_ok.CustomImages.Parent = this.btn_ok;
            this.btn_ok.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ok.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ok.DisabledState.Parent = this.btn_ok;
            this.btn_ok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.btn_ok.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.HoverState.Parent = this.btn_ok;
            this.btn_ok.Location = new System.Drawing.Point(121, 196);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.ShadowDecoration.Parent = this.btn_ok;
            this.btn_ok.Size = new System.Drawing.Size(200, 45);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseTransparentBackground = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 266);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_errorMessage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Error";
            this.Text = "Error";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_errorMessage;
        private Guna.UI2.WinForms.Guna2Button btn_ok;
    }
}