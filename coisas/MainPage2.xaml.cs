namespace coisas;

public partial class MainPage2 : ContentPage
{

	public MainPage2 ()
	{
		InitializeComponent();
	}
     void Clicarnobotaovoltarprodutores(object sender, EventArgs args)
	{
		if (Application.Current != null)
      Application.Current.MainPage = new MainPage();
	    frameprodutores.IsVisible=true;
	}
}