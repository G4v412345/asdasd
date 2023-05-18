namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtn = new TextBox();
            txtm = new TextBox();
            txtRez = new TextBox();
            cmdStart = new Button();
            cmdExit = new Button();
            cmdClear = new Button();
            dgvMass = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 54);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "Количество строк n=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 98);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 1;
            label2.Text = "Количество столбцов m=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 142);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Результат:";
            // 
            // txtn
            // 
            txtn.Location = new Point(52, 72);
            txtn.Name = "txtn";
            txtn.Size = new Size(149, 23);
            txtn.TabIndex = 3;
            // 
            // txtm
            // 
            txtm.Location = new Point(52, 116);
            txtm.Name = "txtm";
            txtm.Size = new Size(149, 23);
            txtm.TabIndex = 4;
            // 
            // txtRez
            // 
            txtRez.Location = new Point(52, 160);
            txtRez.Multiline = true;
            txtRez.Name = "txtRez";
            txtRez.Size = new Size(149, 113);
            txtRez.TabIndex = 5;
            // 
            // cmdStart
            // 
            cmdStart.Location = new Point(77, 361);
            cmdStart.Name = "cmdStart";
            cmdStart.Size = new Size(99, 23);
            cmdStart.TabIndex = 6;
            cmdStart.Text = "Вычислить";
            cmdStart.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(239, 361);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(163, 23);
            cmdExit.TabIndex = 7;
            cmdExit.Text = "Завершить работу";
            cmdExit.UseVisualStyleBackColor = true;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(543, 361);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(151, 23);
            cmdClear.TabIndex = 8;
            cmdClear.Text = "Очистка полей";
            cmdClear.UseVisualStyleBackColor = true;
            // 
            // dgvMass
            // 
            dgvMass.AllowUserToOrderColumns = true;
            dgvMass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMass.Location = new Point(303, 54);
            dgvMass.Name = "dgvMass";
            dgvMass.RowTemplate.Height = 25;
            dgvMass.Size = new Size(391, 259);
            dgvMass.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMass);
            Controls.Add(cmdClear);
            Controls.Add(cmdExit);
            Controls.Add(cmdStart);
            Controls.Add(txtRez);
            Controls.Add(txtm);
            Controls.Add(txtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtn;
        private TextBox txtm;
        private TextBox txtRez;
        private Button cmdStart;
        private Button cmdExit;
        private Button cmdClear;
        private DataGridView dgvMass;
    }
}