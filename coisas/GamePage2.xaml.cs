namespace coisas;

public partial class GamePage2 : ContentPage
{

	public GamePage2()
	{
		InitializeComponent();
	}
	
	void ClicarVaiProximo(object sender, EventArgs args)
	{
         Application.Current.MainPage = new GamePage3();
	}
}
