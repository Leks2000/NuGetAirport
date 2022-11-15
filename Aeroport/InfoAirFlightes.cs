using Aeroport.Classes;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Aeroport
{
    public partial class InfoAirFlightes : Form
    {
        private readonly Flight flight;
        public InfoAirFlightes()
        {
            InitializeComponent();
            Fillplane();
            flight = new Flight
            {
                TypeAir = airplanes.Boing,
                TimeIn = DateTime.Now,
            };
            comboBox1.SelectedItem = Flight.TypeAir;
        }

        public InfoAirFlightes(Flight course)
           : this()
        {
            numericUpDown1.Value = course.Numfl;
            comboBox1.SelectedItem = course.TypeAir;
            numericUpDown2.Value = course.ColPas;
            numericUpDown4.Value = course.Pass;
            numericUpDown4.Value = course.ColBuil;
            numericUpDown5.Value = course.Build;
            numericUpDown6.Value = course.Percent;
            dateTimePicker1.Value = course.TimeIn;

        }
        public Flight Flight => flight;
        private void Fillplane()
        {
            foreach (airplanes item in Enum.GetValues(typeof(airplanes)))
            {
                comboBox1.Items.Add(item);
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            flight.Numfl = numericUpDown1.Value;
            Validate();
        }
        public void Validate()
        {
            SaveChanges.Enabled = !string.IsNullOrWhiteSpace(flight.TypeAir.ToString());
        }
        private void SaveChanges_Click(object sender, EventArgs e)
        {

            flight.TypeAir = (airplanes)comboBox1.SelectedIndex;
            flight.ColPas = numericUpDown2.Value;
            flight.Pass = numericUpDown3.Value;
            flight.ColBuil = numericUpDown4.Value;
            flight.Build = numericUpDown5.Value;
            flight.Percent = numericUpDown6.Value;
            flight.TimeIn = dateTimePicker1.Value;

            Close();
        }
    }
}
