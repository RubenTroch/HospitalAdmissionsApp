using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Extensions.Logging;

namespace HospitalAdmissionsApp.Presentation.Pages;

public partial class LandingPage : Page
{
    public LandingPage() {}

    private void OnNewPatientButtonClicked(object sender, RoutedEventArgs e)
    {
        NavigationService.Navigate(new Uri("Presentation\\Pages\\PatientProfile.xaml", UriKind.Relative));
    }

    private void OnReturningPatientButtonClicked(object sender, RoutedEventArgs e)
    {
        NavigationService.Navigate(new Uri("Presentation\\Pages\\EmergencyVisitForm.xaml", UriKind.Relative));
    }
}
