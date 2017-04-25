namespace HomeServiceClient
{
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
            this.first = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Web = new System.Windows.Forms.Label();
            this.WCF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.secound = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(132, 74);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(100, 20);
            this.first.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Web
            // 
            this.Web.AutoSize = true;
            this.Web.Location = new System.Drawing.Point(386, 135);
            this.Web.Name = "Web";
            this.Web.Size = new System.Drawing.Size(25, 13);
            this.Web.TabIndex = 3;
            this.Web.Text = "......";
            // 
            // WCF
            // 
            this.WCF.AutoSize = true;
            this.WCF.Location = new System.Drawing.Point(386, 55);
            this.WCF.Name = "WCF";
            this.WCF.Size = new System.Drawing.Size(25, 13);
            this.WCF.TabIndex = 4;
            this.WCF.Text = "......";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат WCFService:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Результат WebService:";
            // 
            // secound
            // 
            this.secound.Location = new System.Drawing.Point(132, 115);
            this.secound.Name = "secound";
            this.secound.Size = new System.Drawing.Size(100, 20);
            this.secound.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 202);
            this.Controls.Add(this.secound);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WCF);
            this.Controls.Add(this.Web);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.first);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Web;
        private System.Windows.Forms.Label WCF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox secound;
    }
}

