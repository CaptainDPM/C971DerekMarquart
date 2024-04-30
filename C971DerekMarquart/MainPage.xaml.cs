using System.Security.Cryptography;

namespace C971DerekMarquart
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

        private void OnCounterClickedRandom(object sender, EventArgs e)
        {
            Random randomNum = new Random();
            CounterBtn2.Text = randomNum.Next().ToString();
        }
    }

}
