namespace Tag7_WindowsForms
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
            lstVehicles = new ListBox();
            lblTop = new Label();
            lblOutput = new Label();
            btnNewVehicle = new Button();
            btnDeleteVehicle = new Button();
            btnLoadVehicles = new Button();
            btnSaveVehicles = new Button();
            btnClearAll = new Button();
            SuspendLayout();
            // 
            // lstVehicles
            // 
            lstVehicles.FormattingEnabled = true;
            lstVehicles.Location = new Point(15, 44);
            lstVehicles.Name = "lstVehicles";
            lstVehicles.Size = new Size(410, 229);
            lstVehicles.TabIndex = 0;
            lstVehicles.SelectedIndexChanged += lstVehicles_SelectedIndexChanged;
            // 
            // lblTop
            // 
            lblTop.AutoSize = true;
            lblTop.Location = new Point(15, 9);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(196, 25);
            lblTop.TabIndex = 1;
            lblTop.Text = "Vorhandene Fahrzeuge:";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(15, 276);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(82, 25);
            lblOutput.TabIndex = 2;
            lblOutput.Text = "Ausgabe";
            // 
            // btnNewVehicle
            // 
            btnNewVehicle.Location = new Point(431, 44);
            btnNewVehicle.Name = "btnNewVehicle";
            btnNewVehicle.Size = new Size(192, 34);
            btnNewVehicle.TabIndex = 3;
            btnNewVehicle.Text = "Neues Fahrzeug";
            btnNewVehicle.UseVisualStyleBackColor = true;
            btnNewVehicle.Click += btnNewVehicle_Click;
            // 
            // btnDeleteVehicle
            // 
            btnDeleteVehicle.Location = new Point(431, 84);
            btnDeleteVehicle.Name = "btnDeleteVehicle";
            btnDeleteVehicle.Size = new Size(192, 34);
            btnDeleteVehicle.TabIndex = 4;
            btnDeleteVehicle.Text = "Lösche Fahrzeug";
            btnDeleteVehicle.UseVisualStyleBackColor = true;
            btnDeleteVehicle.Click += btnDeleteVehicle_Click;
            // 
            // btnLoadVehicles
            // 
            btnLoadVehicles.Location = new Point(431, 124);
            btnLoadVehicles.Name = "btnLoadVehicles";
            btnLoadVehicles.Size = new Size(192, 34);
            btnLoadVehicles.TabIndex = 5;
            btnLoadVehicles.Text = "Lade Fahrzeuge";
            btnLoadVehicles.UseVisualStyleBackColor = true;
            btnLoadVehicles.Click += btnLoadVehicles_Click;
            // 
            // btnSaveVehicles
            // 
            btnSaveVehicles.Location = new Point(431, 164);
            btnSaveVehicles.Name = "btnSaveVehicles";
            btnSaveVehicles.Size = new Size(192, 34);
            btnSaveVehicles.TabIndex = 6;
            btnSaveVehicles.Text = "Fahrzeuge speichern";
            btnSaveVehicles.UseVisualStyleBackColor = true;
            btnSaveVehicles.Click += btnSaveVehicles_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(431, 204);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(192, 34);
            btnClearAll.TabIndex = 7;
            btnClearAll.Text = "alle löschen";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 327);
            Controls.Add(btnClearAll);
            Controls.Add(btnSaveVehicles);
            Controls.Add(btnLoadVehicles);
            Controls.Add(btnDeleteVehicle);
            Controls.Add(btnNewVehicle);
            Controls.Add(lblOutput);
            Controls.Add(lblTop);
            Controls.Add(lstVehicles);
            Name = "Form1";
            Text = "Fahrzeugpark";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehicles;
        private Label lblTop;
        private Label lblOutput;
        private Button btnNewVehicle;
        private Button btnDeleteVehicle;
        private Button btnLoadVehicles;
        private Button btnSaveVehicles;
        private Button btnClearAll;
    }
}
