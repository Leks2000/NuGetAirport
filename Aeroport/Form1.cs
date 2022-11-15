using System.Numerics;
using System.Windows.Forms;
using Aeroport.Classes;

namespace Aeroport
{
    public partial class Aero : Form
    {
        private NewAirp.buisnessLogic<Flight> flights;
        private readonly List<Flight> flight;
        private readonly BindingSource bindingSource;
        private decimal sum = 0;
        public Aero()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            flight = new List<Flight>();
            flights = new NewAirp.buisnessLogic<Flight>();
            bindingSource = new BindingSource();
            bindingSource.DataSource = flights.Get();
            dataGridView1.DataSource = bindingSource;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ChangeMenu.Enabled = DeleteMenu.Enabled = Change.Enabled = Delete.Enabled = dataGridView1.SelectedRows.Count > 0;
        }
        public void CalculateStats()
        {
            var count = flight.Count;
            var Res = 0.0m;
            var Pass = 0.0m;
            var ColB = 0.0m;
            toolStripStatusLabel1.Text = $"Column flights: " + count;
            foreach (var plane in flight)
            {
                Pass += flights.Get().Sum(x => x.ColPas);
                ColB += flights.Get().Sum(x => x.ColBuil);
                Res += flights.Get().Sum(x => (x.ColPas * x.Pass + x.ColBuil * x.Build) * ((100.0m + x.Percent) / 100.0m));
            }
            toolStripStatusLabel2.Text = $"Total revenue: {Res}";
            toolStripStatusLabel3.Text = $"Quantity passanger: {Pass}";
            toolStripStatusLabel4.Text = $"Quantity crew: {ColB}";
        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Result")
            {
                var data = (Flight)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                sum += (data.ColPas * data.Pass + data.ColBuil * data.Build) * ((100.0m + data.Percent) / 100.0m);
                e.Value = sum;
                sum = 0;
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            var infoForm = new InfoAirFlightes();
            infoForm.Text = "Edith Flights";
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                flights.AddRace(infoForm.Flight);
                bindingSource.ResetBindings(false);
                CalculateStats();
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            var id = (Flight)(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem);
            var infoForm = new InfoAirFlightes(id);
            infoForm.Text = "Edith Flights";
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                id.Numfl = infoForm.Flight.Numfl;
                id.TypeAir = infoForm.Flight.TypeAir;
                id.ColPas = infoForm.Flight.ColPas;
                id.ColBuil = infoForm.Flight.ColBuil;
                id.Pass = infoForm.Flight.Pass;
                id.Build = infoForm.Flight.Build;
                id.Percent = infoForm.Flight.Percent;
                id.TimeIn = infoForm.Flight.TimeIn;

                flights.Change(id, infoForm.Flight);
                bindingSource.ResetBindings(false);
                CalculateStats();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var id = (Flight)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Do you really want to delete the flight number '{id.Numfl}'?",
                "Delete record",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                flights.Delete(id);
                bindingSource.ResetBindings(false);
                CalculateStats();
            }
        }

        private void AddMenu_Click_1(object sender, EventArgs e)
        {
            Add_Click(sender, e);
        }

        private void ChangeMenu_Click(object sender, EventArgs e)
        {
            Change_Click(sender, e);
        }

        private void DeleteMenu_Click(object sender, EventArgs e)
        {
            Delete_Click(sender, e);
        }

        private void AboutProgrammMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press OK", "Airport",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
