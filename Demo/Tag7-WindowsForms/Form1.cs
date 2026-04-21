namespace Tag7_WindowsForms
{
    using Fahrzeugpark;
    public partial class Form1 : Form
    {
        List<Fahrzeug> vehicles = new List<Fahrzeug>();
        int counter = 1;

        void reloadList()
        {
            lstVehicles.Items.Clear();
            lstVehicles.Items.AddRange(vehicles.ToArray());
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOutput.Text = "";

        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            vehicles.Add(Fahrzeug.GeneriereFahreug(counter.ToString()));
            counter++;

            reloadList();
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (lstVehicles.SelectedIndex >= 0)
                vehicles.RemoveAt(lstVehicles.SelectedIndex);
            reloadList();
        }

        private void lstVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (lstVehicles.SelectedIndex >= 0)
            {
                lblOutput.Text = vehicles[lstVehicles.SelectedIndex].Info();
            }
            else
            {
                lblOutput.Text = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Wollen Sie wirklich beenden?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;

            }
        }
    }
}
