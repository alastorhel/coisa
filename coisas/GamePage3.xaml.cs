namespace coisas;

public partial class GamePage3 : ContentPage
{

	public GamePage3()
	{
		InitializeComponent();
	}
	
	void ClicarVaiProximo(object sender, EventArgs args)
	{
         Application.Current.MainPage = new MainPage();
	}
}
