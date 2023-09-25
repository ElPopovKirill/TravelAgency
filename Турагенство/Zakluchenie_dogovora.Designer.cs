namespace Турагенство
{
    partial class Zakluchenie_dogovora
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.статусыоплатыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.статусыоплатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kyrsDataSet10 = new Турагенство.kyrsDataSet10();
            this.статусыоплатыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.статусы_оплатыTableAdapter = new Турагенство.kyrsDataSet10TableAdapters.Статусы_оплатыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.статусыоплатыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусыоплатыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусыоплатыBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(829, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(987, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить договор";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(302, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(347, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Изменить статус оплаты";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(655, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(364, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 149);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Статус оплаты";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.статусыоплатыBindingSource2;
            this.comboBox1.DisplayMember = "Статус_оплаты";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 39);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ID_Статуса_оплаты";
            // 
            // статусыоплатыBindingSource1
            // 
            this.статусыоплатыBindingSource1.DataMember = "Статусы_оплаты";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(17, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "Подтвердить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // статусыоплатыBindingSource
            // 
            this.статусыоплатыBindingSource.DataMember = "Статусы_оплаты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(434, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Договора";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Турагенство.Properties.Resources.gratis_png_documento_contrato_firma_certificacion_plagio_thumbnail1;
            this.pictureBox1.Location = new System.Drawing.Point(768, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // kyrsDataSet10
            // 
            this.kyrsDataSet10.DataSetName = "kyrsDataSet10";
            this.kyrsDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // статусыоплатыBindingSource2
            // 
            this.статусыоплатыBindingSource2.DataMember = "Статусы_оплаты";
            this.статусыоплатыBindingSource2.DataSource = this.kyrsDataSet10;
            // 
            // статусы_оплатыTableAdapter
            // 
            this.статусы_оплатыTableAdapter.ClearBeforeFill = true;
            // 
            // Zakluchenie_dogovora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1016, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Zakluchenie_dogovora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zakluchenie_dogovora";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Zakluchenie_dogovora_FormClosed);
            this.Load += new System.EventHandler(this.Zakluchenie_dogovora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.статусыоплатыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусыоплатыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусыоплатыBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
     
        private System.Windows.Forms.BindingSource статусыоплатыBindingSource;
 
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
     
        private System.Windows.Forms.BindingSource статусыоплатыBindingSource1;
        private kyrsDataSet10 kyrsDataSet10;
        private System.Windows.Forms.BindingSource статусыоплатыBindingSource2;
        private kyrsDataSet10TableAdapters.Статусы_оплатыTableAdapter статусы_оплатыTableAdapter;
    }
}