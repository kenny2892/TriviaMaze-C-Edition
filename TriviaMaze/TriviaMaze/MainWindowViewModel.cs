using GalaSoft.MvvmLight;
using System.Windows.Input;
using System.Windows.Media;
using TriviaMaze.ViewModels;

namespace TriviaMaze
{
    public class MainWindowViewModel : ViewModelBase
    {
        private MapViewModel MapVm { get; }
        private CustomizeViewModel CustomizeVm { get; }

        private object _CurrentVm;

        public object CurrentVm
        {
            get => _CurrentVm;
            set => Set(ref _CurrentVm, value);
        }

        public MainWindowViewModel()
        {
            MapVm = new MapViewModel(NavigateViews);
            CustomizeVm = new CustomizeViewModel(NavigateViews);

            CurrentVm = MapVm;
        }

        private void NavigateViews(GameViewAction action)
        {
            switch (action)
            {
                case GameViewAction.Customize:
                    CustomizeVm.UiColorSelected = MapVm.UiColorSelected;
                    CustomizeVm.UiColorUnSelected = MapVm.UiColorUnSelected;
                    CustomizeVm.DoorColorSelected = MapVm.DoorColorSelected;
                    CustomizeVm.DoorColorUnSelected = MapVm.DoorColorUnSelected;
                    CurrentVm = CustomizeVm;
                    break;

                case GameViewAction.Map:
                    if(MapVm.UiColorSelected != CustomizeVm.UiColorSelected)
                        MapVm.UiColorSelected = CustomizeVm.UiColorSelected;

                    if(MapVm.UiColorUnSelected != CustomizeVm.UiColorUnSelected)
                        MapVm.UiColorUnSelected = CustomizeVm.UiColorUnSelected;

                    if (MapVm.DoorColorUnSelected != CustomizeVm.DoorColorUnSelected)
                        MapVm.DoorColorUnSelected = CustomizeVm.DoorColorUnSelected;

                    if (MapVm.DoorColorSelected != CustomizeVm.DoorColorSelected)
                        MapVm.DoorColorSelected = CustomizeVm.DoorColorSelected;

                    CurrentVm = MapVm;
                    break;
            }
        }
    }
}