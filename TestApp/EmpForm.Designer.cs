namespace TestApp
{
    partial class EmpForm
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
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.id = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.midName = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.addBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.delBut = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.depId = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.Label();
            this.kpi = new System.Windows.Forms.Label();
            this.depBox = new System.Windows.Forms.ComboBox();
            this.jobBox = new System.Windows.Forms.ComboBox();
            this.kpiBox = new System.Windows.Forms.ComboBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.midNameBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.layoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.Controls.Add(this.id, 0, 0);
            this.layoutPanel.Controls.Add(this.firstName, 0, 2);
            this.layoutPanel.Controls.Add(this.lastName, 0, 4);
            this.layoutPanel.Controls.Add(this.midName, 0, 6);
            this.layoutPanel.Controls.Add(this.phone, 0, 8);
            this.layoutPanel.Controls.Add(this.addBut, 0, 13);
            this.layoutPanel.Controls.Add(this.saveBut, 0, 12);
            this.layoutPanel.Controls.Add(this.delBut, 1, 12);
            this.layoutPanel.Controls.Add(this.salary, 0, 10);
            this.layoutPanel.Controls.Add(this.address, 1, 0);
            this.layoutPanel.Controls.Add(this.depId, 1, 6);
            this.layoutPanel.Controls.Add(this.job, 1, 8);
            this.layoutPanel.Controls.Add(this.kpi, 1, 10);
            this.layoutPanel.Controls.Add(this.depBox, 1, 7);
            this.layoutPanel.Controls.Add(this.jobBox, 1, 9);
            this.layoutPanel.Controls.Add(this.kpiBox, 1, 11);
            this.layoutPanel.Controls.Add(this.idBox, 0, 1);
            this.layoutPanel.Controls.Add(this.firstNameBox, 0, 3);
            this.layoutPanel.Controls.Add(this.lastNameBox, 0, 5);
            this.layoutPanel.Controls.Add(this.midNameBox, 0, 7);
            this.layoutPanel.Controls.Add(this.phoneBox, 0, 9);
            this.layoutPanel.Controls.Add(this.salaryBox, 0, 11);
            this.layoutPanel.Controls.Add(this.addressBox, 1, 1);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 14;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel.Size = new System.Drawing.Size(624, 421);
            this.layoutPanel.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id.Location = new System.Drawing.Point(3, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(306, 30);
            this.id.TabIndex = 0;
            this.id.Text = "Ідентифікатор";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstName.Location = new System.Drawing.Point(3, 60);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(306, 30);
            this.firstName.TabIndex = 1;
            this.firstName.Text = "Ім\'я";
            this.firstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastName.Location = new System.Drawing.Point(3, 120);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(306, 30);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "Прізвище";
            this.lastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // midName
            // 
            this.midName.AutoSize = true;
            this.midName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midName.Location = new System.Drawing.Point(3, 180);
            this.midName.Name = "midName";
            this.midName.Size = new System.Drawing.Size(306, 30);
            this.midName.TabIndex = 3;
            this.midName.Text = "По батькові";
            this.midName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phone.Location = new System.Drawing.Point(3, 240);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(306, 30);
            this.phone.TabIndex = 7;
            this.phone.Text = "Телефон";
            this.phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBut
            // 
            this.layoutPanel.SetColumnSpan(this.addBut, 2);
            this.addBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBut.Location = new System.Drawing.Point(3, 393);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(618, 25);
            this.addBut.TabIndex = 6;
            this.addBut.Text = "Додати співробітника";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBut.Enabled = false;
            this.saveBut.Location = new System.Drawing.Point(3, 363);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(306, 24);
            this.saveBut.TabIndex = 4;
            this.saveBut.Text = "Зберегти зміни";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // delBut
            // 
            this.delBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delBut.Enabled = false;
            this.delBut.Location = new System.Drawing.Point(315, 363);
            this.delBut.Name = "delBut";
            this.delBut.Size = new System.Drawing.Size(306, 24);
            this.delBut.TabIndex = 5;
            this.delBut.Text = "Видалити співробітника";
            this.delBut.UseVisualStyleBackColor = true;
            this.delBut.Click += new System.EventHandler(this.delBut_Click);
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salary.Location = new System.Drawing.Point(3, 300);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(306, 30);
            this.salary.TabIndex = 8;
            this.salary.Text = "Заробітня плата";
            this.salary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address.Location = new System.Drawing.Point(315, 0);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(306, 30);
            this.address.TabIndex = 9;
            this.address.Text = "Адреса";
            this.address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depId
            // 
            this.depId.AutoSize = true;
            this.depId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depId.Location = new System.Drawing.Point(315, 180);
            this.depId.Name = "depId";
            this.depId.Size = new System.Drawing.Size(306, 30);
            this.depId.TabIndex = 10;
            this.depId.Text = "Відділ";
            this.depId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // job
            // 
            this.job.AutoSize = true;
            this.job.Dock = System.Windows.Forms.DockStyle.Fill;
            this.job.Location = new System.Drawing.Point(315, 240);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(306, 30);
            this.job.TabIndex = 11;
            this.job.Text = "Посада";
            this.job.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kpi
            // 
            this.kpi.AutoSize = true;
            this.kpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpi.Location = new System.Drawing.Point(315, 300);
            this.kpi.Name = "kpi";
            this.kpi.Size = new System.Drawing.Size(306, 30);
            this.kpi.TabIndex = 12;
            this.kpi.Text = "Оцінка";
            this.kpi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depBox
            // 
            this.depBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depBox.FormattingEnabled = true;
            this.depBox.Location = new System.Drawing.Point(315, 213);
            this.depBox.Name = "depBox";
            this.depBox.Size = new System.Drawing.Size(306, 23);
            this.depBox.TabIndex = 13;
            // 
            // jobBox
            // 
            this.jobBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobBox.FormattingEnabled = true;
            this.jobBox.Location = new System.Drawing.Point(315, 273);
            this.jobBox.Name = "jobBox";
            this.jobBox.Size = new System.Drawing.Size(306, 23);
            this.jobBox.TabIndex = 14;
            // 
            // kpiBox
            // 
            this.kpiBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpiBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kpiBox.FormattingEnabled = true;
            this.kpiBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.kpiBox.Location = new System.Drawing.Point(315, 333);
            this.kpiBox.Name = "kpiBox";
            this.kpiBox.Size = new System.Drawing.Size(306, 23);
            this.kpiBox.TabIndex = 15;
            // 
            // idBox
            // 
            this.idBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(3, 33);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(306, 23);
            this.idBox.TabIndex = 16;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameBox.Location = new System.Drawing.Point(3, 93);
            this.firstNameBox.MaxLength = 32;
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(306, 23);
            this.firstNameBox.TabIndex = 17;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameBox.Location = new System.Drawing.Point(3, 153);
            this.lastNameBox.MaxLength = 32;
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(306, 23);
            this.lastNameBox.TabIndex = 18;
            // 
            // midNameBox
            // 
            this.midNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midNameBox.Location = new System.Drawing.Point(3, 213);
            this.midNameBox.MaxLength = 32;
            this.midNameBox.Name = "midNameBox";
            this.midNameBox.Size = new System.Drawing.Size(306, 23);
            this.midNameBox.TabIndex = 19;
            // 
            // phoneBox
            // 
            this.phoneBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneBox.Location = new System.Drawing.Point(3, 273);
            this.phoneBox.MaxLength = 16;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(306, 23);
            this.phoneBox.TabIndex = 20;
            // 
            // salaryBox
            // 
            this.salaryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salaryBox.Location = new System.Drawing.Point(3, 333);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(306, 23);
            this.salaryBox.TabIndex = 21;
            // 
            // addressBox
            // 
            this.addressBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressBox.Location = new System.Drawing.Point(315, 33);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.layoutPanel.SetRowSpan(this.addressBox, 5);
            this.addressBox.Size = new System.Drawing.Size(306, 144);
            this.addressBox.TabIndex = 22;
            // 
            // EmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 421);
            this.Controls.Add(this.layoutPanel);
            this.MaximumSize = new System.Drawing.Size(640, 460);
            this.MinimumSize = new System.Drawing.Size(640, 460);
            this.Name = "EmpForm";
            this.Text = "Додати співробітника";
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel layoutPanel;
        private Label id;
        private Label firstName;
        private Label lastName;
        private Label midName;
        private Label phone;
        private Button addBut;
        private Button saveBut;
        private Button delBut;
        private Label salary;
        private Label address;
        private Label depId;
        private Label job;
        private Label kpi;
        private ComboBox depBox;
        private ComboBox jobBox;
        private ComboBox kpiBox;
        private TextBox idBox;
        private TextBox firstNameBox;
        private TextBox lastNameBox;
        private TextBox midNameBox;
        private TextBox phoneBox;
        private TextBox salaryBox;
        private TextBox addressBox;
    }
}