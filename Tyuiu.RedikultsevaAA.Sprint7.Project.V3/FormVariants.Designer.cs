
namespace Tyuiu.RedikultsevaAA.Sprint7.Project.V3
{
    partial class FormVariants
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
            this.labelSearch_RAA = new System.Windows.Forms.Label();
            this.buttonFirst_RAA = new System.Windows.Forms.Button();
            this.buttonSecond_RAA = new System.Windows.Forms.Button();
            this.buttonThird_RAA = new System.Windows.Forms.Button();
            this.toolTip_RAA = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelSearch_RAA
            // 
            this.labelSearch_RAA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearch_RAA.AutoSize = true;
            this.labelSearch_RAA.ForeColor = System.Drawing.Color.Sienna;
            this.labelSearch_RAA.Location = new System.Drawing.Point(28, 19);
            this.labelSearch_RAA.Name = "labelSearch_RAA";
            this.labelSearch_RAA.Size = new System.Drawing.Size(230, 34);
            this.labelSearch_RAA.TabIndex = 0;
            this.labelSearch_RAA.Text = "Варианты поиска преподователя\r\n\r\n";
            // 
            // buttonFirst_RAA
            // 
            this.buttonFirst_RAA.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonFirst_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst_RAA.ForeColor = System.Drawing.Color.Sienna;
            this.buttonFirst_RAA.Location = new System.Drawing.Point(12, 66);
            this.buttonFirst_RAA.Name = "buttonFirst_RAA";
            this.buttonFirst_RAA.Size = new System.Drawing.Size(110, 50);
            this.buttonFirst_RAA.TabIndex = 1;
            this.buttonFirst_RAA.Text = "По кафедре";
            this.toolTip_RAA.SetToolTip(this.buttonFirst_RAA, "Поиск преподователя по кафедре, \r\nк которой он(а) относятся");
            this.buttonFirst_RAA.UseVisualStyleBackColor = false;
            this.buttonFirst_RAA.Click += new System.EventHandler(this.buttonFirst_RAA_Click);
            // 
            // buttonSecond_RAA
            // 
            this.buttonSecond_RAA.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonSecond_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSecond_RAA.ForeColor = System.Drawing.Color.Sienna;
            this.buttonSecond_RAA.Location = new System.Drawing.Point(128, 66);
            this.buttonSecond_RAA.Name = "buttonSecond_RAA";
            this.buttonSecond_RAA.Size = new System.Drawing.Size(110, 50);
            this.buttonSecond_RAA.TabIndex = 1;
            this.buttonSecond_RAA.Text = "По предмету";
            this.toolTip_RAA.SetToolTip(this.buttonSecond_RAA, "Поиск преподователя по предмету, \r\nкоторый он(а) преподает\r\n");
            this.buttonSecond_RAA.UseVisualStyleBackColor = false;
            this.buttonSecond_RAA.Click += new System.EventHandler(this.buttonSecond_RAA_Click);
            // 
            // buttonThird_RAA
            // 
            this.buttonThird_RAA.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonThird_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThird_RAA.ForeColor = System.Drawing.Color.Sienna;
            this.buttonThird_RAA.Location = new System.Drawing.Point(244, 66);
            this.buttonThird_RAA.Name = "buttonThird_RAA";
            this.buttonThird_RAA.Size = new System.Drawing.Size(110, 50);
            this.buttonThird_RAA.TabIndex = 1;
            this.buttonThird_RAA.Text = "По ФИО";
            this.toolTip_RAA.SetToolTip(this.buttonThird_RAA, "Поиск преподователя по их ФИО\r\n\r\n");
            this.buttonThird_RAA.UseVisualStyleBackColor = false;
            this.buttonThird_RAA.Click += new System.EventHandler(this.buttonThird_RAA_Click);
            // 
            // toolTip_RAA
            // 
            this.toolTip_RAA.ToolTipTitle = "Подсказка";
            // 
            // FormVariants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(368, 133);
            this.Controls.Add(this.buttonThird_RAA);
            this.Controls.Add(this.buttonSecond_RAA);
            this.Controls.Add(this.buttonFirst_RAA);
            this.Controls.Add(this.labelSearch_RAA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVariants";
            this.Text = "Как ищем преподователя?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearch_RAA;
        private System.Windows.Forms.Button buttonFirst_RAA;
        private System.Windows.Forms.Button buttonSecond_RAA;
        private System.Windows.Forms.Button buttonThird_RAA;
        private System.Windows.Forms.ToolTip toolTip_RAA;
    }
}