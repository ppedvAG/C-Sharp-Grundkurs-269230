namespace Tag6_WindowsForms
{
    partial class frmCalculator
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
            lblZahl1 = new Label();
            lblZahl2 = new Label();
            lblErgebnis = new Label();
            txtZahl1 = new TextBox();
            txtZahl2 = new TextBox();
            lblAusgabe = new Label();
            btnBerechne = new Button();
            btnLöschen = new Button();
            lblGleichzeichen = new Label();
            cmbRechenoperation = new ComboBox();
            SuspendLayout();
            // 
            // lblZahl1
            // 
            lblZahl1.AutoSize = true;
            lblZahl1.Location = new Point(24, 25);
            lblZahl1.Name = "lblZahl1";
            lblZahl1.Size = new Size(55, 25);
            lblZahl1.TabIndex = 0;
            lblZahl1.Text = "Zahl1";
            // 
            // lblZahl2
            // 
            lblZahl2.AutoSize = true;
            lblZahl2.Location = new Point(216, 25);
            lblZahl2.Name = "lblZahl2";
            lblZahl2.Size = new Size(55, 25);
            lblZahl2.TabIndex = 1;
            lblZahl2.Text = "Zahl2";
            // 
            // lblErgebnis
            // 
            lblErgebnis.AutoSize = true;
            lblErgebnis.Location = new Point(369, 25);
            lblErgebnis.Name = "lblErgebnis";
            lblErgebnis.Size = new Size(80, 25);
            lblErgebnis.TabIndex = 2;
            lblErgebnis.Text = "Ergebnis";
            // 
            // txtZahl1
            // 
            txtZahl1.Location = new Point(24, 67);
            txtZahl1.Name = "txtZahl1";
            txtZahl1.Size = new Size(110, 31);
            txtZahl1.TabIndex = 3;
            // 
            // txtZahl2
            // 
            txtZahl2.Location = new Point(216, 67);
            txtZahl2.Name = "txtZahl2";
            txtZahl2.Size = new Size(110, 31);
            txtZahl2.TabIndex = 4;
            // 
            // lblAusgabe
            // 
            lblAusgabe.AutoSize = true;
            lblAusgabe.Location = new Point(387, 73);
            lblAusgabe.Name = "lblAusgabe";
            lblAusgabe.Size = new Size(0, 25);
            lblAusgabe.TabIndex = 5;
            // 
            // btnBerechne
            // 
            btnBerechne.Location = new Point(28, 148);
            btnBerechne.Name = "btnBerechne";
            btnBerechne.Size = new Size(112, 34);
            btnBerechne.TabIndex = 7;
            btnBerechne.Text = "berechnen";
            btnBerechne.UseVisualStyleBackColor = true;
            btnBerechne.Click += btnBerechne_Click;
            btnBerechne.MouseLeave += btnBerechne_MouseLeave;
            btnBerechne.MouseHover += btnBerechne_MouseHover;
            // 
            // btnLöschen
            // 
            btnLöschen.Location = new Point(214, 148);
            btnLöschen.Name = "btnLöschen";
            btnLöschen.Size = new Size(112, 34);
            btnLöschen.TabIndex = 8;
            btnLöschen.Text = "löschen";
            btnLöschen.UseVisualStyleBackColor = true;
            btnLöschen.Click += btnLöschen_Click;
            // 
            // lblGleichzeichen
            // 
            lblGleichzeichen.AutoSize = true;
            lblGleichzeichen.Location = new Point(345, 73);
            lblGleichzeichen.Name = "lblGleichzeichen";
            lblGleichzeichen.Size = new Size(24, 25);
            lblGleichzeichen.TabIndex = 9;
            lblGleichzeichen.Text = "=";
            // 
            // cmbRechenoperation
            // 
            cmbRechenoperation.FormattingEnabled = true;
            cmbRechenoperation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbRechenoperation.Location = new Point(140, 67);
            cmbRechenoperation.Name = "cmbRechenoperation";
            cmbRechenoperation.Size = new Size(65, 33);
            cmbRechenoperation.TabIndex = 10;
            cmbRechenoperation.SelectedIndexChanged += cmbRechenoperation_SelectedIndexChanged;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(870, 591);
            Controls.Add(cmbRechenoperation);
            Controls.Add(lblGleichzeichen);
            Controls.Add(btnLöschen);
            Controls.Add(btnBerechne);
            Controls.Add(lblAusgabe);
            Controls.Add(txtZahl2);
            Controls.Add(txtZahl1);
            Controls.Add(lblErgebnis);
            Controls.Add(lblZahl2);
            Controls.Add(lblZahl1);
            Name = "frmCalculator";
            Text = "Caltulator";
            Load += frmCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblZahl1;
        private Label lblZahl2;
        private Label lblErgebnis;
        private TextBox txtZahl1;
        private TextBox txtZahl2;
        private Label lblAusgabe;
        private Button btnBerechne;
        private Button btnLöschen;
        private Label lblGleichzeichen;
        private ComboBox cmbRechenoperation;
    }
}
