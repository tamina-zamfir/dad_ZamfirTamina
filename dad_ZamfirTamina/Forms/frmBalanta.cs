using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dad_ZamfirTamina.Forms
{
    public partial class frmBalanta : Form
    {
        public frmBalanta()
        {
            InitializeComponent();
        }

        databaseEntities ctx = new databaseEntities();

        private void frmBalanta_Load(object sender, EventArgs e)
        {
            ctx.vwBalantaDeVerificare.Load();
            bindingSource1.DataSource = ctx.vwBalantaDeVerificare.Local;


            this.reportViewer1.RefreshReport();
        }
    }
}
