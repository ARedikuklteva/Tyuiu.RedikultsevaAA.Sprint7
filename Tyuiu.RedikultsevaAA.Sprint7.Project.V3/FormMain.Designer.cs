
namespace Tyuiu.RedikultsevaAA.Sprint7.Project.V3
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.labelUni_RAA = new System.Windows.Forms.Label();
            this.buttonHelp_RAA = new System.Windows.Forms.Button();
            this.buttonSearch_RAA = new System.Windows.Forms.Button();
            this.pictureBoxImageUniversity_RAA = new System.Windows.Forms.PictureBox();
            this.toolTip_RAA = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageUniversity_RAA)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUni_RAA
            // 
            this.labelUni_RAA.AutoSize = true;
            this.labelUni_RAA.Enabled = false;
            this.labelUni_RAA.Location = new System.Drawing.Point(373, 27);
            this.labelUni_RAA.Name = "labelUni_RAA";
            this.labelUni_RAA.Size = new System.Drawing.Size(93, 17);
            this.labelUni_RAA.TabIndex = 1;
            this.labelUni_RAA.Text = "Университет";
            // 
            // buttonHelp_RAA
            // 
            this.buttonHelp_RAA.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonHelp_RAA.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.buttonHelp_RAA.FlatAppearance.BorderSize = 0;
            this.buttonHelp_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_RAA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelp_RAA.Location = new System.Drawing.Point(671, 466);
            this.buttonHelp_RAA.Name = "buttonHelp_RAA";
            this.buttonHelp_RAA.Size = new System.Drawing.Size(100, 60);
            this.buttonHelp_RAA.TabIndex = 3;
            this.buttonHelp_RAA.Text = "Справка";
            this.toolTip_RAA.SetToolTip(this.buttonHelp_RAA, "О разработчике");
            this.buttonHelp_RAA.UseVisualStyleBackColor = false;
            this.buttonHelp_RAA.Click += new System.EventHandler(this.buttonHelp_RAA_Click);
            // 
            // buttonSearch_RAA
            // 
            this.buttonSearch_RAA.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonSearch_RAA.FlatAppearance.BorderSize = 0;
            this.buttonSearch_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch_RAA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSearch_RAA.Location = new System.Drawing.Point(790, 466);
            this.buttonSearch_RAA.Name = "buttonSearch_RAA";
            this.buttonSearch_RAA.Size = new System.Drawing.Size(100, 60);
            this.buttonSearch_RAA.TabIndex = 3;
            this.buttonSearch_RAA.Text = "Поиск";
            this.toolTip_RAA.SetToolTip(this.buttonSearch_RAA, "Поиск преподователя");
            this.buttonSearch_RAA.UseVisualStyleBackColor = false;
            this.buttonSearch_RAA.Click += new System.EventHandler(this.buttonSearch_RAA_Click);
            // 
            // pictureBoxImageUniversity_RAA
            // 
            this.pictureBoxImageUniversity_RAA.ErrorImage = global::Tyuiu.RedikultsevaAA.Sprint7.Project.V3.Properties.Resources.photo_University;
            this.pictureBoxImageUniversity_RAA.Image = global::Tyuiu.RedikultsevaAA.Sprint7.Project.V3.Properties.Resources.photo_University;
            this.pictureBoxImageUniversity_RAA.Location = new System.Drawing.Point(12, 86);
            this.pictureBoxImageUniversity_RAA.Name = "pictureBoxImageUniversity_RAA";
            this.pictureBoxImageUniversity_RAA.Size = new System.Drawing.Size(878, 340);
            this.pictureBoxImageUniversity_RAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageUniversity_RAA.TabIndex = 2;
            this.pictureBoxImageUniversity_RAA.TabStop = false;
            // 
            // toolTip_RAA
            // 
            this.toolTip_RAA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(902, 553);
            this.Controls.Add(this.buttonSearch_RAA);
            this.Controls.Add(this.buttonHelp_RAA);
            this.Controls.Add(this.pictureBoxImageUniversity_RAA);
            this.Controls.Add(this.labelUni_RAA);
            this.MaximumSize = new System.Drawing.Size(920, 600);
            this.MinimumSize = new System.Drawing.Size(920, 600);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageUniversity_RAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUni_RAA;
        private System.Windows.Forms.PictureBox pictureBoxImageUniversity_RAA;
        private System.Windows.Forms.Button buttonHelp_RAA;
        private System.Windows.Forms.Button buttonSearch_RAA;
        private System.Windows.Forms.ToolTip toolTip_RAA;
    }
}

