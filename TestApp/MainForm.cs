namespace TestApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void empView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                object[] emp = Connection.GetEmp(Int32.Parse((string)empView.Rows[e.RowIndex].Cells[0].Value));
                EmpForm empForm = new EmpForm(emp);
                empForm.ShowDialog();
            }
        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            empView.DataSource = Connection.FetchEmps();
            empView.ReadOnly = true;
            empView.Columns[0].Visible = false;
            empView.AllowUserToAddRows = false;
        }

        private void addEmpBut_Click(object sender, EventArgs e)
        {
            EmpForm empForm = new EmpForm();
            empForm.ShowDialog();
        }

        private void depEditBut_Click(object sender, EventArgs e)
        {
            DepForm depForm = new DepForm();
            depForm.ShowDialog();
        }
    }
}