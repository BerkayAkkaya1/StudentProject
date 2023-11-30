namespace WinFormsApp1.Forms
{
    partial class DersListesi
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            lessonIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lessonNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lessonsBindingSource = new BindingSource(components);
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lessonsBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { lessonIDDataGridViewTextBoxColumn, lessonNameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = lessonsBindingSource;
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(145, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(243, 153);
            dataGridView1.TabIndex = 0;
            // 
            // lessonIDDataGridViewTextBoxColumn
            // 
            lessonIDDataGridViewTextBoxColumn.DataPropertyName = "LessonID";
            lessonIDDataGridViewTextBoxColumn.HeaderText = "LessonID";
            lessonIDDataGridViewTextBoxColumn.Name = "lessonIDDataGridViewTextBoxColumn";
            // 
            // lessonNameDataGridViewTextBoxColumn
            // 
            lessonNameDataGridViewTextBoxColumn.DataPropertyName = "LessonName";
            lessonNameDataGridViewTextBoxColumn.HeaderText = "LessonName";
            lessonNameDataGridViewTextBoxColumn.Name = "lessonNameDataGridViewTextBoxColumn";
            // 
            // lessonsBindingSource
            // 
            lessonsBindingSource.DataSource = typeof(DbContextStudent.Lessons);
            // 
            // button1
            // 
            button1.Location = new Point(279, 332);
            button1.Name = "button1";
            button1.Size = new Size(223, 57);
            button1.TabIndex = 1;
            button1.Text = "Ders Listesini Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(279, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 60);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dersler";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "DERS ADI:";
            // 
            // DersListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "DersListesi";
            Text = "DersListesi";
            Load += DersListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lessonsBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private DataGridViewTextBoxColumn lessonIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lessonNameDataGridViewTextBoxColumn;
        private BindingSource lessonsBindingSource;
    }
}