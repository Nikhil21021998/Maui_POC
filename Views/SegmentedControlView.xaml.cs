namespace KudosePOC.Views;
using KudosePOC.ViewModels;

public partial class SegmentedControlView : ContentView
{
    public SegmentedControlView()
    {
        InitializeComponent();
        BindingContext = new KudosViewModel();
    }
}