using Mopups.Pages;
using Mopups.Services;

namespace View
{
    public partial class MainPage : ContentPage
    {
         Controller.HabitController c;

        public MainPage()
        {
            c = new();
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
            foreach (IView item in MainWindow.Children)
            {
                if (item is Label && item.Semantics != null)
                {
                    VisualElement VisItem = (VisualElement)item;

                    if (item.Semantics.Description.StartsWith("HabitItem"))
                        VisItem.IsVisible = true;
                    else VisItem.IsVisible = false;
                }
            }
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
            foreach (IView item in MainWindow.Children)
            {
                if (item is Label && item.Semantics != null)
                {
                    VisualElement VisItem = (VisualElement)item;

                    if (item.Semantics.Description.StartsWith("DailyListItem"))
                        VisItem.IsVisible = true;
                    else VisItem.IsVisible = false;
                }
            }
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
            foreach (IView item in MainWindow.Children)
            {
                if (item is Label && item.Semantics != null)
                {
                    VisualElement VisItem = (VisualElement)item;

                    if (item.Semantics.Description.StartsWith("ToDoItem"))
                        VisItem.IsVisible = true;
                    else VisItem.IsVisible = false;
                }
            }
        }
        private void OnNewTaskClicked(object sender, EventArgs e)
        {
            MopupService.Instance.PushAsync(new HabitCapture(c));
        }


    }
}