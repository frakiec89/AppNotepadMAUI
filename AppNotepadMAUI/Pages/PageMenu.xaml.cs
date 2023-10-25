namespace AppNotepadMAUI.Pages;

public partial class PageMenu : ContentPage
{
	public PageMenu()
	{
		InitializeComponent();
	}

    public PageMenu(string userName):this() 
    {
        UserName = userName;
        lanelName.Text = $"привет { userName}";
    }

    public string UserName { get; }
}