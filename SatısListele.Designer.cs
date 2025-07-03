namespace GASOLINA
{
    partial class frmSatısListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatısListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartsifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uchaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gASOLINADataSet44 = new GASOLINA.GASOLINADataSet44();
            this.gASOLINADataSet42 = new GASOLINA.GASOLINADataSet42();
            this.satisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satisTableAdapter = new GASOLINA.GASOLINADataSet42TableAdapters.satisTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisTableAdapter1 = new GASOLINA.GASOLINADataSet44TableAdapters.satisTableAdapter();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gASOLINADataSet44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gASOLINADataSet42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adsoyadDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.telnoDataGridViewTextBoxColumn,
            this.kartDataGridViewTextBoxColumn,
            this.kartsifreDataGridViewTextBoxColumn,
            this.uchaneDataGridViewTextBoxColumn,
            this.urunkoduDataGridViewTextBoxColumn,
            this.urunadiDataGridViewTextBoxColumn,
            this.miktariDataGridViewTextBoxColumn,
            this.satisfiyatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.satisBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1065, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "eposta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "eposta";
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            // 
            // telnoDataGridViewTextBoxColumn
            // 
            this.telnoDataGridViewTextBoxColumn.DataPropertyName = "telno";
            this.telnoDataGridViewTextBoxColumn.HeaderText = "telno";
            this.telnoDataGridViewTextBoxColumn.Name = "telnoDataGridViewTextBoxColumn";
            // 
            // kartDataGridViewTextBoxColumn
            // 
            this.kartDataGridViewTextBoxColumn.DataPropertyName = "kart";
            this.kartDataGridViewTextBoxColumn.HeaderText = "kart";
            this.kartDataGridViewTextBoxColumn.Name = "kartDataGridViewTextBoxColumn";
            // 
            // kartsifreDataGridViewTextBoxColumn
            // 
            this.kartsifreDataGridViewTextBoxColumn.DataPropertyName = "kartsifre";
            this.kartsifreDataGridViewTextBoxColumn.HeaderText = "kartsifre";
            this.kartsifreDataGridViewTextBoxColumn.Name = "kartsifreDataGridViewTextBoxColumn";
            // 
            // uchaneDataGridViewTextBoxColumn
            // 
            this.uchaneDataGridViewTextBoxColumn.DataPropertyName = "uchane";
            this.uchaneDataGridViewTextBoxColumn.HeaderText = "uchane";
            this.uchaneDataGridViewTextBoxColumn.Name = "uchaneDataGridViewTextBoxColumn";
            // 
            // urunkoduDataGridViewTextBoxColumn
            // 
            this.urunkoduDataGridViewTextBoxColumn.DataPropertyName = "urunkodu";
            this.urunkoduDataGridViewTextBoxColumn.HeaderText = "urunkodu";
            this.urunkoduDataGridViewTextBoxColumn.Name = "urunkoduDataGridViewTextBoxColumn";
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            // 
            // miktariDataGridViewTextBoxColumn
            // 
            this.miktariDataGridViewTextBoxColumn.DataPropertyName = "miktari";
            this.miktariDataGridViewTextBoxColumn.HeaderText = "miktari";
            this.miktariDataGridViewTextBoxColumn.Name = "miktariDataGridViewTextBoxColumn";
            // 
            // satisfiyatiDataGridViewTextBoxColumn
            // 
            this.satisfiyatiDataGridViewTextBoxColumn.DataPropertyName = "satisfiyati";
            this.satisfiyatiDataGridViewTextBoxColumn.HeaderText = "satisfiyati";
            this.satisfiyatiDataGridViewTextBoxColumn.Name = "satisfiyatiDataGridViewTextBoxColumn";
            // 
            // satisBindingSource1
            // 
            this.satisBindingSource1.DataMember = "satis";
            this.satisBindingSource1.DataSource = this.gASOLINADataSet44;
            // 
            // gASOLINADataSet44
            // 
            this.gASOLINADataSet44.DataSetName = "GASOLINADataSet44";
            this.gASOLINADataSet44.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gASOLINADataSet42
            // 
            this.gASOLINADataSet42.DataSetName = "GASOLINADataSet42";
            this.gASOLINADataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisBindingSource
            // 
            this.satisBindingSource.DataMember = "satis";
            this.satisBindingSource.DataSource = this.gASOLINADataSet42;
            // 
            // satisTableAdapter
            // 
            this.satisTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "adsoyad";
            this.dataGridViewTextBoxColumn1.HeaderText = "adsoyad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "eposta";
            this.dataGridViewTextBoxColumn2.HeaderText = "eposta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "telno";
            this.dataGridViewTextBoxColumn3.HeaderText = "telno";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "kart";
            this.dataGridViewTextBoxColumn4.HeaderText = "kart";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "kartsifre";
            this.dataGridViewTextBoxColumn5.HeaderText = "kartsifre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "uchane";
            this.dataGridViewTextBoxColumn6.HeaderText = "uchane";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "barkodno";
            this.dataGridViewTextBoxColumn7.HeaderText = "barkodno";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "urunadi";
            this.dataGridViewTextBoxColumn8.HeaderText = "urunadi";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "miktari";
            this.dataGridViewTextBoxColumn9.HeaderText = "miktari";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "satisfiyati";
            this.dataGridViewTextBoxColumn10.HeaderText = "satisfiyati";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "toplamfiyat";
            this.dataGridViewTextBoxColumn11.HeaderText = "toplamfiyat";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // satisTableAdapter1
            // 
            this.satisTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "adsoyad";
            this.dataGridViewTextBoxColumn12.HeaderText = "adsoyad";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "eposta";
            this.dataGridViewTextBoxColumn13.HeaderText = "eposta";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "telno";
            this.dataGridViewTextBoxColumn14.HeaderText = "telno";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "kart";
            this.dataGridViewTextBoxColumn15.HeaderText = "kart";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "kartsifre";
            this.dataGridViewTextBoxColumn16.HeaderText = "kartsifre";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "uchane";
            this.dataGridViewTextBoxColumn17.HeaderText = "uchane";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "urunkodu";
            this.dataGridViewTextBoxColumn18.HeaderText = "urunkodu";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "urunadi";
            this.dataGridViewTextBoxColumn19.HeaderText = "urunadi";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "miktari";
            this.dataGridViewTextBoxColumn20.HeaderText = "miktari";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "satisfiyati";
            this.dataGridViewTextBoxColumn21.HeaderText = "satisfiyati";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "toplamfiyat";
            this.dataGridViewTextBoxColumn22.HeaderText = "toplamfiyat";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1003, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSatısListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatısListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmSatısListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gASOLINADataSet44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gASOLINADataSet42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GASOLINADataSet42 gASOLINADataSet42;
        private System.Windows.Forms.BindingSource satisBindingSource;
        private GASOLINADataSet42TableAdapters.satisTableAdapter satisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private GASOLINADataSet44 gASOLINADataSet44;
        private System.Windows.Forms.BindingSource satisBindingSource1;
        private GASOLINADataSet44TableAdapters.satisTableAdapter satisTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kartsifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uchaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.Button button1;
    }
}