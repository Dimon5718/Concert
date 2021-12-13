namespace CONCERTS
{
    partial class Kategorii_sotrudnicov
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idKategoriisotrudnikovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovaniekategoriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriisotrudnikovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concertDataSet = new CONCERTS.ConcertDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kategorii_sotrudnikovTableAdapter = new CONCERTS.ConcertDataSetTableAdapters.Kategorii_sotrudnikovTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriisotrudnikovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 26);
            this.label4.TabIndex = 79;
            this.label4.Text = "Наименование категории:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 26);
            this.textBox1.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(532, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 77;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(703, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 38);
            this.button3.TabIndex = 76;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(581, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 38);
            this.button2.TabIndex = 75;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(459, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 38);
            this.button4.TabIndex = 74;
            this.button4.Text = "INSERT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKategoriisotrudnikovDataGridViewTextBoxColumn,
            this.naimenovaniekategoriiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kategoriisotrudnikovBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(459, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(360, 267);
            this.dataGridView1.TabIndex = 73;
            // 
            // idKategoriisotrudnikovDataGridViewTextBoxColumn
            // 
            this.idKategoriisotrudnikovDataGridViewTextBoxColumn.DataPropertyName = "Id_Kategorii_sotrudnikov";
            this.idKategoriisotrudnikovDataGridViewTextBoxColumn.HeaderText = "Id_Kategorii_sotrudnikov";
            this.idKategoriisotrudnikovDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idKategoriisotrudnikovDataGridViewTextBoxColumn.Name = "idKategoriisotrudnikovDataGridViewTextBoxColumn";
            this.idKategoriisotrudnikovDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKategoriisotrudnikovDataGridViewTextBoxColumn.Width = 150;
            // 
            // naimenovaniekategoriiDataGridViewTextBoxColumn
            // 
            this.naimenovaniekategoriiDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie_kategorii";
            this.naimenovaniekategoriiDataGridViewTextBoxColumn.HeaderText = "Naimenovanie_kategorii";
            this.naimenovaniekategoriiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.naimenovaniekategoriiDataGridViewTextBoxColumn.Name = "naimenovaniekategoriiDataGridViewTextBoxColumn";
            this.naimenovaniekategoriiDataGridViewTextBoxColumn.Width = 150;
            // 
            // kategoriisotrudnikovBindingSource
            // 
            this.kategoriisotrudnikovBindingSource.DataMember = "Kategorii_sotrudnikov";
            this.kategoriisotrudnikovBindingSource.DataSource = this.concertDataSet;
            // 
            // concertDataSet
            // 
            this.concertDataSet.DataSetName = "ConcertDataSet";
            this.concertDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(719, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 72;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 45);
            this.label1.TabIndex = 71;
            this.label1.Text = "Категория сотрудников";
            // 
            // kategorii_sotrudnikovTableAdapter
            // 
            this.kategorii_sotrudnikovTableAdapter.ClearBeforeFill = true;
            // 
            // Kategorii_sotrudnicov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(831, 399);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Kategorii_sotrudnicov";
            this.Text = "Kategorii_sotrudnicov";
            this.Load += new System.EventHandler(this.Kategorii_sotrudnicov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriisotrudnikovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private ConcertDataSet concertDataSet;
        private System.Windows.Forms.BindingSource kategoriisotrudnikovBindingSource;
        private ConcertDataSetTableAdapters.Kategorii_sotrudnikovTableAdapter kategorii_sotrudnikovTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKategoriisotrudnikovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovaniekategoriiDataGridViewTextBoxColumn;
    }
}