namespace GASOLINA
{
    partial class Form7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.istasyondakiakaryakitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gASOLINADataSet36 = new GASOLINA.GASOLINADataSet36();
            this.istasyondakiakaryakitTableAdapter = new GASOLINA.GASOLINADataSet36TableAdapters.istasyondakiakaryakitTableAdapter();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.istasyondakiakaryakitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gASOLINADataSet36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // istasyondakiakaryakitBindingSource
            // 
            this.istasyondakiakaryakitBindingSource.DataMember = "istasyondakiakaryakit";
            this.istasyondakiakaryakitBindingSource.DataSource = this.gASOLINADataSet36;
            // 
            // gASOLINADataSet36
            // 
            this.gASOLINADataSet36.DataSetName = "GASOLINADataSet36";
            this.gASOLINADataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // istasyondakiakaryakitTableAdapter
            // 
            this.istasyondakiakaryakitTableAdapter.ClearBeforeFill = true;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(68, 54);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Akaryakıt Miktarı";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(542, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 411);
            this.Controls.Add(this.chart2);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akaryakıt Grafik ";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.istasyondakiakaryakitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gASOLINADataSet36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private GASOLINADataSet36 gASOLINADataSet36;
        private System.Windows.Forms.BindingSource istasyondakiakaryakitBindingSource;
        private GASOLINADataSet36TableAdapters.istasyondakiakaryakitTableAdapter istasyondakiakaryakitTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}