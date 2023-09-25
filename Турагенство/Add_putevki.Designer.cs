namespace Турагенство
{
    partial class Add_putevki
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.турыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.турыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.kyrsDataSet6 = new Турагенство.kyrsDataSet6();
            this.турыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.турыTableAdapter = new Турагенство.kyrsDataSet6TableAdapters.ТурыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(37, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление путёвки";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(37, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 38);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название путёвки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(135, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тур";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.турыBindingSource2;
            this.comboBox1.DisplayMember = "Название_тура";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 39);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "ID_Тура";
            // 
            // турыBindingSource1
            // 
            this.турыBindingSource1.DataMember = "Туры";
            // 
            // турыBindingSource
            // 
            this.турыBindingSource.DataMember = "Туры";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(37, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Добавить путёвку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kyrsDataSet6
            // 
            this.kyrsDataSet6.DataSetName = "kyrsDataSet6";
            this.kyrsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // турыBindingSource2
            // 
            this.турыBindingSource2.DataMember = "Туры";
            this.турыBindingSource2.DataSource = this.kyrsDataSet6;
            // 
            // турыTableAdapter
            // 
            this.турыTableAdapter.ClearBeforeFill = true;
            // 
            // Add_putevki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(326, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Add_putevki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_putevki";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_putevki_FormClosed);
            this.Load += new System.EventHandler(this.Add_putevki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
      
        private System.Windows.Forms.BindingSource турыBindingSource;
       
        private System.Windows.Forms.Button button2;
    
        private System.Windows.Forms.BindingSource турыBindingSource1;
        private kyrsDataSet6 kyrsDataSet6;
        private System.Windows.Forms.BindingSource турыBindingSource2;
        private kyrsDataSet6TableAdapters.ТурыTableAdapter турыTableAdapter;
    }
}