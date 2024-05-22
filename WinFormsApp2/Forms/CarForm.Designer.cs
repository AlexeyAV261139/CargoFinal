namespace WinFormsApp2
{
    partial class CarForms
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
            dgvCars = new DataGridView();
            tbBrand = new TextBox();
            btAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            tbNumber = new TextBox();
            label3 = new Label();
            tbCapacity = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(31, 33);
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.Size = new Size(425, 229);
            dgvCars.TabIndex = 0;
            // 
            // tbBrand
            // 
            tbBrand.Location = new Point(590, 120);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(100, 23);
            tbBrand.TabIndex = 1;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(553, 223);
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
            label1.Location = new Point(541, 120);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Марка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(553, 89);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 5;
            label2.Text = "Добавление авто";
            // 
            // button1
            // 
            button1.Location = new Point(64, 281);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btDelete_Click;
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(590, 149);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(100, 23);
            tbNumber.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 152);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "Номер";
            // 
            // tbCapacity
            // 
            tbCapacity.Location = new Point(590, 178);
            tbCapacity.Name = "tbCapacity";
            tbCapacity.Size = new Size(100, 23);
            tbCapacity.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 181);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 10;
            label4.Text = "Грузоподъёмность";
            // 
            // CarForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 363);
            Controls.Add(tbCapacity);
            Controls.Add(label4);
            Controls.Add(tbNumber);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(btAdd);
            Controls.Add(tbBrand);
            Controls.Add(label1);
            Controls.Add(dgvCars);
            Name = "CarForms";
            Text = "Form1";
            Load += CarForms_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCars;
        private TextBox tbBrand;
        private Button btAdd;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox tbNumber;
        private Label label3;
        private TextBox tbCapacity;
        private Label label4;
    }
}
