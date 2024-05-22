namespace WinFormsApp2
{
    partial class CargoTypesForms
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
            dgvTypes = new DataGridView();
            tbName = new TextBox();
            btAdd = new Button();
            label1 = new Label();
            btUpdateTable = new Button();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTypes).BeginInit();
            SuspendLayout();
            // 
            // dgvTypes
            // 
            dgvTypes.AllowUserToAddRows = false;
            dgvTypes.AllowUserToDeleteRows = false;
            dgvTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTypes.Location = new Point(58, 84);
            dgvTypes.Name = "dgvTypes";
            dgvTypes.ReadOnly = true;
            dgvTypes.Size = new Size(240, 150);
            dgvTypes.TabIndex = 0;
            // 
            // tbName
            // 
            tbName.Location = new Point(536, 167);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 1;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(497, 211);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 2;
            btAdd.Text = "Сохранить";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 170);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 3;
            label1.Text = "Наименование";
            // 
            // btUpdateTable
            // 
            btUpdateTable.Location = new Point(131, 240);
            btUpdateTable.Name = "btUpdateTable";
            btUpdateTable.Size = new Size(75, 23);
            btUpdateTable.TabIndex = 4;
            btUpdateTable.Text = "Обновить";
            btUpdateTable.UseVisualStyleBackColor = true;
            btUpdateTable.Click += btUpdateTable_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 137);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 5;
            label2.Text = "Добавление типа груза";
            // 
            // button1
            // 
            button1.Location = new Point(304, 132);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btDelete_Click;
            // 
            // CargoTypesForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 363);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(btAdd);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(btUpdateTable);
            Controls.Add(dgvTypes);
            Name = "CargoTypesForms";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTypes;
        private TextBox tbName;
        private Button btAdd;
        private Label label1;
        private Button btUpdateTable;
        private Label label2;
        private Button button1;
    }
}
