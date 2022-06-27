namespace TestApp
{
    partial class DepForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addBut = new System.Windows.Forms.Button();
            this.depView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.addBut, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.depView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addBut
            // 
            this.addBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBut.Location = new System.Drawing.Point(3, 3);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(794, 24);
            this.addBut.TabIndex = 0;
            this.addBut.Text = "Додати відділ";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // depView
            // 
            this.depView.AllowUserToAddRows = false;
            this.depView.AllowUserToDeleteRows = false;
            this.depView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depView.Location = new System.Drawing.Point(3, 33);
            this.depView.Name = "depView";
            this.depView.ReadOnly = true;
            this.depView.RowTemplate.Height = 25;
            this.depView.Size = new System.Drawing.Size(794, 414);
            this.depView.TabIndex = 1;
            this.depView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.depView_CellDoubleClick);
            // 
            // DepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DepForm";
            this.Text = "Відділи";
            this.Activated += new System.EventHandler(this.DepForm_Activated);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.depView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button addBut;
        private DataGridView depView;
    }
}