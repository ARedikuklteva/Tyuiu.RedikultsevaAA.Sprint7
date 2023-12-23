
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
            this.toolTip_RAA = new System.Windows.Forms.ToolTip(this.components);
            this.buttonReadFile_RAA = new System.Windows.Forms.Button();
            this.buttonSortAlph_RAA = new System.Windows.Forms.Button();
            this.buttonSortKafedra_RAA = new System.Windows.Forms.Button();
            this.buttonSortBySubject_RAA = new System.Windows.Forms.Button();
            this.buttonSaveFile_RAA = new System.Windows.Forms.Button();
            this.dataGridView_RAA = new System.Windows.Forms.DataGridView();
            this.openFileDialog_RAA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_RAA = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RAA)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip_RAA
            // 
            this.toolTip_RAA.ToolTipTitle = "Подсказка";
            // 
            // buttonReadFile_RAA
            // 
            this.buttonReadFile_RAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.buttonReadFile_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadFile_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonReadFile_RAA.Location = new System.Drawing.Point(27, 12);
            this.buttonReadFile_RAA.Name = "buttonReadFile_RAA";
            this.buttonReadFile_RAA.Size = new System.Drawing.Size(120, 59);
            this.buttonReadFile_RAA.TabIndex = 1;
            this.buttonReadFile_RAA.Text = "READ FILE";
            this.toolTip_RAA.SetToolTip(this.buttonReadFile_RAA, "Прочитать файл");
            this.buttonReadFile_RAA.UseVisualStyleBackColor = false;
            this.buttonReadFile_RAA.Click += new System.EventHandler(this.buttonReadFile_RAA_Click);
            // 
            // buttonSortAlph_RAA
            // 
            this.buttonSortAlph_RAA.BackColor = System.Drawing.Color.Bisque;
            this.buttonSortAlph_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortAlph_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonSortAlph_RAA.Location = new System.Drawing.Point(27, 171);
            this.buttonSortAlph_RAA.Name = "buttonSortAlph_RAA";
            this.buttonSortAlph_RAA.Size = new System.Drawing.Size(120, 59);
            this.buttonSortAlph_RAA.TabIndex = 1;
            this.buttonSortAlph_RAA.Text = "Сортировка по алфовиту";
            this.toolTip_RAA.SetToolTip(this.buttonSortAlph_RAA, "Отсортировать таблицу по алфовиту");
            this.buttonSortAlph_RAA.UseVisualStyleBackColor = false;
            this.buttonSortAlph_RAA.Click += new System.EventHandler(this.buttonSortAlph_RAA_Click);
            // 
            // buttonSortKafedra_RAA
            // 
            this.buttonSortKafedra_RAA.BackColor = System.Drawing.Color.Bisque;
            this.buttonSortKafedra_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortKafedra_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonSortKafedra_RAA.Location = new System.Drawing.Point(27, 309);
            this.buttonSortKafedra_RAA.Name = "buttonSortKafedra_RAA";
            this.buttonSortKafedra_RAA.Size = new System.Drawing.Size(120, 61);
            this.buttonSortKafedra_RAA.TabIndex = 1;
            this.buttonSortKafedra_RAA.Text = "Сортировка по кафедре";
            this.toolTip_RAA.SetToolTip(this.buttonSortKafedra_RAA, "Отсортировать таблицу по кафедре, к которой относится преподователь");
            this.buttonSortKafedra_RAA.UseVisualStyleBackColor = false;
            this.buttonSortKafedra_RAA.Click += new System.EventHandler(this.buttonSortKafedra_RAA_Click);
            // 
            // buttonSortBySubject_RAA
            // 
            this.buttonSortBySubject_RAA.BackColor = System.Drawing.Color.Bisque;
            this.buttonSortBySubject_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortBySubject_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonSortBySubject_RAA.Location = new System.Drawing.Point(27, 452);
            this.buttonSortBySubject_RAA.Name = "buttonSortBySubject_RAA";
            this.buttonSortBySubject_RAA.Size = new System.Drawing.Size(120, 61);
            this.buttonSortBySubject_RAA.TabIndex = 1;
            this.buttonSortBySubject_RAA.Text = "Сортировка по разделу";
            this.toolTip_RAA.SetToolTip(this.buttonSortBySubject_RAA, "Отсортировать таблицу по разделу предмета, которому учит преподаватель");
            this.buttonSortBySubject_RAA.UseVisualStyleBackColor = false;
            this.buttonSortBySubject_RAA.Click += new System.EventHandler(this.buttonSortBySubject_RAA_Click);
            // 
            // buttonSaveFile_RAA
            // 
            this.buttonSaveFile_RAA.BackColor = System.Drawing.Color.Bisque;
            this.buttonSaveFile_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonSaveFile_RAA.Location = new System.Drawing.Point(1050, 12);
            this.buttonSaveFile_RAA.Name = "buttonSaveFile_RAA";
            this.buttonSaveFile_RAA.Size = new System.Drawing.Size(120, 59);
            this.buttonSaveFile_RAA.TabIndex = 1;
            this.buttonSaveFile_RAA.Text = "SAVE FILE";
            this.toolTip_RAA.SetToolTip(this.buttonSaveFile_RAA, "Сохранить файл");
            this.buttonSaveFile_RAA.UseVisualStyleBackColor = false;
            this.buttonSaveFile_RAA.Click += new System.EventHandler(this.buttonSaveFile_RAA_Click);
            // 
            // dataGridView_RAA
            // 
            this.dataGridView_RAA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.dataGridView_RAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RAA.ColumnHeadersVisible = false;
            this.dataGridView_RAA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.dataGridView_RAA.Location = new System.Drawing.Point(185, 98);
            this.dataGridView_RAA.Name = "dataGridView_RAA";
            this.dataGridView_RAA.RowHeadersVisible = false;
            this.dataGridView_RAA.RowHeadersWidth = 51;
            this.dataGridView_RAA.RowTemplate.Height = 24;
            this.dataGridView_RAA.Size = new System.Drawing.Size(994, 552);
            this.dataGridView_RAA.TabIndex = 0;
            // 
            // openFileDialog_RAA
            // 
            this.openFileDialog_RAA.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label1";
            // 
            // FormVariants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSortBySubject_RAA);
            this.Controls.Add(this.buttonSortKafedra_RAA);
            this.Controls.Add(this.buttonSortAlph_RAA);
            this.Controls.Add(this.buttonSaveFile_RAA);
            this.Controls.Add(this.buttonReadFile_RAA);
            this.Controls.Add(this.dataGridView_RAA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FormVariants";
            this.Text = "Ищем преподователя";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip_RAA;
        private System.Windows.Forms.DataGridView dataGridView_RAA;
        private System.Windows.Forms.Button buttonReadFile_RAA;
        private System.Windows.Forms.Button buttonSortAlph_RAA;
        private System.Windows.Forms.Button buttonSortKafedra_RAA;
        private System.Windows.Forms.Button buttonSortBySubject_RAA;
        private System.Windows.Forms.Button buttonSaveFile_RAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_RAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_RAA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}