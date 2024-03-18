namespace coisas;

public partial class MainPage1 : ContentPage
{

	public MainPage1 ()
	{
		InitializeComponent();
	}

 void clicarnobotaohistoria(object sender, EventArgs args)
	{
	    framehistoria.IsVisible=true;
	}
    	void clicarnobotaovoltarhistoria(object sender, EventArgs args)
	{
		framehistoria.IsVisible=false;
	}

}