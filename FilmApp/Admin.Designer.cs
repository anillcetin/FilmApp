
namespace FilmApp
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilmId = new System.Windows.Forms.TextBox();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.txtFilmTur = new System.Windows.Forms.TextBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.txtYapimYili = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.filmAppDataSet2 = new FilmApp.FilmAppDataSet2();
            this.filmbilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.film_bilgiTableAdapter = new FilmApp.FilmAppDataSet2TableAdapters.film_bilgiTableAdapter();
            this.filmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yonetmenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yapimyiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmkonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmresimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmAppDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmbilgiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.txtYapimYili);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtKonu);
            this.groupBox1.Controls.Add(this.txtYonetmen);
            this.groupBox1.Controls.Add(this.txtFilmTur);
            this.groupBox1.Controls.Add(this.txtFilmAd);
            this.groupBox1.Controls.Add(this.txtFilmId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 559);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film Tür:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yönetmen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Konusu:";
            // 
            // txtFilmId
            // 
            this.txtFilmId.ForeColor = System.Drawing.Color.Teal;
            this.txtFilmId.Location = new System.Drawing.Point(151, 78);
            this.txtFilmId.Name = "txtFilmId";
            this.txtFilmId.Size = new System.Drawing.Size(265, 34);
            this.txtFilmId.TabIndex = 5;
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.ForeColor = System.Drawing.Color.Teal;
            this.txtFilmAd.Location = new System.Drawing.Point(151, 142);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(265, 34);
            this.txtFilmAd.TabIndex = 6;
            // 
            // txtFilmTur
            // 
            this.txtFilmTur.ForeColor = System.Drawing.Color.Teal;
            this.txtFilmTur.Location = new System.Drawing.Point(151, 206);
            this.txtFilmTur.Name = "txtFilmTur";
            this.txtFilmTur.Size = new System.Drawing.Size(265, 34);
            this.txtFilmTur.TabIndex = 7;
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.ForeColor = System.Drawing.Color.Teal;
            this.txtYonetmen.Location = new System.Drawing.Point(151, 270);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(265, 34);
            this.txtYonetmen.TabIndex = 8;
            // 
            // txtKonu
            // 
            this.txtKonu.ForeColor = System.Drawing.Color.Teal;
            this.txtKonu.Location = new System.Drawing.Point(151, 390);
            this.txtKonu.Multiline = true;
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(265, 134);
            this.txtKonu.TabIndex = 9;
            // 
            // txtYapimYili
            // 
            this.txtYapimYili.ForeColor = System.Drawing.Color.Teal;
            this.txtYapimYili.Location = new System.Drawing.Point(151, 330);
            this.txtYapimYili.Name = "txtYapimYili";
            this.txtYapimYili.Size = new System.Drawing.Size(265, 34);
            this.txtYapimYili.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Yapım Yılı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(771, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 559);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(63, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(63, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(242, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(63, 386);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(242, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "Temizle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(63, 466);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(242, 44);
            this.button6.TabIndex = 5;
            this.button6.Text = "İstatistik";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmidDataGridViewTextBoxColumn,
            this.filmadDataGridViewTextBoxColumn,
            this.filmturDataGridViewTextBoxColumn,
            this.yonetmenDataGridViewTextBoxColumn,
            this.yapimyiliDataGridViewTextBoxColumn,
            this.filmkonuDataGridViewTextBoxColumn,
            this.filmresimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmbilgiBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(26, 587);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 185);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(481, 78);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 81);
            this.button7.TabIndex = 12;
            this.button7.Text = "Resim Ekle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(481, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // filmAppDataSet2
            // 
            this.filmAppDataSet2.DataSetName = "FilmAppDataSet2";
            this.filmAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmbilgiBindingSource
            // 
            this.filmbilgiBindingSource.DataMember = "film_bilgi";
            this.filmbilgiBindingSource.DataSource = this.filmAppDataSet2;
            // 
            // film_bilgiTableAdapter
            // 
            this.film_bilgiTableAdapter.ClearBeforeFill = true;
            // 
            // filmidDataGridViewTextBoxColumn
            // 
            this.filmidDataGridViewTextBoxColumn.DataPropertyName = "filmid";
            this.filmidDataGridViewTextBoxColumn.HeaderText = "filmid";
            this.filmidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmidDataGridViewTextBoxColumn.Name = "filmidDataGridViewTextBoxColumn";
            this.filmidDataGridViewTextBoxColumn.ReadOnly = true;
            this.filmidDataGridViewTextBoxColumn.Width = 125;
            // 
            // filmadDataGridViewTextBoxColumn
            // 
            this.filmadDataGridViewTextBoxColumn.DataPropertyName = "filmad";
            this.filmadDataGridViewTextBoxColumn.HeaderText = "filmad";
            this.filmadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmadDataGridViewTextBoxColumn.Name = "filmadDataGridViewTextBoxColumn";
            this.filmadDataGridViewTextBoxColumn.Width = 125;
            // 
            // filmturDataGridViewTextBoxColumn
            // 
            this.filmturDataGridViewTextBoxColumn.DataPropertyName = "filmtur";
            this.filmturDataGridViewTextBoxColumn.HeaderText = "filmtur";
            this.filmturDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmturDataGridViewTextBoxColumn.Name = "filmturDataGridViewTextBoxColumn";
            this.filmturDataGridViewTextBoxColumn.Width = 125;
            // 
            // yonetmenDataGridViewTextBoxColumn
            // 
            this.yonetmenDataGridViewTextBoxColumn.DataPropertyName = "yonetmen";
            this.yonetmenDataGridViewTextBoxColumn.HeaderText = "yonetmen";
            this.yonetmenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yonetmenDataGridViewTextBoxColumn.Name = "yonetmenDataGridViewTextBoxColumn";
            this.yonetmenDataGridViewTextBoxColumn.Width = 125;
            // 
            // yapimyiliDataGridViewTextBoxColumn
            // 
            this.yapimyiliDataGridViewTextBoxColumn.DataPropertyName = "yapimyili";
            this.yapimyiliDataGridViewTextBoxColumn.HeaderText = "yapimyili";
            this.yapimyiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yapimyiliDataGridViewTextBoxColumn.Name = "yapimyiliDataGridViewTextBoxColumn";
            this.yapimyiliDataGridViewTextBoxColumn.Width = 125;
            // 
            // filmkonuDataGridViewTextBoxColumn
            // 
            this.filmkonuDataGridViewTextBoxColumn.DataPropertyName = "filmkonu";
            this.filmkonuDataGridViewTextBoxColumn.HeaderText = "filmkonu";
            this.filmkonuDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.filmkonuDataGridViewTextBoxColumn.Name = "filmkonuDataGridViewTextBoxColumn";
            this.filmkonuDataGridViewTextBoxColumn.Width = 125;
            // 
            // filmresimDataGridViewTextBoxColumn
            // 
            this.filmresimDataGridViewTextBoxColumn.DataPropertyName = "filmresim";
            this.filmresimDataGridViewTextBoxColumn.HeaderText = "filmresim";
            this.filmresimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmresimDataGridViewTextBoxColumn.Name = "filmresimDataGridViewTextBoxColumn";
            this.filmresimDataGridViewTextBoxColumn.Width = 125;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Teal;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.Honeydew;
            this.button8.Location = new System.Drawing.Point(224, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 48);
            this.button8.TabIndex = 6;
            this.button8.Text = "←";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1144, 784);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmAppDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmbilgiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.TextBox txtFilmTur;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.TextBox txtFilmId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYapimYili;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FilmAppDataSet2 filmAppDataSet2;
        private System.Windows.Forms.BindingSource filmbilgiBindingSource;
        private FilmAppDataSet2TableAdapters.film_bilgiTableAdapter film_bilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yonetmenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yapimyiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmkonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmresimDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button8;
    }
}