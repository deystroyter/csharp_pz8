namespace FedorovAD_Pz8
{
    partial class DeleteAbonentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAbonentForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDeleteAbonent = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBoxDeleteAbonent = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelDeleteAbonent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxDeleteAbonent, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelDeleteAbonent
            // 
            this.labelDeleteAbonent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDeleteAbonent.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelDeleteAbonent, 2);
            this.labelDeleteAbonent.Location = new System.Drawing.Point(126, 54);
            this.labelDeleteAbonent.Name = "labelDeleteAbonent";
            this.labelDeleteAbonent.Size = new System.Drawing.Size(176, 17);
            this.labelDeleteAbonent.TabIndex = 0;
            this.labelDeleteAbonent.Text = "Введите номер договора:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBoxDeleteAbonent
            // 
            this.maskedTextBoxDeleteAbonent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.maskedTextBoxDeleteAbonent, 2);
            this.maskedTextBoxDeleteAbonent.Location = new System.Drawing.Point(127, 94);
            this.maskedTextBoxDeleteAbonent.Name = "maskedTextBoxDeleteAbonent";
            this.maskedTextBoxDeleteAbonent.Size = new System.Drawing.Size(175, 22);
            this.maskedTextBoxDeleteAbonent.TabIndex = 3;
            // 
            // DeleteAbonentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 170);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteAbonentForm";
            this.Text = "Удаление абонента";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelDeleteAbonent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDeleteAbonent;
    }
}