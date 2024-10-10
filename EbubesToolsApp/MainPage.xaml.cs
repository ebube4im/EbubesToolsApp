namespace EbubesToolsApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

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

        private void OnOneClicked(object sender, EventArgs e)
        {
            DisplayAlert("Notice", "One was clicked", "Exit");

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnTwoClicked(object sender, EventArgs e)
        {


            DisplayAlert("Notice", "Two was clicked", "Exit");

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnThreeClicked(object sender, EventArgs e)
        {
            DisplayAlert("Notice", "Three was clicked", "Exit");
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
