namespace coisas;

public partial class MainPage : ContentPage
{

	public MainPage ()
	{
		InitializeComponent();
	}
	void Clicarnobotão(object sender, EventArgs args)
    {
		Application.Current.MainPage = new GamePage();
	}

    void Clicarnobotao(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage();
	}
	
	

}