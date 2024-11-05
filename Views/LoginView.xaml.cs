namespace PasswordManager.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

 

    private async void Button_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new Views.PasswordListView();

    }
}