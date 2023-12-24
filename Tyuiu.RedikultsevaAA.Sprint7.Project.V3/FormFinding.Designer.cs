
namespace Tyuiu.RedikultsevaAA.Sprint7.Project.V3
{
    partial class FormFinding
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
            this.buttonFiltrKafedra_RAA = new System.Windows.Forms.Button();
            this.buttonFiltrBySubject_RAA = new System.Windows.Forms.Button();
            this.buttonSaveFile_RAA = new System.Windows.Forms.Button();
            this.dataGridView_RAA = new System.Windows.Forms.DataGridView();
            this.openFileDialog_RAA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_RAA = new System.Windows.Forms.SaveFileDialog();
            this.labelFiltrKaf_RAA = new System.Windows.Forms.Label();
            this.labelFiltrRazd_RAA = new System.Windows.Forms.Label();
            this.textBoxFiltr_RAA = new System.Windows.Forms.TextBox();
            this.textBoxFiltrRazd_RAA = new System.Windows.Forms.TextBox();
            this.labelFIO_RAA = new System.Windows.Forms.Label();
            this.buttonSearch_RAA = new System.Windows.Forms.Button();
            this.textBoxSearch_RAA = new System.Windows.Forms.TextBox();
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
            this.buttonReadFile_RAA.Size = new System.Drawing.Size(120, 60);
            this.buttonReadFile_RAA.TabIndex = 1;
            this.buttonReadFile_RAA.Text = "READ FILE";
            this.toolTip_RAA.SetToolTip(this.buttonReadFile_RAA, "Прочитать файл");
            this.buttonReadFile_RAA.UseVisualStyleBackColor = false;
            this.buttonReadFile_RAA.Click += new System.EventHandler(this.buttonReadFile_RAA_Click);
            // 
            // buttonSortAlph_RAA
            // 
            this.buttonSortAlph_RAA.BackColor = System.Drawing.Color.Bisque;
            this.buttonSortAlph_RAA.Enabled = false;
            this.buttonSortAlph_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortAlph_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonSortAlph_RAA.Location = new System.Drawing.Point(27, 124);
            this.buttonSortAlph_RAA.Name = "buttonSortAlph_RAA";
            this.buttonSortAlph_RAA.Size = new System.Drawing.Size(120, 60);
            this.buttonSortAlph_RAA.TabIndex = 1;
            this.buttonSortAlph_RAA.Text = "Сортировка по алфовиту";
            this.toolTip_RAA.SetToolTip(this.buttonSortAlph_RAA, "Отсортировать таблицу по алфовиту");
            this.buttonSortAlph_RAA.UseVisualStyleBackColor = false;
            this.buttonSortAlph_RAA.Click += new System.EventHandler(this.buttonSortAlph_RAA_Click);
            // 
            // buttonFiltrKafedra_RAA
            // 
            this.buttonFiltrKafedra_RAA.BackColor = System.Drawing.Color.Bisque;
            this.buttonFiltrKafedra_RAA.Enabled = false;
            this.buttonFiltrKafedra_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltrKafedra_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonFiltrKafedra_RAA.Location = new System.Drawing.Point(27, 315);
            this.buttonFiltrKafedra_RAA.Name = "buttonFiltrKafedra_RAA";
            this.buttonFiltrKafedra_RAA.Size = new System.Drawing.Size(120, 60);
            this.buttonFiltrKafedra_RAA.TabIndex = 1;
            this.buttonFiltrKafedra_RAA.Text = "Фильтрация по кафедре";
            this.toolTip_RAA.SetToolTip(this.buttonFiltrKafedra_RAA, "Отфильтровать таблицу по кафедре, \r\nк которой относится преподователь");
            this.buttonFiltrKafedra_RAA.UseVisualStyleBackColor = false;
            this.buttonFiltrKafedra_RAA.Click += new System.EventHandler(this.buttonFiltrKafedra_RAA_Click);
            // 
            // buttonFiltrBySubject_RAA
            // 
            this.buttonFiltrBySubject_RAA.BackColor = System.Drawing.Color.Bisque;
            this.buttonFiltrBySubject_RAA.Enabled = false;
            this.buttonFiltrBySubject_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltrBySubject_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonFiltrBySubject_RAA.Location = new System.Drawing.Point(28, 510);
            this.buttonFiltrBySubject_RAA.Name = "buttonFiltrBySubject_RAA";
            this.buttonFiltrBySubject_RAA.Size = new System.Drawing.Size(120, 60);
            this.buttonFiltrBySubject_RAA.TabIndex = 1;
            this.buttonFiltrBySubject_RAA.Text = "Фильтрация по разделу";
            this.toolTip_RAA.SetToolTip(this.buttonFiltrBySubject_RAA, "Отсфильтровать таблицу по разделу предмета, \r\nкоторому учит преподаватель");
            this.buttonFiltrBySubject_RAA.UseVisualStyleBackColor = false;
            this.buttonFiltrBySubject_RAA.Click += new System.EventHandler(this.buttonFiltrBySubject_RAA_Click);
            // 
            // buttonSaveFile_RAA
            // 
            this.buttonSaveFile_RAA.BackColor = System.Drawing.Color.Bisque;
            this.buttonSaveFile_RAA.Enabled = false;
            this.buttonSaveFile_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonSaveFile_RAA.Location = new System.Drawing.Point(1050, 12);
            this.buttonSaveFile_RAA.Name = "buttonSaveFile_RAA";
            this.buttonSaveFile_RAA.Size = new System.Drawing.Size(120, 60);
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
            // labelFiltrKaf_RAA
            // 
            this.labelFiltrKaf_RAA.AutoSize = true;
            this.labelFiltrKaf_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelFiltrKaf_RAA.Location = new System.Drawing.Point(26, 250);
            this.labelFiltrKaf_RAA.Name = "labelFiltrKaf_RAA";
            this.labelFiltrKaf_RAA.Size = new System.Drawing.Size(133, 34);
            this.labelFiltrKaf_RAA.TabIndex = 2;
            this.labelFiltrKaf_RAA.Text = "Введите название \r\n        кафедры";
            // 
            // labelFiltrRazd_RAA
            // 
            this.labelFiltrRazd_RAA.AutoSize = true;
            this.labelFiltrRazd_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelFiltrRazd_RAA.Location = new System.Drawing.Point(24, 445);
            this.labelFiltrRazd_RAA.Name = "labelFiltrRazd_RAA";
            this.labelFiltrRazd_RAA.Size = new System.Drawing.Size(129, 34);
            this.labelFiltrRazd_RAA.TabIndex = 2;
            this.labelFiltrRazd_RAA.Text = "Введите название\r\n         раздела";
            // 
            // textBoxFiltr_RAA
            // 
            this.textBoxFiltr_RAA.BackColor = System.Drawing.Color.White;
            this.textBoxFiltr_RAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFiltr_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBoxFiltr_RAA.Location = new System.Drawing.Point(27, 287);
            this.textBoxFiltr_RAA.Name = "textBoxFiltr_RAA";
            this.textBoxFiltr_RAA.Size = new System.Drawing.Size(120, 22);
            this.textBoxFiltr_RAA.TabIndex = 3;
            // 
            // textBoxFiltrRazd_RAA
            // 
            this.textBoxFiltrRazd_RAA.BackColor = System.Drawing.Color.White;
            this.textBoxFiltrRazd_RAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFiltrRazd_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBoxFiltrRazd_RAA.Location = new System.Drawing.Point(29, 482);
            this.textBoxFiltrRazd_RAA.Name = "textBoxFiltrRazd_RAA";
            this.textBoxFiltrRazd_RAA.Size = new System.Drawing.Size(120, 22);
            this.textBoxFiltrRazd_RAA.TabIndex = 3;
            // 
            // labelFIO_RAA
            // 
            this.labelFIO_RAA.AutoSize = true;
            this.labelFIO_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelFIO_RAA.Location = new System.Drawing.Point(377, 9);
            this.labelFIO_RAA.Name = "labelFIO_RAA";
            this.labelFIO_RAA.Size = new System.Drawing.Size(215, 34);
            this.labelFIO_RAA.TabIndex = 4;
            this.labelFIO_RAA.Text = "Введите ФИО преподователя, \r\n            чтобы его найти";
            // 
            // buttonSearch_RAA
            // 
            this.buttonSearch_RAA.BackColor = System.Drawing.Color.Bisque;
            this.buttonSearch_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonSearch_RAA.Location = new System.Drawing.Point(614, 12);
            this.buttonSearch_RAA.Name = "buttonSearch_RAA";
            this.buttonSearch_RAA.Size = new System.Drawing.Size(120, 60);
            this.buttonSearch_RAA.TabIndex = 5;
            this.buttonSearch_RAA.Text = "Поиск по ФИО";
            this.toolTip_RAA.SetToolTip(this.buttonSearch_RAA, "Введите полное ФИО преподователя,\r\nчтобы его/её найти");
            this.buttonSearch_RAA.UseVisualStyleBackColor = false;
            this.buttonSearch_RAA.Click += new System.EventHandler(this.buttonSearch_RAA_Click);
            // 
            // textBoxSearch_RAA
            // 
            this.textBoxSearch_RAA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBoxSearch_RAA.Location = new System.Drawing.Point(357, 50);
            this.textBoxSearch_RAA.Name = "textBoxSearch_RAA";
            this.textBoxSearch_RAA.Size = new System.Drawing.Size(251, 22);
            this.textBoxSearch_RAA.TabIndex = 6;
            // 
            // FormFinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.textBoxSearch_RAA);
            this.Controls.Add(this.buttonSearch_RAA);
            this.Controls.Add(this.labelFIO_RAA);
            this.Controls.Add(this.textBoxFiltrRazd_RAA);
            this.Controls.Add(this.textBoxFiltr_RAA);
            this.Controls.Add(this.labelFiltrRazd_RAA);
            this.Controls.Add(this.labelFiltrKaf_RAA);
            this.Controls.Add(this.buttonFiltrBySubject_RAA);
            this.Controls.Add(this.buttonFiltrKafedra_RAA);
            this.Controls.Add(this.buttonSortAlph_RAA);
            this.Controls.Add(this.buttonSaveFile_RAA);
            this.Controls.Add(this.buttonReadFile_RAA);
            this.Controls.Add(this.dataGridView_RAA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FormFinding";
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
        private System.Windows.Forms.Button buttonFiltrKafedra_RAA;
        private System.Windows.Forms.Button buttonFiltrBySubject_RAA;
        private System.Windows.Forms.Button buttonSaveFile_RAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_RAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_RAA;
        private System.Windows.Forms.Label labelFiltrKaf_RAA;
        private System.Windows.Forms.Label labelFiltrRazd_RAA;
        private System.Windows.Forms.TextBox textBoxFiltr_RAA;
        private System.Windows.Forms.TextBox textBoxFiltrRazd_RAA;
        private System.Windows.Forms.Label labelFIO_RAA;
        private System.Windows.Forms.Button buttonSearch_RAA;
        private System.Windows.Forms.TextBox textBoxSearch_RAA;
    }
}