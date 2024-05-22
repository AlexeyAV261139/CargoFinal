namespace WinFormsApp2
{
    partial class TripForm
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
            btUpdateTable = new Button();
            dgvDrivers = new DataGridView();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            cbRoute = new ComboBox();
            cbCargo = new ComboBox();
            cbCar = new ComboBox();
            cbDriver = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            SuspendLayout();
            // 
            // btDelete
            // 
            btDelete.Location = new Point(257, 517);
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
            label2.Location = new Point(913, 226);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 22;
            label2.Text = "Добавление рейса";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(913, 444);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 19;
            btAdd.Text = "Сохранить";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btUpdateTable
            // 
            btUpdateTable.Location = new Point(109, 517);
            btUpdateTable.Name = "btUpdateTable";
            btUpdateTable.Size = new Size(75, 23);
            btUpdateTable.TabIndex = 21;
            btUpdateTable.Text = "Обновить";
            btUpdateTable.UseVisualStyleBackColor = true;
            btUpdateTable.Click += btUpdateTable_Click;
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.AllowUserToDeleteRows = false;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.Location = new Point(12, 40);
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dgvDrivers.Size = new Size(737, 372);
            dgvDrivers.TabIndex = 17;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(871, 244);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(200, 23);
            dtpStart.TabIndex = 24;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(871, 273);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(200, 23);
            dtpEnd.TabIndex = 25;
            // 
            // cbRoute
            // 
            cbRoute.FormattingEnabled = true;
            cbRoute.Location = new Point(871, 302);
            cbRoute.Name = "cbRoute";
            cbRoute.Size = new Size(200, 23);
            cbRoute.TabIndex = 26;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(871, 389);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(200, 23);
            cbCargo.TabIndex = 27;
            // 
            // cbCar
            // 
            cbCar.FormattingEnabled = true;
            cbCar.Location = new Point(871, 360);
            cbCar.Name = "cbCar";
            cbCar.Size = new Size(200, 23);
            cbCar.TabIndex = 28;
            // 
            // cbDriver
            // 
            cbDriver.FormattingEnabled = true;
            cbDriver.Location = new Point(871, 331);
            cbDriver.Name = "cbDriver";
            cbDriver.Size = new Size(200, 23);
            cbDriver.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(850, 250);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 30;
            label1.Text = "C";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(842, 281);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 31;
            label3.Text = "По";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(805, 305);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 32;
            label4.Text = "Маршрут";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(807, 334);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 33;
            label5.Text = "Водитель";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(832, 360);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 34;
            label6.Text = "Авто";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(834, 389);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 35;
            label7.Text = "Груз";
            // 
            // TripForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 639);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cbDriver);
            Controls.Add(cbCar);
            Controls.Add(cbCargo);
            Controls.Add(cbRoute);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(btDelete);
            Controls.Add(label2);
            Controls.Add(btAdd);
            Controls.Add(btUpdateTable);
            Controls.Add(dgvDrivers);
            Name = "TripForm";
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
        private Button btUpdateTable;
        private DataGridView dgvDrivers;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private ComboBox cbRoute;
        private ComboBox cbCargo;
        private ComboBox cbCar;
        private ComboBox cbDriver;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}