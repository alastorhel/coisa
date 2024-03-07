namespace coisas;

public partial class GamePage : ContentPage
{

	public GamePage()
	{
		InitializeComponent();
	}
	void Clicarnobotaao(object sender, EventArgs args)
    {
		Application.Current.MainPage = new GamePage();
	}
	

}

