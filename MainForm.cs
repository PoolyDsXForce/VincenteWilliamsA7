using VincenteWilliamsA7.Model;
using System.Text.Json;

namespace VincenteWilliamsA7
{
    /// <summary>
    /// This is the main form that allows the user to choose a file on their local library and upload it as a json file and display and sort that data using buttons that enable if the data is readable and present. 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        /// <summary>
        /// The data objects
        /// </summary>
        private List<Car>? DataObjects;
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            UpdateBtuttonStates();
        }
        /// <summary>
        /// Handles the Click event of the ChooseFileBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    string jsonData = File.ReadAllText(filePath);
                    DataObjects = JsonSerializer.Deserialize<List<Car>>(jsonData);
                    if (DataObjects != null)
                    {
                        SortByMakeAndPriceBtn.Enabled = true;
                        SortByMakeBtn.Enabled = true;
                        DisplayCars(DataObjects);
                    }
                    else
                    {
                        MessageBox.Show("No data found in the file.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while reading this file: {ex.Message}", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Handles the Click event of the SortByMakeBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SortByMakeBtn_Click(object sender, EventArgs e)
        {
            DataObjects.Sort();
            DisplayCars(DataObjects);
        }
        /// <summary>
        /// Handles the Click event of the SortByMakeAndPriceBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SortByMakeAndPriceBtn_Click(object sender, EventArgs e)
        {
            DataObjects.Sort(new CarComparer());
            DisplayCars(DataObjects);
        }
        /// <summary>
        /// Updates the btutton states.
        /// </summary>
        private void UpdateBtuttonStates()
        {
            SortByMakeBtn.Enabled = DataObjects != null && DataObjects.Count > 0;
            SortByMakeAndPriceBtn.Enabled = DataObjects != null && DataObjects.Count > 0;
        }
        /// <summary>
        /// Displays the cars.
        /// </summary>
        /// <param name="cars">The cars.</param>
        private void DisplayCars(List<Car> cars)
        {
            CarsListBox.Items.Clear();
            if (cars == null || cars.Count ==0)
            {
                CarsListBox.Items.Add("No Data Loaded");
            }
            else
            {
                foreach (var car in cars)
                {
                    CarsListBox.Items.Add(
                        $"Make: {car.Make}, Model: {car.Model}, Price: {car.Price}, Mileage: {car.Mileage}, Color: {car.Color}");
                }
            }

        }
    }
}
