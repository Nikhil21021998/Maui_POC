using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KudosePOC.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace KudosePOC.ViewModels
{
    public class KudosViewModel : ObservableObject
    {
        private readonly ObservableCollection<KudosItem> _kudosList = new();
        private readonly ObservableCollection<KudosItem> _myTeamKudosList = new();
        private readonly ObservableCollection<KudosItem> _allKudosList = new();
        private ObservableCollection<KudosItem> _displayedKudosList;

        private int _selectedSegmentIndex;

        public KudosViewModel()
        {
            // Initialize data
            InitializeData();

            SegmentSelectedCommand = new Command<int>(OnSegmentSelected);
        }

        public ObservableCollection<KudosItem> DisplayedKudosList
        {
            get => _displayedKudosList;
            set => SetProperty(ref _displayedKudosList, value);
        }

        public ICommand SegmentSelectedCommand { get; }

        private void OnSegmentSelected(int parameter)
        {
            Debug.WriteLine($"Selected segment: {parameter}");

            // Handle the segment selection here
            switch (parameter)
            {
                case 0:
                    DisplayedKudosList = _kudosList;
                    break;
                case 1:
                    DisplayedKudosList = _myTeamKudosList;
                    break;
                case 2:
                    DisplayedKudosList = _allKudosList;
                    break;
                    default:
                    DisplayedKudosList = _kudosList;
                    break;
            }
        }


        private void InitializeData()
        {
            // Populate KudosList (sample data)
            _kudosList.Add(new KudosItem { ImageURL = "iconfirst.png", ReceiverName = "Sophie Daltrey", GiverName = "Rosie Atkinson gave kudos to", Date = new DateOnly(2023, 6, 23) });
            _kudosList.Add(new KudosItem { ImageURL = "iconsecond.png", ReceiverName = "Rose Daltrey", GiverName = "Sam Mills gave kudos to", Date = new DateOnly(2024, 5, 9) });
            _kudosList.Add(new KudosItem { ImageURL = "iconthird.png", ReceiverName = "Rose Daltrey", GiverName = "Wendy Askewth gave kudos to", Date = new DateOnly(2024, 2, 10) });

            // Populate MyTeamKudosList (sample data)
            _myTeamKudosList.Add(new KudosItem { ImageURL = "iconfirst.png", ReceiverName = "Kevin Baker", GiverName = "Susan Barry gave kudos to", Date = new DateOnly(2023, 6, 23) });
            _myTeamKudosList.Add(new KudosItem { ImageURL = "iconsecond.png", ReceiverName = "Joe Blade", GiverName = "Sam curren gave kudos to", Date = new DateOnly(2024, 5, 9) });
            _myTeamKudosList.Add(new KudosItem { ImageURL = "iconthird.png", ReceiverName = "Kevin Piterson", GiverName = "Klassen jade gave kudos to", Date = new DateOnly(2024, 2, 10) });

            // Populate AllKudosList (sample data)
            _allKudosList.Add(new KudosItem { ImageURL = "iconthird.png", ReceiverName = "User 3", GiverName = "User Z gave kudos to", Date = new DateOnly(2024, 2, 10) });
            _allKudosList.Add(new KudosItem { ImageURL = "iconfirst.png", ReceiverName = "Kevin Baker", GiverName = "Susan Barry gave kudos to", Date = new DateOnly(2023, 6, 23) });
            _allKudosList.Add(new KudosItem { ImageURL = "iconsecond.png", ReceiverName = "Joe Blade", GiverName = "Sam curren gave kudos to", Date = new DateOnly(2024, 5, 9) });
        }

        //private void UpdateDisplayedKudosList()
        //{
        //    switch (SelectedSegmentIndex)
        //    {
        //        case 0:
        //            DisplayedKudosList = _kudosList;
        //            break;
        //        case 1:
        //            DisplayedKudosList = _myTeamKudosList;
        //            break;
        //        case 2:
        //            DisplayedKudosList = _allKudosList;
        //            break;
        //        default:
        //            DisplayedKudosList = new ObservableCollection<KudosItem>();
        //            break;
        //    }
        //}
    }
}
