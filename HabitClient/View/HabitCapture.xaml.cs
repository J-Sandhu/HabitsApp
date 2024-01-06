using Controller;
using Mopups.Services;

namespace View;

public partial class HabitCapture
{
	HabitController c;							//controller for sending off data captured from user
	public HabitCapture(HabitController c)
	{
		this.c = c;								//get controller from main page
		InitializeComponent();
	}
	/// <summary>
	/// When the user clicks confirm, collates user inputs into a Model.HabitSpecs object
	/// and uses the controller to begin working on creating a habit. Then exits the Mopup
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public void HabitCaptureConfirmClicked(object sender, EventArgs e)
	{
		c.AddHabit(new Model.HabitSpecs(HabitName.Text, false, Positive.IsChecked, Negative.IsChecked));
		MopupService.Instance.PopAsync();
	}
	/// <summary>
	/// When the user clicks cancel, exits the Mopup
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public void DataCaptureCancelClicked(object sender, EventArgs e) 
	{
		MopupService.Instance.PopAsync();
	}
}