using Projet21092026_001.Vues;

namespace Projet21092026_001
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(
                nameof(DetailAthentificationPage),
                typeof(DetailAthentificationPage));
        }
    }
}
