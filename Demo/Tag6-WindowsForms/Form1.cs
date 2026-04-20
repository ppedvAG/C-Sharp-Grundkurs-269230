namespace Tag6_WindowsForms
{
    public partial class frmCalculator : Form
    {
        enum Rechenoperation
        {
            Addition,
            Subtraktion,
            Multiplikation,
            Division
        }

        Rechenoperation ausgewaehlteOperation;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnBerechne_Click(object sender, EventArgs e)
        {
            int zahl1, zahl2;
            if (int.TryParse(txtZahl1.Text, out zahl1) && int.TryParse(txtZahl2.Text, out zahl2))
            {
                switch (ausgewaehlteOperation)
                {
                    case Rechenoperation.Addition:
                        lblAusgabe.Text = (zahl1 + zahl2).ToString();
                        break;
                    case Rechenoperation.Subtraktion:
                        lblAusgabe.Text = (zahl1 - zahl2).ToString();
                        break;
                    case Rechenoperation.Multiplikation:
                        lblAusgabe.Text = (zahl1 * zahl2).ToString();
                        break;
                    default:
                        if (zahl2 != 0)
                            lblAusgabe.Text = (zahl1 / zahl2).ToString();
                        else
                            MessageBox.Show("Division durch Null ist nicht erlaubt!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                

            }
            else
            {

                MessageBox.Show("Bitte gültige Zahlen eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            txtZahl1.Clear();
            txtZahl2.Clear();
            lblAusgabe.Text = "";
            cmbRechenoperation.SelectedIndex = 0;
        }

        private void btnBerechne_MouseHover(object sender, EventArgs e)
        {
            btnBerechne.BackColor = Color.LightGreen;
        }

        private void btnBerechne_MouseLeave(object sender, EventArgs e)
        {
            btnBerechne.BackColor = SystemColors.Control;
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            cmbRechenoperation.SelectedIndex = 0;
        }

        private void cmbRechenoperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ausgewaehlteOperation = (Rechenoperation)cmbRechenoperation.SelectedIndex;
        }
    }
}
