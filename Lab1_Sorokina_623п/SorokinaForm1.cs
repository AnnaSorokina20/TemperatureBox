using WFormsControlLib;

namespace Lab1_Sorokina_623п
{
    public partial class SorokinaForm1 : Form
    {
        public SorokinaForm1()
        {
            InitializeComponent();
        }
        private void temperatureBox_TemperatureChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Temperature changed!");
        }

        private TemperatureBox temperatureBox;

        private void temperatureBox5_Load(object sender, EventArgs e)
        {

        }
    }
}
