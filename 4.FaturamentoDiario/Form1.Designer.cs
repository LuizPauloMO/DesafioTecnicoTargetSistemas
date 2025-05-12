namespace _4.FaturamentoDiario
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(645, 265);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(12, 290);
            label1.Name = "label1";
            label1.Size = new Size(645, 13);
            label1.TabIndex = 3;
            label1.Text = "O menor valor de faturamento ocorrido em um dia do mês: R$0.00";
            // 
            // label4
            // 
            label4.Location = new Point(12, 305);
            label4.Name = "label4";
            label4.Size = new Size(641, 13);
            label4.TabIndex = 6;
            label4.Text = "O maior valor de faturamento ocorrido em um dia do mês: R$0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Yellow;
            label2.Location = new Point(10, 325);
            label2.Name = "label2";
            label2.Size = new Size(463, 13);
            label2.TabIndex = 7;
            label2.Text = "Número de dias no mês em que o valor de faturamento diário foi superior à média mensal: 00 dias";
            // 
            // label3
            // 
            label3.Location = new Point(541, 325);
            label3.Name = "label3";
            label3.Size = new Size(112, 13);
            label3.TabIndex = 8;
            label3.Text = "Total: R$0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 347);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
    }
}
