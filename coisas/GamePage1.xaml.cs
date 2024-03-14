namespace coisas;

public partial class GamePage1 : ContentPage
{

	public GamePage1()
	{
		InitializeComponent();
	}
	
	void ClicarVaiProximo(object sender, EventArgs args)
	{
         Application.Current.MainPage = new GamePage2();
	}
}
