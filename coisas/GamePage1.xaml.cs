namespace coisas;

public partial class GamePage1 : ContentPage
{

	public GamePage1()
	{
		InitializeComponent();
	}
	void Clicarnobotaao(object sender, EventArgs args)
    {
		Application.Current.MainPage = new GamePage();
	}
	void ClicarVaiProximo(object sender, EventArgs args)
	{
         Application.Current.MainPage = new GamePage();
	}
}
