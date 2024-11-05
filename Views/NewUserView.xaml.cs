namespace PasswordManager.Views;

public partial class NewUserView : ContentPage
{
	public NewUserView()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    { 
         App.Current.MainPage = new Views.PasswordListView();

        
    }
}