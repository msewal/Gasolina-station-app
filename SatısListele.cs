using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GASOLINA
{
    public partial class frmSatısListele : Form
    {
        public frmSatısListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");
        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adtr;
        DataTable tbl = new DataTable();

        DataTable GetList()
        {
            tbl.Clear();
            adtr = new SqlDataAdapter("select *from satis",baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            return tbl;

        }
        private void frmSatısListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gASOLINADataSet44.satis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satisTableAdapter1.Fill(this.gASOLINADataSet44.satis);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            commandBuilder = new SqlCommandBuilder(adtr);
            adtr.Update(tbl);
            GetList();

        }
    }
}
