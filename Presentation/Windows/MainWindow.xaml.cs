using System.Windows.Navigation;

namespace HospitalAdmissionsApp.Presentation.Windows;

public partial class MainWindow : NavigationWindow
{
    public MainWindow()
    {
        InitializeComponent();
        ShowsNavigationUI = false;
    }
}
