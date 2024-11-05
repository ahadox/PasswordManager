namespace PasswordManager.Views;

public partial class NewPasswordView : ContentPage
{
	public NewPasswordView()
	{
		InitializeComponent();
	}

    private void OnCancelClicked(object sender, EventArgs e)
    {

    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {

    }

    private void OnGeneratePasswordClicked(object sender, EventArgs e)
    {

    }

    private void LengthStepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        LengthEntry.Text = e.NewValue.ToString();
    }
}