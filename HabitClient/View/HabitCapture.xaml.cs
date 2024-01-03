using Mopups.Services;

namespace View;

public partial class HabitCapture
{
	public HabitCapture()
	{
		InitializeComponent();
	}
	public void HabitCaptureConfirmClicked(object sender, EventArgs e)
	{
		MopupService.Instance.PopAsync();
	}
	public void DataCaptureCancelClicked(object sender, EventArgs e) 
	{
		MopupService.Instance.PopAsync();
	}
}