namespace coisas;

public partial class MainPage1 : ContentPage
{

	public MainPage1 ()
	{
		InitializeComponent();
	}

    void Clicarnobotaovoltar(object sender, EventArgs args)
	{
		if (Application.Current != null)
      Application.Current.MainPage = new MainPage();
	    framehistoria.IsVisible=true;
	}
}