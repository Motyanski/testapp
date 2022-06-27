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
    public partial class EmpForm : Form
    {
        public EmpForm()
        {
            InitializeComponent();

            this.kpiBox.SelectedItem = kpiBox.Items[0];
            if (jobBox.Items.Count > 0) this.jobBox.SelectedItem = jobBox.Items[0];
            if (depBox.Items.Count > 0) this.depBox.SelectedItem = depBox.Items[0];
        }

        public EmpForm(Object[] emp)
        {
            InitializeComponent();

            this.kpiBox.SelectedItem = kpiBox.Items[0];
            if (jobBox.Items.Count > 0) this.jobBox.SelectedItem = jobBox.Items[0];
            if (depBox.Items.Count > 0) this.depBox.SelectedItem = depBox.Items[0];

            this.Text = emp[2].ToString() + " " + emp[1].ToString() + " " + emp[3].ToString();
            this.addBut.Enabled = false;
            this.saveBut.Enabled = true;
            this.delBut.Enabled = true;

            this.idBox.Text = emp[0].ToString();
            this.firstNameBox.Text = emp[1].ToString();
            this.lastNameBox.Text = emp[2].ToString();
            this.midNameBox.Text = emp[3].ToString();
            this.phoneBox.Text = emp[4].ToString();
            this.addressBox.Text = emp[5].ToString();
            this.depBox.Text = emp[6].ToString();
            this.jobBox.Text = emp[7].ToString();
            this.salaryBox.Text = emp[8].ToString();
            this.kpiBox.Text = emp[9].ToString();
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            Object[] emp = new Object[10];
            emp[0] = idBox.Text;
            emp[1] = firstNameBox.Text;
            emp[2] = lastNameBox.Text;
            emp[3] = midNameBox.Text;
            emp[4] = phoneBox.Text;
            emp[5] = addressBox.Text;
            emp[6] = depBox.Text;
            emp[7] = jobBox.Text;
            emp[8] = salaryBox.Text;
            emp[9] = kpiBox.Text;

            try
            {
                Connection.UpdateEmp(emp);
                MessageBox.Show("Зміни збережено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            Object[] emp = new Object[10];
            emp[0] = idBox.Text;
            emp[1] = firstNameBox.Text;
            emp[2] = lastNameBox.Text;
            emp[3] = midNameBox.Text;
            emp[4] = phoneBox.Text;
            emp[5] = addressBox.Text;
            emp[6] = depBox.Text;
            emp[7] = jobBox.Text;
            emp[8] = salaryBox.Text;
            emp[9] = kpiBox.Text;

            try
            {
                Connection.DelEmp(emp);
                MessageBox.Show("Успішно видалено");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            Object[] emp = new Object[10];
            emp[0] = idBox.Text;
            emp[1] = firstNameBox.Text;
            emp[2] = lastNameBox.Text;
            emp[3] = midNameBox.Text;
            emp[4] = phoneBox.Text;
            emp[5] = addressBox.Text;
            emp[6] = depBox.Text;
            emp[7] = jobBox.Text;
            emp[8] = salaryBox.Text;
            emp[9] = kpiBox.Text;

            try
            {
                int id = Connection.AddEmp(emp);
                MessageBox.Show("Успішно додано");
                this.Close();

                Object[] createdEmp = Connection.GetEmp(id);
                EmpForm empForm = new EmpForm(createdEmp);
                empForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
