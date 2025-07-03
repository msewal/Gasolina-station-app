namespace GASOLINA
{
    partial class Form27
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracahizmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gASOLINADataSet58 = new GASOLINA.GASOLINADataSet58();
            this.aracahizmetTableAdapter = new GASOLINA.GASOLINADataSet58TableAdapters.aracahizmetTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.plakaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akaryakitnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamfiyatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akaryakitsatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gASOLINADataSet59 = new GASOLINA.GASOLINADataSet59();
            this.akaryakitsatisTableAdapter = new GASOLINA.GASOLINADataSet59TableAdapters.akaryakitsatisTableAdapter();
            this.EPostatxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracahizmetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gASOLINADataSet58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akaryakitsatisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gASOLINADataSet59)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Orange;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plakaDataGridViewTextBoxColumn,
            this.adsoyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.urunadiDataGridViewTextBoxColumn,
            this.urunkoduDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.fiyatiDataGridViewTextBoxColumn,
            this.miktariDataGridViewTextBoxColumn,
            this.toplamfiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aracahizmetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "eposta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "eposta";
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            // 
            // urunkoduDataGridViewTextBoxColumn
            // 
            this.urunkoduDataGridViewTextBoxColumn.DataPropertyName = "urunkodu";
            this.urunkoduDataGridViewTextBoxColumn.HeaderText = "urunkodu";
            this.urunkoduDataGridViewTextBoxColumn.Name = "urunkoduDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // fiyatiDataGridViewTextBoxColumn
            // 
            this.fiyatiDataGridViewTextBoxColumn.DataPropertyName = "fiyati";
            this.fiyatiDataGridViewTextBoxColumn.HeaderText = "fiyati";
            this.fiyatiDataGridViewTextBoxColumn.Name = "fiyatiDataGridViewTextBoxColumn";
            // 
            // miktariDataGridViewTextBoxColumn
            // 
            this.miktariDataGridViewTextBoxColumn.DataPropertyName = "miktari";
            this.miktariDataGridViewTextBoxColumn.HeaderText = "miktari";
            this.miktariDataGridViewTextBoxColumn.Name = "miktariDataGridViewTextBoxColumn";
            // 
            // toplamfiyatDataGridViewTextBoxColumn
            // 
            this.toplamfiyatDataGridViewTextBoxColumn.DataPropertyName = "toplamfiyat";
            this.toplamfiyatDataGridViewTextBoxColumn.HeaderText = "toplamfiyat";
            this.toplamfiyatDataGridViewTextBoxColumn.Name = "toplamfiyatDataGridViewTextBoxColumn";
            // 
            // aracahizmetBindingSource
            // 
            this.aracahizmetBindingSource.DataMember = "aracahizmet";
            this.aracahizmetBindingSource.DataSource = this.gASOLINADataSet58;
            // 
            // gASOLINADataSet58
            // 
            this.gASOLINADataSet58.DataSetName = "GASOLINADataSet58";
            this.gASOLINADataSet58.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aracahizmetTableAdapter
            // 
            this.aracahizmetTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Green;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plakaDataGridViewTextBoxColumn1,
            this.adsoyadDataGridViewTextBoxColumn1,
            this.telefonDataGridViewTextBoxColumn1,
            this.epostaDataGridViewTextBoxColumn1,
            this.akaryakitnoDataGridViewTextBoxColumn,
            this.turDataGridViewTextBoxColumn,
            this.litreDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.toplamfiyatDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.akaryakitsatisBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 359);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(764, 219);
            this.dataGridView2.TabIndex = 1;
            // 
            // plakaDataGridViewTextBoxColumn1
            // 
            this.plakaDataGridViewTextBoxColumn1.DataPropertyName = "plaka";
            this.plakaDataGridViewTextBoxColumn1.HeaderText = "plaka";
            this.plakaDataGridViewTextBoxColumn1.Name = "plakaDataGridViewTextBoxColumn1";
            // 
            // adsoyadDataGridViewTextBoxColumn1
            // 
            this.adsoyadDataGridViewTextBoxColumn1.DataPropertyName = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn1.HeaderText = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn1.Name = "adsoyadDataGridViewTextBoxColumn1";
            // 
            // telefonDataGridViewTextBoxColumn1
            // 
            this.telefonDataGridViewTextBoxColumn1.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn1.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn1.Name = "telefonDataGridViewTextBoxColumn1";
            // 
            // epostaDataGridViewTextBoxColumn1
            // 
            this.epostaDataGridViewTextBoxColumn1.DataPropertyName = "eposta";
            this.epostaDataGridViewTextBoxColumn1.HeaderText = "eposta";
            this.epostaDataGridViewTextBoxColumn1.Name = "epostaDataGridViewTextBoxColumn1";
            // 
            // akaryakitnoDataGridViewTextBoxColumn
            // 
            this.akaryakitnoDataGridViewTextBoxColumn.DataPropertyName = "akaryakitno";
            this.akaryakitnoDataGridViewTextBoxColumn.HeaderText = "akaryakitno";
            this.akaryakitnoDataGridViewTextBoxColumn.Name = "akaryakitnoDataGridViewTextBoxColumn";
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "tur";
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            // 
            // litreDataGridViewTextBoxColumn
            // 
            this.litreDataGridViewTextBoxColumn.DataPropertyName = "litre";
            this.litreDataGridViewTextBoxColumn.HeaderText = "litre";
            this.litreDataGridViewTextBoxColumn.Name = "litreDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // toplamfiyatDataGridViewTextBoxColumn1
            // 
            this.toplamfiyatDataGridViewTextBoxColumn1.DataPropertyName = "toplamfiyat";
            this.toplamfiyatDataGridViewTextBoxColumn1.HeaderText = "toplamfiyat";
            this.toplamfiyatDataGridViewTextBoxColumn1.Name = "toplamfiyatDataGridViewTextBoxColumn1";
            // 
            // akaryakitsatisBindingSource
            // 
            this.akaryakitsatisBindingSource.DataMember = "akaryakitsatis";
            this.akaryakitsatisBindingSource.DataSource = this.gASOLINADataSet59;
            // 
            // gASOLINADataSet59
            // 
            this.gASOLINADataSet59.DataSetName = "GASOLINADataSet59";
            this.gASOLINADataSet59.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // akaryakitsatisTableAdapter
            // 
            this.akaryakitsatisTableAdapter.ClearBeforeFill = true;
            // 
            // EPostatxt
            // 
            this.EPostatxt.Location = new System.Drawing.Point(801, 67);
            this.EPostatxt.Name = "EPostatxt";
            this.EPostatxt.Size = new System.Drawing.Size(174, 20);
            this.EPostatxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(798, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lütfen siparişi onaylamak için \r\nmüşterinin mail adresini giriniz:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(801, 359);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(798, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lütfen siparişi onaylamak için \r\nmüşterinin mail adresini giriniz:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(801, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Siparişi Onayla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(801, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Siparişi Reddet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(801, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 39);
            this.button3.TabIndex = 12;
            this.button3.Text = "Siparişi Reddet";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(801, 441);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 39);
            this.button4.TabIndex = 11;
            this.button4.Text = "Siparişi Onayla";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(892, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 39);
            this.button5.TabIndex = 13;
            this.button5.Text = "Tabloyu Temizle";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(892, 539);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 39);
            this.button6.TabIndex = 14;
            this.button6.Text = "Tabloyu Temizle";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(801, 93);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(174, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(801, 386);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(174, 23);
            this.progressBar2.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(805, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(813, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(801, 247);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 39);
            this.button7.TabIndex = 19;
            this.button7.Text = "Satırı Temizle";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(801, 539);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 39);
            this.button8.TabIndex = 20;
            this.button8.Text = "Satırı Temizle";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(41, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 39);
            this.label3.TabIndex = 21;
            this.label3.Text = "Müşteri Siparişleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(41, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 39);
            this.label4.TabIndex = 22;
            this.label4.Text = "Akaryakıt Siparişleri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 23;
            // 
            // Form27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1003, 608);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EPostatxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "Form27";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HIZLI SİPARİŞLER";
            this.Load += new System.EventHandler(this.Form27_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracahizmetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gASOLINADataSet58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akaryakitsatisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gASOLINADataSet59)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GASOLINADataSet58 gASOLINADataSet58;
        private System.Windows.Forms.BindingSource aracahizmetBindingSource;
        private GASOLINADataSet58TableAdapters.aracahizmetTableAdapter aracahizmetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private GASOLINADataSet59 gASOLINADataSet59;
        private System.Windows.Forms.BindingSource akaryakitsatisBindingSource;
        private GASOLINADataSet59TableAdapters.akaryakitsatisTableAdapter akaryakitsatisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn akaryakitnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn litreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamfiyatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox EPostatxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}