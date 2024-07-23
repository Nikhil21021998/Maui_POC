namespace KudosePOC;
using KudosePOC.ViewModels;
using Plugin.Maui.SegmentedControl;

public partial class Kudose : ContentPage
{
    public Kudose()
    {
        InitializeComponent();
        BindingContext = new KudosViewModel(); // Set ViewModel as BindingContext
    }
}