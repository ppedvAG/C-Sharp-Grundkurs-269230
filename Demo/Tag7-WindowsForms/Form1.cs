namespace Tag7_WindowsForms
{
    using Fahrzeugpark;
    using System.Xml.Serialization;

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

        private void btnLoadVehicles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "vehicles.xml";
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    var known = new Type[] { typeof(Flugzeug), typeof(PKW), typeof(Schiff) };
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Fahrzeug>), known);
                    vehicles = (List<Fahrzeug>)serializer.Deserialize(sr);
                    reloadList();
                }
            }
        }

        private void btnSaveVehicles_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "vehicles.xml";
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                using (StreamWriter sw = new StreamWriter(filePath))
                {

                    var known = new Type[] { typeof(Flugzeug), typeof(PKW), typeof(Schiff) };
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Fahrzeug>), known);
                    sw.Write("");
                    serializer.Serialize(sw, vehicles);

                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            vehicles.Clear();
            reloadList();
        }
    }
}
