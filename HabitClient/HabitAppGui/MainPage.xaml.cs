namespace HabitAppGui
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
        private void OnHabitsClicked(object sender, EventArgs e)
        {
            MainWindowTitle.Text = "Habits";
        }
        private void OnDailyListClicked(object sender, EventArgs e)
        {
            MainWindowTitle.Text = "Daily List";
        }
        private void OnToDoClicked(object sender, EventArgs e)
        {
            MainWindowTitle.Text = "To Do List";
        }

    }
}