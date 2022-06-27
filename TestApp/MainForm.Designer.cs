using System.Data;

namespace TestApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.empView = new System.Windows.Forms.DataGridView();
            this.addEmpBut = new System.Windows.Forms.Button();
            this.depEditBut = new System.Windows.Forms.Button();
            this.jobEditBut = new System.Windows.Forms.Button();
            this.PaymentBut = new System.Windows.Forms.Button();
            this.reportBut = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 5;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.Controls.Add(this.empView, 0, 1);
            this.mainLayout.Controls.Add(this.addEmpBut, 0, 0);
            this.mainLayout.Controls.Add(this.depEditBut, 1, 0);
            this.mainLayout.Controls.Add(this.jobEditBut, 2, 0);
            this.mainLayout.Controls.Add(this.PaymentBut, 3, 0);
            this.mainLayout.Controls.Add(this.reportBut, 4, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.Size = new System.Drawing.Size(800, 601);
            this.mainLayout.TabIndex = 0;
            // 
            // empView
            // 
            this.empView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainLayout.SetColumnSpan(this.empView, 5);
            this.empView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empView.Location = new System.Drawing.Point(3, 43);
            this.empView.Name = "empView";
            this.empView.RowTemplate.Height = 25;
            this.empView.Size = new System.Drawing.Size(794, 555);
            this.empView.TabIndex = 0;
            this.empView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empView_CellDoubleClick);
            // 
            // addEmpBut
            // 
            this.addEmpBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEmpBut.Location = new System.Drawing.Point(3, 3);
            this.addEmpBut.Name = "addEmpBut";
            this.addEmpBut.Size = new System.Drawing.Size(154, 34);
            this.addEmpBut.TabIndex = 1;
            this.addEmpBut.Text = "Додати співробітника";
            this.addEmpBut.UseVisualStyleBackColor = true;
            this.addEmpBut.Click += new System.EventHandler(this.addEmpBut_Click);
            // 
            // depEditBut
            // 
            this.depEditBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depEditBut.Location = new System.Drawing.Point(163, 3);
            this.depEditBut.Name = "depEditBut";
            this.depEditBut.Size = new System.Drawing.Size(154, 34);
            this.depEditBut.TabIndex = 2;
            this.depEditBut.Text = "Редагування відділень";
            this.depEditBut.UseVisualStyleBackColor = true;
            this.depEditBut.Click += new System.EventHandler(this.depEditBut_Click);
            // 
            // jobEditBut
            // 
            this.jobEditBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobEditBut.Location = new System.Drawing.Point(323, 3);
            this.jobEditBut.Name = "jobEditBut";
            this.jobEditBut.Size = new System.Drawing.Size(154, 34);
            this.jobEditBut.TabIndex = 3;
            this.jobEditBut.Text = "Редагування посад";
            this.jobEditBut.UseVisualStyleBackColor = true;
            // 
            // PaymentBut
            // 
            this.PaymentBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaymentBut.Location = new System.Drawing.Point(483, 3);
            this.PaymentBut.Name = "PaymentBut";
            this.PaymentBut.Size = new System.Drawing.Size(154, 34);
            this.PaymentBut.TabIndex = 4;
            this.PaymentBut.Text = "Виплати";
            this.PaymentBut.UseVisualStyleBackColor = true;
            // 
            // reportBut
            // 
            this.reportBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBut.Location = new System.Drawing.Point(643, 3);
            this.reportBut.Name = "reportBut";
            this.reportBut.Size = new System.Drawing.Size(154, 34);
            this.reportBut.TabIndex = 5;
            this.reportBut.Text = "Звіт";
            this.reportBut.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.mainLayout);
            this.MinimumSize = new System.Drawing.Size(480, 640);
            this.Name = "mainForm";
            this.Text = "Співробітники";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            this.mainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel mainLayout;
        private DataGridView empView;
        private Button addEmpBut;
        private Button depEditBut;
        private Button jobEditBut;
        private Button PaymentBut;
        private Button reportBut;
    }
}