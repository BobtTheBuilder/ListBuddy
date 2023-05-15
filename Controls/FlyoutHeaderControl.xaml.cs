namespace ListBuddy.Controls;

public partial class FlyoutHeaderControl : StackLayout
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();

		if (App.UserDetails != null)
		{
			lblUserName.Text = App.UserDetails.Username;
			lblUserEmail.Text = App.UserDetails.Email;
		}
	}
}