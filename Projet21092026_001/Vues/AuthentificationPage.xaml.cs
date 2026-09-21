using Projet21092026_001.VuesModeles;

namespace Projet21092026_001.Vues;

public partial class AuthentificationPage : ContentPage
{
	public AuthentificationPage()
	{
		InitializeComponent();
		BindingContext = new AthentificationViewModel();
    }
}