namespace WinFormsApp1.Forms
{
    partial class OgrenciGuncelle
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            studentIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentSurnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentImageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentsBindingSource = new BindingSource(components);
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(519, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 188);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci";
            // 
            // button2
            // 
            button2.Location = new Point(225, 139);
            button2.Name = "button2";
            button2.Size = new Size(28, 23);
            button2.TabIndex = 8;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(86, 23);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(133, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 26);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 6;
            label4.Text = "ID:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(86, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 142);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "FOTOĞRAF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 101);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "SOYAD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 61);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 0;
            label1.Text = "AD:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentIDDataGridViewTextBoxColumn, studentNameDataGridViewTextBoxColumn, studentSurnameDataGridViewTextBoxColumn, studentImageDataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentsBindingSource;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(12, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(461, 150);
            dataGridView1.TabIndex = 2;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            // 
            // studentImageDataGridViewTextBoxColumn
            // 
            studentImageDataGridViewTextBoxColumn.DataPropertyName = "StudentImage";
            studentImageDataGridViewTextBoxColumn.HeaderText = "StudentImage";
            studentImageDataGridViewTextBoxColumn.Name = "studentImageDataGridViewTextBoxColumn";
            // 
            // studentsBindingSource
            // 
            studentsBindingSource.DataSource = typeof(DbContextStudent.Students);
            // 
            // button1
            // 
            button1.Location = new Point(614, 254);
            button1.Name = "button1";
            button1.Size = new Size(133, 23);
            button1.TabIndex = 6;
            button1.Text = "Bilgileri Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // OgrenciGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "OgrenciGuncelle";
            Text = "OgrenciGuncelle";
            Load += OgrenciGuncelle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentImageDataGridViewTextBoxColumn;
        private BindingSource studentsBindingSource;
        private TextBox textBox4;
        private Label label4;
        private Button button2;
        private OpenFileDialog openFileDialog1;
    }
}