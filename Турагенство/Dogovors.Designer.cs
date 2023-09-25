namespace Турагенство
{
    partial class Dogovors
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.статусыоплатыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.статусыоплатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyrsDataSet1 = new Турагенство.kyrsDataSet1();
            this.статусы_оплатыTableAdapter = new Турагенство.kyrsDataSet1TableAdapters.Статусы_оплатыTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.kyrsDataSet8 = new Турагенство.kyrsDataSet8();
            this.статусыоплатыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.статусы_оплатыTableAdapter1 = new Турагенство.kyrsDataSet8TableAdapters.Статусы_оплатыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусыоплатыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусыоплатыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусыоплатыBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(928, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 49);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1032, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Информация о заключенных договорах";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.статусыоплатыBindingSource2;
            this.comboBox1.DisplayMember = "Статус_оплаты";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 216);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 39);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "ID_Статуса_оплаты";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // статусыоплатыBindingSource1
            // 
            this.статусыоплатыBindingSource1.DataMember = "Статусы_оплаты";
            // 
            // статусыоплатыBindingSource
            // 
            this.статусыоплатыBindingSource.DataMember = "Статусы_оплаты";
            this.статусыоплатыBindingSource.DataSource = this.kyrsDataSet1;
            // 
            // kyrsDataSet1
            // 
            this.kyrsDataSet1.DataSetName = "kyrsDataSet1";
            this.kyrsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // статусы_оплатыTableAdapter
            // 
            this.статусы_оплатыTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(203, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Все договора";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kyrsDataSet8
            // 
            this.kyrsDataSet8.DataSetName = "kyrsDataSet8";
            this.kyrsDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // статусыоплатыBindingSource2
            // 
            this.статусыоплатыBindingSource2.DataMember = "Статусы_оплаты";
            this.статусыоплатыBindingSource2.DataSource = this.kyrsDataSet8;
            // 
            // статусы_оплатыTableAdapter1
            // 
            this.статусы_оплатыTableAdapter1.ClearBeforeFill = true;
            // 
            // Dogovors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1064, 289);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Dogovors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dogovors";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dogovors_FormClosed);
            this.Load += new System.EventHandler(this.Dogovors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусыоплатыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусыоплатыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусыоплатыBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private kyrsDataSet1 kyrsDataSet1;
        private System.Windows.Forms.BindingSource статусыоплатыBindingSource;
        private kyrsDataSet1TableAdapters.Статусы_оплатыTableAdapter статусы_оплатыTableAdapter;
        private System.Windows.Forms.Button button2;
      
        private System.Windows.Forms.BindingSource статусыоплатыBindingSource1;
        private kyrsDataSet8 kyrsDataSet8;
        private System.Windows.Forms.BindingSource статусыоплатыBindingSource2;
        private kyrsDataSet8TableAdapters.Статусы_оплатыTableAdapter статусы_оплатыTableAdapter1;
    }
}