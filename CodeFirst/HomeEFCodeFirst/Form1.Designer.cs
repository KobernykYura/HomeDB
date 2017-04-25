namespace HomeEFCodeFirst{  
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridEmpl = new System.Windows.Forms.DataGridView();
            this.dataGridDep = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addDep = new System.Windows.Forms.Button();
            this.addEmp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDep)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridEmpl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridDep, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addDep, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.addEmp, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridEmpl
            // 
            this.dataGridEmpl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridEmpl, 3);
            this.dataGridEmpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridEmpl.Location = new System.Drawing.Point(193, 3);
            this.dataGridEmpl.Name = "dataGridEmpl";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridEmpl, 2);
            this.dataGridEmpl.Size = new System.Drawing.Size(564, 156);
            this.dataGridEmpl.TabIndex = 0;
            // 
            // dataGridDep
            // 
            this.dataGridDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridDep, 2);
            this.dataGridDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDep.Location = new System.Drawing.Point(573, 165);
            this.dataGridDep.Name = "dataGridDep";
            this.dataGridDep.Size = new System.Drawing.Size(378, 75);
            this.dataGridDep.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(503, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 81);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detartments";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(129, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 81);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addDep
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.addDep, 2);
            this.addDep.Dock = System.Windows.Forms.DockStyle.Top;
            this.addDep.Location = new System.Drawing.Point(573, 246);
            this.addDep.Name = "addDep";
            this.addDep.Size = new System.Drawing.Size(378, 23);
            this.addDep.TabIndex = 4;
            this.addDep.Text = "Add";
            this.addDep.UseVisualStyleBackColor = true;
            this.addDep.Click += new System.EventHandler(this.addDep_Click);
            // 
            // addEmp
            // 
            this.addEmp.Dock = System.Windows.Forms.DockStyle.Left;
            this.addEmp.Location = new System.Drawing.Point(763, 3);
            this.addEmp.Name = "addEmp";
            this.tableLayoutPanel1.SetRowSpan(this.addEmp, 2);
            this.addEmp.Size = new System.Drawing.Size(75, 156);
            this.addEmp.TabIndex = 5;
            this.addEmp.Text = "Add";
            this.addEmp.UseVisualStyleBackColor = true;
            this.addEmp.Click += new System.EventHandler(this.addEmp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 409);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridEmpl;
        private System.Windows.Forms.DataGridView dataGridDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addDep;
        private System.Windows.Forms.Button addEmp;
    }
}


