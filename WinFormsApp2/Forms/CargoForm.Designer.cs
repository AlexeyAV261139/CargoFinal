namespace WinFormsApp2
{
    partial class CargoForm
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
            button1 = new Button();
            label2 = new Label();
            btAdd = new Button();
            tbRequirements = new TextBox();
            label1 = new Label();
            btUpdateTable = new Button();
            dgvCargos = new DataGridView();
            label3 = new Label();
            cbCargoType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCargos).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(311, 111);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(447, 77);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 12;
            label2.Text = "Добавление груза";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(478, 263);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 9;
            btAdd.Text = "Сохранить";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // tbRequirements
            // 
            tbRequirements.Location = new Point(543, 146);
            tbRequirements.Multiline = true;
            tbRequirements.Name = "tbRequirements";
            tbRequirements.Size = new Size(121, 96);
            tbRequirements.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 149);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 10;
            label1.Text = "Требования";
            // 
            // btUpdateTable
            // 
            btUpdateTable.Location = new Point(138, 219);
            btUpdateTable.Name = "btUpdateTable";
            btUpdateTable.Size = new Size(75, 23);
            btUpdateTable.TabIndex = 11;
            btUpdateTable.Text = "Обновить";
            btUpdateTable.UseVisualStyleBackColor = true;
            btUpdateTable.Click += btUpdateTable_ClickAsync;
            // 
            // dgvCargos
            // 
            dgvCargos.AllowUserToAddRows = false;
            dgvCargos.AllowUserToDeleteRows = false;
            dgvCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCargos.Location = new Point(65, 63);
            dgvCargos.Name = "dgvCargos";
            dgvCargos.ReadOnly = true;
            dgvCargos.Size = new Size(240, 150);
            dgvCargos.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 120);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 15;
            label3.Text = "Тип груза";
            // 
            // cbCargoType
            // 
            cbCargoType.FormattingEnabled = true;
            cbCargoType.Location = new Point(543, 117);
            cbCargoType.Name = "cbCargoType";
            cbCargoType.Size = new Size(121, 23);
            cbCargoType.TabIndex = 16;
            cbCargoType.SelectedIndexChanged += cbCargoType_SelectedIndexChanged;
            // 
            // CargoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbCargoType);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(btAdd);
            Controls.Add(tbRequirements);
            Controls.Add(label1);
            Controls.Add(btUpdateTable);
            Controls.Add(dgvCargos);
            Name = "CargoForm";
            Text = "Form1";
            Load += CargoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCargos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Button btAdd;
        private TextBox tbRequirements;
        private Label label1;
        private Button btUpdateTable;
        private DataGridView dgvCargos;
        private Label label3;
        private ComboBox cbCargoType;
    }
}