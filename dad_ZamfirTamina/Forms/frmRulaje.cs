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
    public partial class frmRulaje : Form
    {
        public frmRulaje()
        {
            InitializeComponent();
        }

        databaseEntities dad = new databaseEntities();

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmRulaje_Load(object sender, EventArgs e)
        {
            dad.Operatie.Include("Rulaje").Load();
            bsOperatie.DataSource = dad.Operatie.Local.ToBindingList();

            dad.Cont.Load();
            bsConturi.DataSource = dad.Cont.Local;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bsOperatie.EndEdit();
                dad.SaveChanges();
                bsOperatie.ResetBindings(false);
                MessageBox.Show("Datele au fost salvate");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datele nu pot fi salvate! {ex.Message}");
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }

    public class myColl<T> : System.Collections.ObjectModel.ObservableCollection<T>
    {

    }
}
