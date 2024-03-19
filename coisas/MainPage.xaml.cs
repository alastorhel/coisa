namespace coisas;

public partial class MainPage : ContentPage
{

	public MainPage ()
	{
		InitializeComponent();
	}
	void Clicarnobotaoprodutores(object sender, EventArgs args)
    {
		//framebutton.IsVisible=true;
	}

    void clicarnobotaoinicio(object sender, EventArgs args)
	{
		 if (Application.Current != null)
      Application.Current.MainPage = new GamePage();
	  frameinicio.IsVisible=true;
	}
	 void clicarnobotaohistoria(object sender, EventArgs args)
	{
		if (Application.Current != null)
      Application.Current.MainPage = new MainPage1();
	    framehistoria.IsVisible=true;
	}
	void clicarnobotaovoltarinicio(object sender, EventArgs args)
    {
		frameinicio.IsVisible=false;
	}
	  
	void clicarnobotaovoltarhistoria(object sender, EventArgs args)
	{
		framehistoria.IsVisible=false;
	}
	 void Clicarnobotaoparaprodutores(object sender, EventArgs args)
	{
		 if (Application.Current != null)
      Application.Current.MainPage = new MainPage2();
	  frameprodutores.IsVisible=true;
	}
}
