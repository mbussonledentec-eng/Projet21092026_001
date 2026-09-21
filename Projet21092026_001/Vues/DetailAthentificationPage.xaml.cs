using Projet21092026_001.VuesModeles;

namespace Projet21092026_001.Vues;

public partial class DetailAthentificationPage : ContentPage
{
	public DetailAthentificationPage()
	{
		InitializeComponent();
        BindingContext = new DetailAthentificationViewModel();
    }
}