using System.Drawing;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            object[] enums = new object[] { typeof(Color), typeof(EducationForm), typeof(Genre),
                typeof(Manufactures), typeof(Season), typeof(Weekday)};
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;

            SeasonComboBox.Items.AddRange(new string[]  {Convert.ToString(Season.Autumn),
                                                         Convert.ToString(Season.Summer),
                                                         Convert.ToString(Season.Spring),
                                                         Convert.ToString(Season.Winter)});

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

        }

        private void ValuesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (ValuesListBox.Items == null)
            {
                return;
            }

            else
            {
                ValuesTextBox.Text = ((int)Enum.Parse(Type.GetType(EnumsListBox.Text), ValuesListBox.Text)).ToString();
            }

        }      
       
        private void WeekDayParsingButton_Click(object sender, EventArgs e)
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

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.Text)
            {
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case "Spring":
                    BackColor = ColorTranslator.FromHtml("#559c45"); ;
                    break;
                
                default:
                    MessageBox.Show("Выберите время года!");
                    break;

            }    
        }
    }
}
    
