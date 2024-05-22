namespace WinFormsApp2.Forms
{
    partial class MainForm
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
            btCar = new Button();
            btCargo = new Button();
            btDriver = new Button();
            btRoute = new Button();
            btTrip = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btCar
            // 
            btCar.Location = new Point(7, 12);
            btCar.Name = "btCar";
            btCar.Size = new Size(80, 23);
            btCar.TabIndex = 0;
            btCar.Text = "Авто";
            btCar.UseVisualStyleBackColor = true;
            btCar.Click += btCar_Click;
            // 
            // btCargo
            // 
            btCargo.Location = new Point(88, 12);
            btCargo.Name = "btCargo";
            btCargo.Size = new Size(80, 23);
            btCargo.TabIndex = 1;
            btCargo.Text = "Грузы";
            btCargo.UseVisualStyleBackColor = true;
            btCargo.Click += btCargo_Click;
            // 
            // btDriver
            // 
            btDriver.Location = new Point(169, 12);
            btDriver.Name = "btDriver";
            btDriver.Size = new Size(80, 23);
            btDriver.TabIndex = 2;
            btDriver.Text = "Водители";
            btDriver.UseVisualStyleBackColor = true;
            btDriver.Click += btDriver_Click;
            // 
            // btRoute
            // 
            btRoute.Location = new Point(250, 12);
            btRoute.Name = "btRoute";
            btRoute.Size = new Size(80, 23);
            btRoute.TabIndex = 3;
            btRoute.Text = "Маршруты";
            btRoute.UseVisualStyleBackColor = true;
            btRoute.Click += btRoute_Click;
            // 
            // btTrip
            // 
            btTrip.Location = new Point(336, 12);
            btTrip.Name = "btTrip";
            btTrip.Size = new Size(80, 23);
            btTrip.TabIndex = 4;
            btTrip.Text = "Рейсы";
            btTrip.UseVisualStyleBackColor = true;
            btTrip.Click += btTrip_Click;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Location = new Point(30, 161);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(436, 171);
            Controls.Add(label1);
            Controls.Add(btTrip);
            Controls.Add(btRoute);
            Controls.Add(btDriver);
            Controls.Add(btCargo);
            Controls.Add(btCar);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCar;
        private Button btCargo;
        private Button btDriver;
        private Button btRoute;
        private Button btTrip;
        private Label label1;
    }
}