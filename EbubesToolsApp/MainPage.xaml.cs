namespace EbubesToolsApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        double firstInput = 0;
        double secondInput = 0;
        double result = 0;
        string selectedOperator = "";
        string operations = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Display(object sender, EventArgs e)
        {
            var button = (Button)sender;

            DisplayBox.Text = DisplayBox.Text + button.Text;

            // DisplayAlert("Notice", button.Text, "Exit");


        }

        private void Operator(object sender, EventArgs e)
        {
            firstInput = double.Parse(DisplayBox.Text);
            var button = (Button)sender;
            selectedOperator = button.Text;
            operations = $"{firstInput} {selectedOperator} ";
            DisplayBox.Text = "";


        }

        private void Calculate(object sender, EventArgs e)
        {
            secondInput = double.Parse(DisplayBox.Text);


            switch (selectedOperator)
            {
                case "+":
                    result = firstInput + secondInput;
                    break;
                case "-":
                    result = firstInput - secondInput;
                    break;
                case "*":
                    result = firstInput * secondInput;
                    break;
                case "/":
                    result = firstInput / secondInput;
                    break;
                default:
                    result = firstInput;
                    break;
            }

            operations = $"{firstInput} {selectedOperator} {secondInput} = {result} ";
            DisplayBox.Text = operations;


        }

        private void Clear(object sender, EventArgs e)
        {
            firstInput = 0;
            secondInput = 0;
            result = 0;
            DisplayBox.Text = "";
            operations = "";
        }
    }

}
