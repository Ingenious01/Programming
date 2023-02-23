namespace Programming
{
    public partial class Programming : Form
    {
        public Programming()
        {
            InitializeComponent();

            object[] enums = new object[] { typeof(Color), typeof(EducationForm), typeof(Genre),
                typeof(Manufactures), typeof(Season), typeof(Weekday)};
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EnumsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
            //ValuesTextBox.Clear();

        }

        private void ValuesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (ValuesListBox.Items == null)
            {
                return;
            }

            else
            {
                ValuesTextBox.Text = ((int)Enum.Parse(Type.GetType(EnumsListBox.Text),
                    ValuesListBox.Text)).ToString();
            }

        }

        private void ValuesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValuesTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void WDParcingLabel_Click(object sender, EventArgs e)
        {

        }

        private void WeekDayParcingButton_Click(object sender, EventArgs e)
        {
            if (Enum.IsDefined(typeof(Weekday), ParsingTextBox.Text))
            {
                int num = (int)Enum.Parse(typeof(Weekday), ParsingTextBox.Text);
                ParsingResultLabel.Text = $"Это день недели ({ParsingTextBox.Text} = {num})";  
                
                ParsingResultLabel.Visible= true ;

            }

            else
            {
                ParsingResultLabel.Text = "Не такого дня недели";

                ParsingResultLabel.Visible = true;
            }

        }
    }
}
    
