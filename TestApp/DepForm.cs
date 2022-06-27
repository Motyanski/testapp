using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class DepForm : Form
    {
        public DepForm()
        {
            InitializeComponent();
        }

        private void DepForm_Activated(object sender, EventArgs e)
        {
            depView.DataSource = Connection.FetchDeps();
            depView.ReadOnly = true;
            depView.AllowUserToAddRows = false;
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            DepEditForm depEditForm = new DepEditForm();
            depEditForm.ShowDialog();
        }

        private void depView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                object[] emp = Connection.GetDep(Int32.Parse((string)depView.Rows[e.RowIndex].Cells[0].Value));
                EmpForm empForm = new EmpForm(emp);
                empForm.ShowDialog();
            }
        }
    }
}
