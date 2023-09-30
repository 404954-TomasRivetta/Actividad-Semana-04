using modeloParcial.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modeloParcial.Presentaciones
{
    public partial class FrmReporteStock : Form
    {
        public FrmReporteStock()
        {
            InitializeComponent();
        }

        private void FrmReporteStock_Load(object sender, EventArgs e)
        {
            
            DataTable tabla = new DBHelper().ConsultarTabla("SP_CONSULTAR_MATERIALES");

            this.dataSetOrdenBindingSource.DataSource = tabla
;
            this.reportViewer1.RefreshReport();
        }
    }
}
