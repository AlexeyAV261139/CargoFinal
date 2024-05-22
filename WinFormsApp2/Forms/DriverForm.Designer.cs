namespace WinFormsApp2
{
    partial class DriverForm
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
            btDelete = new Button();
            label2 = new Label();
            btAdd = new Button();
            dgvDrivers = new DataGridView();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            tbPatromic = new TextBox();
            tbPhone = new TextBox();
            cbDificultyClass = new ComboBox();
            lble1 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpBirthdate = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            SuspendLayout();
            // 
            // btDelete
            // 
            btDelete.Location = new Point(48, 322);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 23;
            btDelete.Text = "Удалить";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_ClickAsync;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(705, 78);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 22;
            label2.Text = "Добавление водителя";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(696, 313);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 19;
            btAdd.Text = "Сохранить";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.AllowUserToDeleteRows = false;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.Location = new Point(21, 23);
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dgvDrivers.Size = new Size(574, 281);
            dgvDrivers.TabIndex = 17;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(711, 110);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(121, 23);
            tbFirstName.TabIndex = 31;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(711, 139);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(121, 23);
            tbLastName.TabIndex = 32;
            // 
            // tbPatromic
            // 
            tbPatromic.Location = new Point(711, 171);
            tbPatromic.Name = "tbPatromic";
            tbPatromic.Size = new Size(121, 23);
            tbPatromic.TabIndex = 33;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(711, 200);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(121, 23);
            tbPhone.TabIndex = 34;
            // 
            // cbDificultyClass
            // 
            cbDificultyClass.FormattingEnabled = true;
            cbDificultyClass.Location = new Point(711, 262);
            cbDificultyClass.Name = "cbDificultyClass";
            cbDificultyClass.Size = new Size(121, 23);
            cbDificultyClass.TabIndex = 35;
            cbDificultyClass.SelectedIndexChanged += cbDificultyClass_SelectedIndexChanged_1;
            // 
            // lble1
            // 
            lble1.AutoSize = true;
            lble1.Location = new Point(674, 113);
            lble1.Name = "lble1";
            lble1.Size = new Size(31, 15);
            lble1.TabIndex = 36;
            lble1.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(647, 142);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 37;
            label1.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(647, 174);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 38;
            label3.Text = "Отчетсво";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(650, 203);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 39;
            label4.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(638, 265);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 40;
            label5.Text = "Классность";
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Format = DateTimePickerFormat.Short;
            dtpBirthdate.Location = new Point(711, 229);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(121, 23);
            dtpBirthdate.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(614, 235);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 42;
            label6.Text = "Дата рождения";
            // 
            // DriverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 450);
            Controls.Add(label6);
            Controls.Add(dtpBirthdate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lble1);
            Controls.Add(cbDificultyClass);
            Controls.Add(tbPhone);
            Controls.Add(tbPatromic);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(btDelete);
            Controls.Add(label2);
            Controls.Add(btAdd);
            Controls.Add(dgvDrivers);
            Name = "DriverForm";
            Text = "Form1";
            Load += RoutesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btDelete;
        private Label label2;
        private Button btAdd;
        private DataGridView dgvDrivers;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbPatromic;
        private TextBox tbPhone;
        private ComboBox cbDificultyClass;
        private Label lble1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpBirthdate;
        private Label label6;
    }
}