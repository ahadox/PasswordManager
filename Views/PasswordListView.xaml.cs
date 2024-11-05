using Microsoft.Maui.Graphics.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PasswordManager.Views;

public partial class PasswordListView : ContentPage
{
	public PasswordListView()
	{
		InitializeComponent();

        ObservableCollection<PasswordRow> psv = new ObservableCollection<PasswordRow>();
        psv.Add(new PasswordRow { UserID = 1, PasswordID = 1, Platform = "Facebook", Password = "sk2ksn0!" });
        psv.Add(new PasswordRow { UserID = 1, PasswordID = 1, Platform = "Google", Password = "sk2ksn0!" });
        psv.Add(new PasswordRow { UserID = 1, PasswordID = 1, Platform = "Spotify", Password = "sk2ksn0!" });
        psv.Add(new PasswordRow { UserID = 1, PasswordID = 1, Platform = "Youtube", Password = "sk2ksn0!" });
        psv.Add(new PasswordRow { UserID = 1, PasswordID = 1, Platform = "Apple", Password = "sk2ksn0!" });

        PasswordCollectionView.ItemsSource = psv;

    }



    private void CopyPassToClipboard(object sender, EventArgs e)
    {

    }

    private void EditPassword(object sender, EventArgs e)
    {

    }

    private void DeletePassword(object sender, EventArgs e)
    {

    }

    private void AddPasswordButton(object sender, EventArgs e)
    {

    }

    public class PasswordRow : BindableObject, INotifyPropertyChanged
    {
        public int UserID { get; set; }
        public int PasswordID { get; set; }
        public string Platform { get; set; } = "";
        private string _pass = "";
        private bool _isShown = false;
        private bool _editing = false;

        public string Password
        {
            get
            {
                return _pass;
            }
            set
            {
                _pass = value;
            }
        }

        public bool IsShown
        {
            get
            {
                return _isShown;
            }
            set
            {
                _isShown = value;
                OnPropertyChanged(nameof(Password));
                OnPropertyChanged(nameof(IsShown));
                OnPropertyChanged(nameof(ShowPass));
            }
        }

        public bool ShowPass
        {
            get
            {
                return !_isShown;
            }
        }

        public bool Editing
        {
            get
            {
                return _editing;
            }
            set
            {
                _editing = value;
                OnPropertyChanged(nameof(Editing));
        
                OnPropertyChanged(nameof(BackgroundColor));
                OnPropertyChanged(nameof(ShowToggle));
            }
        }

        public bool ShowToggle
        {
            get
            {
                return !_editing;
            }
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new Views.NewPasswordView();

    }
}