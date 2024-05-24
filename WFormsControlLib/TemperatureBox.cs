namespace WFormsControlLib
{
   
    [ToolboxBitmap(typeof(TemperatureBox), "TemperaturBox.bmp")]
    public partial class TemperatureBox : UserControl
    {
        public TemperatureBox() //конструктор
        {
            InitializeComponent();

        }

        private double temperatureCelsius;//Переменная для Цельсия
        public event EventHandler TemperatureChanged;//обьявление соб

        private void textBoxCelsius_TextChanged(object sender, EventArgs e) //событие для изменения текста
        {
            if (double.TryParse(textBoxC.Text, out double tempC))
            {
                temperatureCelsius = tempC;
                textBoxK.Text = (tempC + 273.15).ToString("F2");
                textBoxF.Text = (tempC * 9 / 5 + 32).ToString("F2");
                OnTemperatureChanged(EventArgs.Empty);
            }
        }
        public double TemperatureCelsius //свойство
        {
            get { return temperatureCelsius; }
            set
            {
                temperatureCelsius = value;
                textBoxC.Text = value.ToString("F2");
            }
        }

        protected virtual void OnTemperatureChanged(EventArgs e) //оброботчик событий
        {
            TemperatureChanged?.Invoke(this, e);
        }

        private void lblK_Click(object sender, EventArgs e)
        {

        }
    }
}
