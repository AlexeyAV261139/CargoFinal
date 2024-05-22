namespace WinFormsApp2
{
    partial class RoutesForm
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
            label1 = new Label();
            btUpdateTable = new Button();
            dgvRoutes = new DataGridView();
            cbDificultyClass = new ComboBox();
            tbDestination = new TextBox();
            tbDistanceKm = new TextBox();
            tbPrice = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRoutes).BeginInit();
            SuspendLayout();
            // 
            // btDelete
            // 
            btDelete.Location = new Point(207, 353);
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
            label2.Location = new Point(526, 155);
            label2.Name = "label2";
            label2.Size = new Size(206, 15);
            label2.TabIndex = 22;
            label2.Text = "Добавление возможного маршрута";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(560, 322);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 19;
            btAdd.Text = "Сохранить";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(502, 194);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 20;
            label1.Text = "Место назначения";
            // 
            // btUpdateTable
            // 
            btUpdateTable.Location = new Point(59, 353);
            btUpdateTable.Name = "btUpdateTable";
            btUpdateTable.Size = new Size(75, 23);
            btUpdateTable.TabIndex = 21;
            btUpdateTable.Text = "Обновить";
            btUpdateTable.UseVisualStyleBackColor = true;
            btUpdateTable.Click += btUpdateTable_Click;
            // 
            // dgvCargos
            // 
            dgvRoutes.AllowUserToAddRows = false;
            dgvRoutes.AllowUserToDeleteRows = false;
            dgvRoutes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoutes.Location = new Point(12, 56);
            dgvRoutes.Name = "dgvCargos";
            dgvRoutes.ReadOnly = true;
            dgvRoutes.Size = new Size(399, 281);
            dgvRoutes.TabIndex = 17;
            // 
            // cbDificultyClass
            // 
            cbDificultyClass.FormattingEnabled = true;
            cbDificultyClass.Location = new Point(617, 249);
            cbDificultyClass.Name = "cbDificultyClass";
            cbDificultyClass.Size = new Size(125, 23);
            cbDificultyClass.TabIndex = 24;
            cbDificultyClass.SelectedIndexChanged += cbDificultyClass_SelectedIndexChanged;
            // 
            // tbDestination
            // 
            tbDestination.Location = new Point(617, 191);
            tbDestination.Name = "tbDestination";
            tbDestination.Size = new Size(125, 23);
            tbDestination.TabIndex = 25;
            // 
            // tbDistanceKm
            // 
            tbDistanceKm.Location = new Point(617, 220);
            tbDistanceKm.Name = "tbDistanceKm";
            tbDistanceKm.Size = new Size(125, 23);
            tbDistanceKm.TabIndex = 26;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(617, 279);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(125, 23);
            tbPrice.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(463, 223);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 28;
            label3.Text = "Расстояние в километрах";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 252);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 29;
            label4.Text = "Класс сложности";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 282);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 30;
            label5.Text = "Стоимость";
            // 
            // RoutesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbPrice);
            Controls.Add(tbDistanceKm);
            Controls.Add(tbDestination);
            Controls.Add(cbDificultyClass);
            Controls.Add(btDelete);
            Controls.Add(label2);
            Controls.Add(btAdd);
            Controls.Add(label1);
            Controls.Add(btUpdateTable);
            Controls.Add(dgvRoutes);
            Name = "RoutesForm";
            Text = "Form1";
            Load += RoutesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoutes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btDelete;
        private Label label2;
        private Button btAdd;
        private Label label1;
        private Button btUpdateTable;
        private DataGridView dgvRoutes;
        private ComboBox cbDificultyClass;
        private TextBox tbDestination;
        private TextBox tbDistanceKm;
        private TextBox tbPrice;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}