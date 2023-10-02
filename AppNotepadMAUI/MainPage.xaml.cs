namespace AppNotepadMAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void BtnAut_Clicked(object sender, EventArgs e)
    {
        Services.Authorization authorization 
            = new Services.Authorization();
        try
        {
            authorization.GetUser(entryLogin.Text, entryPassword.Text);
            Pages.PageMenu pageMenu = new Pages.PageMenu();
            await Navigation.PushModalAsync(pageMenu);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Уведомление",ex.Message, "ОK");
            entryLogin.Text = "";
            entryPassword.Text = "";
            entryLogin.Focus();
        }
    }
}

