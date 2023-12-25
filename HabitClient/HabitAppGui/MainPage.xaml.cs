namespace HabitAppGui
{
    public partial class MainPage : ContentPage
    {
//        int count = 0;            //for sample button

        public MainPage()
        {
            InitializeComponent();
        }

        //sample button method
        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}
        /// <summary>
        /// This function modifies the main window header text,
        /// hides everything currently in the main window and displays all of the user's habits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHabitsClicked(object sender, EventArgs e)
        {
            MainWindowTitle.Text = "Habits";
        }
        /// <summary>
        /// This function modifies the main window header text,
        /// hides everything currently in the main window and displays the user's daily task list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDailyListClicked(object sender, EventArgs e)
        {
            MainWindowTitle.Text = "Daily List";
        }
        /// <summary>
        /// This function modifies the main window header text,
        /// hides everything currently in the main window and displays the user's to do list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnToDoClicked(object sender, EventArgs e)
        {
            MainWindowTitle.Text = "To Do List";
        }

    }
}