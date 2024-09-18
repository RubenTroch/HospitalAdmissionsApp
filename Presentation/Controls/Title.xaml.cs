using System.Windows;
using System.Windows.Controls;

namespace HospitalAdmissionsApp.Presentation.Components;

public partial class Title : UserControl
{
    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register("Text", typeof(string), typeof(Title), new PropertyMetadata(string.Empty));

    public string Text { get; set; } = string.Empty;

    public Title()
    {
        InitializeComponent();
    }
}