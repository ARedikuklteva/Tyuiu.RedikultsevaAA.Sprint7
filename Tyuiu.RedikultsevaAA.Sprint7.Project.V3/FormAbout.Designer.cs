
namespace Tyuiu.RedikultsevaAA.Sprint7.Project.V3
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_RAA = new System.Windows.Forms.PictureBox();
            this.labelAbout_RAA = new System.Windows.Forms.Label();
            this.buttonOK_RAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_RAA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_RAA
            // 
            this.pictureBoxAvatar_RAA.Image = global::Tyuiu.RedikultsevaAA.Sprint7.Project.V3.Properties.Resources.photo;
            this.pictureBoxAvatar_RAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_RAA.Name = "pictureBoxAvatar_RAA";
            this.pictureBoxAvatar_RAA.Size = new System.Drawing.Size(150, 200);
            this.pictureBoxAvatar_RAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_RAA.TabIndex = 0;
            this.pictureBoxAvatar_RAA.TabStop = false;
            // 
            // labelAbout_RAA
            // 
            this.labelAbout_RAA.AutoSize = true;
            this.labelAbout_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelAbout_RAA.Location = new System.Drawing.Point(177, 12);
            this.labelAbout_RAA.Name = "labelAbout_RAA";
            this.labelAbout_RAA.Size = new System.Drawing.Size(380, 153);
            this.labelAbout_RAA.TabIndex = 1;
            this.labelAbout_RAA.Text = resources.GetString("labelAbout_RAA.Text");
            // 
            // buttonOK_RAA
            // 
            this.buttonOK_RAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.buttonOK_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK_RAA.ForeColor = System.Drawing.Color.Sienna;
            this.buttonOK_RAA.Location = new System.Drawing.Point(512, 184);
            this.buttonOK_RAA.Name = "buttonOK_RAA";
            this.buttonOK_RAA.Size = new System.Drawing.Size(44, 28);
            this.buttonOK_RAA.TabIndex = 2;
            this.buttonOK_RAA.Text = "OK";
            this.buttonOK_RAA.UseVisualStyleBackColor = false;
            this.buttonOK_RAA.Click += new System.EventHandler(this.buttonOK_RAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(568, 222);
            this.Controls.Add(this.buttonOK_RAA);
            this.Controls.Add(this.labelAbout_RAA);
            this.Controls.Add(this.pictureBoxAvatar_RAA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(586, 269);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(586, 269);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_RAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_RAA;
        private System.Windows.Forms.Label labelAbout_RAA;
        private System.Windows.Forms.Button buttonOK_RAA;
    }
}