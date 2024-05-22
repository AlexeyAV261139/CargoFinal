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
            dgvTypes.Location = new Point(12, 65);
            dgvTypes.Name = "dgvTypes";
            dgvTypes.ReadOnly = true;
            dgvTypes.Size = new Size(286, 150);
            dgvTypes.TabIndex = 0;
            // 
            // tbName
            // 
            tbName.Location = new Point(448, 130);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 1;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(409, 174);
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
            label1.Location = new Point(352, 133);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 3;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 100);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 5;
            label2.Text = "Добавление типа груза";
            // 
            // button1
            // 
            button1.Location = new Point(55, 235);
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
            ClientSize = new Size(611, 314);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(btAdd);
            Controls.Add(tbName);
            Controls.Add(label1);
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
        private Label label2;
        private Button button1;
    }
}
